using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidlandSocketServer;
using System.Timers;

namespace MudDude1
{
    class Parser
    {
        MidlandSocketClient mClient;
        CmdProcessor mProcessor;

        public EventHandler<UpdateOutputEventArgs> RaiseUpdateOutputEvent;
        public EventHandler<UpdateUIEventArgs> RaiseUpdateUIEvent;
        public EventHandler<CommandReceivedEventArgs> RaiseCommandReceivedEvent;

        private bool isConnectedToHost = false;
        private bool isLoggedInToServer = false;
        private bool isInGame = false;

        // ansi escape char
        private const char eC = '\u001b';

        System.Timers.Timer reconnectTimer; 

        public Parser()
        {
            InitClient();
        }

        private void Disconnected(object sender, DisconnectedEventArgs dcea)
        {
            // concatenate strings to form reason, just for logging
            string error = "";
            for (int i = 0; i < dcea.DisconnectReason.Length - 1; i++)
            {
                error += dcea.DisconnectReason[i] + " ";
            }
            Console.WriteLine(error);
            isConnectedToHost = false;

            // unsubscribe from mClient events
            mClient.RaiseDisconnectEvent -= Disconnected;
            mClient.RaiseTextReceivedEvent -= PreParseIncomingData;

            isConnectedToHost = false;
            isLoggedInToServer = false;
            isInGame = false;
            OnRaiseUpdateUIEvent(this, new UpdateUIEventArgs(isConnectedToHost, isLoggedInToServer, isInGame));
            OnRaiseUpdateOutputEvent(this, new UpdateOutputEventArgs("Disconnected..."));

            // start reconnect timer
            SetReconnectTimer();
            reconnectTimer.Start();
        }

        private void SetReconnectTimer()
        {
            reconnectTimer = new System.Timers.Timer(10000); // 10 seconds
            reconnectTimer.Enabled = true;
            reconnectTimer.Stop();
            reconnectTimer.Elapsed += ReconnectToHost;
            reconnectTimer.AutoReset = false;
        }

        private void InitClient()
        {
            if (mClient != null)
                mClient = null;
            if (mClient == null)
                mClient = new MidlandSocketClient();

            if (mProcessor != null)
                mProcessor = null;
            if (mProcessor == null)
                mProcessor = new CmdProcessor(this);

            // subscribe to mClient events
            mClient.RaiseDisconnectEvent += Disconnected;
            mClient.RaiseTextReceivedEvent += PreParseIncomingData;
        }

        public async Task TryConnect()
        {
            // send IP/port to client
            mClient.SetServerIPAddress(MudDude1.Default.STRING_SERVER_IP);
            mClient.SetServerPortNumber(MudDude1.Default.INT_SERVER_PORT);

            try
            {
                await mClient.ConnectToServer();
            }
            catch (Exception ex)
            {
                // this should never throw socket exceptions 
                Console.WriteLine("TryConnectParser: " + ex.ToString());
            }
        }

        // check incoming text for login triggers (triggers here are only used for logging in, they will not execute once in game)
        private async Task DoLoginRoutine(string _lineToParse)
        {
            OnRaiseUpdateUIEvent(this, new UpdateUIEventArgs(isConnectedToHost, isLoggedInToServer, isInGame));
            if (!isLoggedInToServer && 
                _lineToParse.ToLower().Trim().Contains(MudDude1.Default.STRING_LOGIN_USERNAME.ToLower()))
            {
                await mClient.SendToServer(MudDude1.Default.STRING_USERID + "\r");
            }
            if (!isLoggedInToServer && 
                _lineToParse.ToLower().Trim().Contains(MudDude1.Default.STRING_LOGIN_PASSWORD.ToLower()))
            {
                await mClient.SendToServer(MudDude1.Default.STRING_PASSWORD + "\r");
                isLoggedInToServer = true;
            }
            if (!isInGame && isLoggedInToServer && 
                _lineToParse.ToLower().Trim().Contains(MudDude1.Default.STRING_TOP_MENU.ToLower()))
            {
                await mClient.SendToServer(MudDude1.Default.STRING_GO_COMMAND + "\r");
            }
            if (!isInGame && isLoggedInToServer && 
                _lineToParse.Trim().Contains("[MAJORMUD]"))
            {
                await mClient.SendToServer("enter\r");
                isInGame = true;
            }
            OnRaiseUpdateUIEvent(this, new UpdateUIEventArgs(isConnectedToHost, isLoggedInToServer, isInGame));
        }

        private void ReconnectToHost(Object source, ElapsedEventArgs e)
        {
            OnRaiseUpdateUIEvent(this, new UpdateUIEventArgs(isConnectedToHost, isLoggedInToServer, isInGame));
            Console.WriteLine("Reconnecting...");

            // kill timer
            reconnectTimer.Stop();
            reconnectTimer.Close();

            // null and recreate mClient
            InitClient();

            OnRaiseUpdateOutputEvent(this, new UpdateOutputEventArgs("Reconnecting..."));

            // reconnect
            TryConnect();

        }

        public void SendConsoleCommand(string _textToSend)
        {
            mClient.SendToServer(_textToSend + "\r");
        }

        // event function, runs whenever data is received
        protected virtual void PreParseIncomingData(object sender, TextReceivedEventArgs trea)
        {
            isConnectedToHost = true;

            // split string into individual lines
            string[] splitString = SplitDataIntoLines(trea.TextReceived);
            
            // send each line to main parser
            for (int i = 0; i < splitString.Length; i++)
            {
                // raise event to update output window on main form
                OnRaiseUpdateOutputEvent(this, new UpdateOutputEventArgs(ParseANSICodes(splitString[i])));

                // should handle all pauses
                CheckForPauseString(ParseANSICodes(splitString[i]));

                // if not logged in, fire login routine
                if (!isLoggedInToServer || !isInGame)
                {
                    
                    DoLoginRoutine(ParseANSICodes(splitString[i]));
                }
                else
                {
                    ParseCleanLines(ParseANSICodes(splitString[i]));
                }
            }
        }

        private void CheckForPauseString(string _lineToCheck)
        {
            
            if (_lineToCheck.ToLower().Trim().Contains(MudDude1.Default.STRING_PAUSE_STRING.ToLower()))
            {
                mClient.SendToServer("\r");
            }
                
        }

        // main body of parser
        private async Task ParseCleanLines(string _lineToParse)
        {

            string lineToParse = _lineToParse;

            // set long strings for ease of reading
            string triggerString = "telepaths: " + MudDude1.Default.CHAR_TRIGGER.ToString();
            string triggerString2 = "telepaths: " + MudDude1.Default.CHAR_TRIGGER2.ToString();

            if (lineToParse.Contains(triggerString) ||
                lineToParse.Contains(triggerString2))
            {
                // Send command line to be split into executer/command
                SplitCommand(lineToParse);
            }
            else if (false)
            {
                // TODO check for other things, like 'specific monster'
            }
        }

        private async Task SplitCommand(string _capturedLine)
        {
            string[] splitCapturedLine = { "" };

            // check both triggers
            if (_capturedLine.Contains(MudDude1.Default.CHAR_TRIGGER.ToString()))
            {
                splitCapturedLine = _capturedLine.Split(MudDude1.Default.CHAR_TRIGGER);
            }
            else if (_capturedLine.Contains(MudDude1.Default.CHAR_TRIGGER2.ToString()))
            {
                splitCapturedLine = _capturedLine.Split(MudDude1.Default.CHAR_TRIGGER2);
            }

            // line is empty, something wrong happened, exit function
            if (splitCapturedLine[0] == "")
                return;

            // check for 'telepaths:'
            for (int i = 0; i < splitCapturedLine.Length; i++)
            {
                if (splitCapturedLine[i].Contains("telepaths:"))
                {
                    // telepaths: exists, must be string with executers name
                    // split at spaces = executer[0]
                    string[] spaceSplitString = splitCapturedLine[i].Split(' ');

                    // index 0 will be executers name
                    string commandExecuter = spaceSplitString[0];

                    // everything after 'telepaths:' must be command
                    string commandToRun = splitCapturedLine[i + 1];

                    // send split command to command processor
                    OnRaiseCommandReceivedEvent(this, new CommandReceivedEventArgs(commandExecuter, commandToRun));
                }
            }
        }

        // breaks the incoming text into individual lines
        private string[] SplitDataIntoLines(string _incomingRawText)
        {
            string[] splitIncomingString = _incomingRawText.Split('\r');
            //Console.WriteLine(splitIncomingString.Length.ToString());
            return splitIncomingString;
        }

        // removes ansi escape code and other junk
        public string ParseANSICodes(string _rawLine)
        {
            // replace Unicode escape char with Unicode empty char
            string returnLine = _rawLine.Replace(eC, '\u00a0');

            // clear out garbage chars that end up in strings
            returnLine = returnLine.Replace("\0", "");
            returnLine = returnLine.Replace(" \b", "");
            returnLine = returnLine.Replace(" ", "");
            returnLine = returnLine.Replace("", "");
            return returnLine;
        }

        public void OnRaiseUpdateOutputEvent(object sender, UpdateOutputEventArgs uoea)
        {
            EventHandler<UpdateOutputEventArgs> handler = RaiseUpdateOutputEvent;

            if (handler != null)
            {
                handler(this, uoea);
            }
        }

        public void OnRaiseUpdateUIEvent(object sender, UpdateUIEventArgs uuea)
        {
            EventHandler<UpdateUIEventArgs> handler = RaiseUpdateUIEvent;

            if (handler != null)
            {
                handler(this, uuea);
            }
        }

        public void OnRaiseCommandReceivedEvent(object sender, CommandReceivedEventArgs crea)
        {
            EventHandler<CommandReceivedEventArgs> handler = RaiseCommandReceivedEvent;

            if (handler != null)
                handler(this, crea);
        }
    }
}
