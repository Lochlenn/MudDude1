using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidlandSocketServer;
using System.IO;
using System.Data;
using System.Globalization;
using CsvHelper;

namespace MudDude1
{
    class CmdProcessor
    {
        Parser mParser;

        private enum CommandType { Align, Life, Home, Retrain, Unknown };
        CommandType commandType = CommandType.Unknown;

        public EventHandler<SendCommandToHostEventArgs> RaiseSendCommandToHostEvent;
        public CmdProcessor(Parser _parser)
        {
            mParser = _parser;

            // parser events subscription
            mParser.RaiseCommandReceivedEvent += ProcessReceivedCommand;
            mParser.RaiseHomeCheckEvent += ProcessHomeCheckData;
        }

        // set command type for reply, and run correct function
        private void ProcessReceivedCommand(object sender, CommandReceivedEventArgs crea)
        {
            string[] commandSplit = crea.CommandToBeExecuted.Split(' ');
            string commandKeyWord = commandSplit[0].ToLower();
            switch (commandKeyWord)
            {
                case "good":
                    commandType = CommandType.Align;
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "evil":
                    commandType = CommandType.Align;
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "neutral":
                    commandType = CommandType.Align;
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "unlawful":
                    commandType = CommandType.Align;
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "lawful":
                    commandType = CommandType.Align;
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "saint":
                    commandType = CommandType.Align;
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "life":
                    commandType = CommandType.Life;
                    ProcessLifeCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "home":
                    commandType = CommandType.Home;
                    ProcessHomeCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "retrain":
                    commandType = CommandType.Retrain;
                    ProcessRetrainCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                default:
                    if (commandType == CommandType.Unknown)
                        ProcessUnknownCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
            }
        }

        // Old version, before configurable alignment settings

        //private void ProcessAlignmentCommand(string _executer, string _command)
        //{
        //    if (!MudDude1.Default.ALLOW_ANY_ALIGNMENT_CHANGES)
        //    {
        //        OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
        //    }
            
        //    // build telepath header
        //    string telepathHeader = "sys god " + _executer + " ";
        //    string completedCommandToSend = telepathHeader + "neutral";

        //    if (MudDude1.Default.ALLOW_SET_EVIL || MudDude1.Default.ALLOW_SET_GOOD || MudDude1.Default.ALLOW_SET_NEUTRAL
        //        || MudDude1.Default.ALLOW_SET_LAWFUL || MudDude1.Default.ALLOW_SET_UNLAWFUL || MudDude1.Default.ALLOW_SET_SAINT)
        //    {
	       //     OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(completedCommandToSend));
        //    }

        //    // if evil is requested, manually set evil points to INT_EVILPOINTS_FOR_EVIL
        //    // otherwise use the word from _command which will be 'good' 'neutral' or 'evil'
        //    if (_command == "evil")
        //        completedCommandToSend = telepathHeader + "add evil " + MudDude1.Default.INT_EVILPOINTS_FOR_EVIL; 
        //    else
        //        completedCommandToSend = telepathHeader + _command;

        //    OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(completedCommandToSend));
        //    OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
        //}

        private void ProcessLifeCommand(string _executer, string _command)
        {
            string completedCommandToSend = "sys god " + _executer + " add life";
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(completedCommandToSend));
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
        }

        private void ProcessRetrainCommand(string _executer, string _command)
        {
            string completedCommandToSend = "sys god " + _executer + " retrain";
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(completedCommandToSend));
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
        }

        private void ProcessHomeCommand(string _executer, string _command)
        {
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
            string monsterName = "";
            // strip home from _command
            string[] splitCommandString = _command.Split(' ');
            for (int i = 0; i < splitCommandString.Length; i++)
            {
                if (i > 0)
                {
                    // space required for mobs with multiple words for names,
                    // the leading space is trimmed when building lookupCommand
                    monsterName += " " + splitCommandString[i];
                }
            }

            string lookupCommand = GenerateLookupString(monsterName.Trim());
            // empty string means monster not found
            if (lookupCommand == "")
            {
                string notFoundCommand = "/" + _executer + " Monster not found.";
                OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(notFoundCommand));
            }
            else
            {
                // send completed lookup string 'sys stat room 224 1'
                OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(lookupCommand));
            }
        }

        private void ProcessUnknownCommand(string _executer, string _command)
        {
            Console.WriteLine("Unknown Command Received");
        }

        // builds a string to send back to the executer, confirming command
        private string AssembleConfirmation(string _executer, string _command)
        {
            // builds the telepath ie '/username '
            string preCommand = "/" + _executer + " ";

            // empty string to be filled by the switch, based on command type
            string postCommand = "";
            switch (commandType)
            {
                case CommandType.Align:
                    postCommand = "Alignment change successful.";
                    if (MudDude1.Default.ALLOW_ANY_ALIGNMENT_CHANGES == false)
                        postCommand = "Alignment changes not allowed by server.";
                    if (_command.ToLower().Contains("notallowed"))
                        postCommand = "Selected Alignment not allowed by server.";
                    break;
                case CommandType.Life:
                    postCommand = "Added 1 life.";
                    break;
                case CommandType.Home:
                    postCommand = "Checking...";
                    break;
                case CommandType.Retrain:
                    postCommand = "Retrain successful.  Relog now.";
                    break;
                case CommandType.Unknown:
                    postCommand = "Unknown command.";
                    break;
                default:
                    postCommand = "Unknown command.";
                    break;
            }
            // send back complete telepath '/username did the thing'
            return preCommand + postCommand;
        }

        private string GenerateLookupString(string _mobToLookUp)
        {
            // better to build the string here for now
            string lookupString = "sys stat room ";

            // file should exist next to MudDude1.exe
            using (var reader = new StreamReader(".\\athome.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<MonsterDB>();

                // dump to list, file is tiny, memory is non issue
                var mobList = records.ToList();
                // Console.WriteLine(_mobToLookUp);
                foreach (var mob in mobList)
                {
                    if (mob.mobName.ToLower().Contains(_mobToLookUp.ToLower()))
                    {
                        // build room/map number portion of the lookup string
                        lookupString += mob.roomNumber.ToString() + " " + mob.mapNumber.ToString();
                        return lookupString;
                    }
                }
            }
            // return empty string so caller knows no record found
            return "";
            
        }

        private void ProcessHomeCheckData(object sender, HomeCheckEventArgs hcea)
        {
            // build string showing mob/regen/last killed
            string finalOutput = "gos " + hcea.MonsterName + " (RG:" + hcea.RespawnTime.ToString() + "h) killed:" + hcea.LastKilled;
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(finalOutput));
            // if the system returns alive, the monster is up and ready
            if (hcea.ReportedAlive)
            {
                finalOutput = "gos " + hcea.MonsterName + " is currently alive!";
            }
            else
            {
                // repawn timer has expired, mob should spawn when the room is entered or looked into
                if (hcea.TimeUntilRespawn < 0)
                    finalOutput = "gos " + hcea.MonsterName + " should be alive, go take a look!";
                else
                    finalOutput = "gos " + hcea.MonsterName + " will respawn in " + hcea.TimeUntilRespawn.ToString() + " hours."; //mob dead, show time until respawn
            }
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(finalOutput));

        }

        public void OnRaiseSendCommandToHostEvent(object sender, SendCommandToHostEventArgs scea)
        {
            EventHandler<SendCommandToHostEventArgs> handler = RaiseSendCommandToHostEvent;

            if (handler != null)
                handler(this, scea);
        }

        // monsterdb class for field structure
        public class MonsterDB
        {
            public string mobName { get; set; }

            public int mapNumber { get; set; }

            public int roomNumber { get; set; }
        }

        private void ProcessAlignmentCommand(string _executer, string _command)
        {
            string commandToBuild = "sys god " + _executer + " ";
            // if align changes are disabled, drop out asap
            if (!MudDude1.Default.ALLOW_ANY_ALIGNMENT_CHANGES)
            {
                OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
                return;
            }
            else if (_command.ToLower() == "saint")
            {
                if (MudDude1.Default.ALLOW_SET_SAINT)
                    commandToBuild += "saint";
                else
                    _command += "NOTALLOWED";
            }

            else if (_command.ToLower() == "lawful")
            {
                if (MudDude1.Default.ALLOW_SET_LAWFUL)
                    commandToBuild += "lawful";
                else
                    _command += "NOTALLOWED";
            }

            else if (_command.ToLower() == "unlawful")
            {
                if (MudDude1.Default.ALLOW_SET_UNLAWFUL)
                    commandToBuild += "unlawful";
                else
                    _command += "NOTALLOWED";
            }

            else if (_command.ToLower() == "good")
            {
                if (MudDude1.Default.ALLOW_SET_GOOD)
                    commandToBuild += "add evil " + MudDude1.Default.INT_CUSTOM_EP_GOOD.ToString();
                else
                    _command += "NOTALLOWED";
            }

            else if (_command.ToLower() == "neutral")
            {
                if (MudDude1.Default.ALLOW_SET_NEUTRAL)
                    commandToBuild += "add evil " + MudDude1.Default.INT_CUSTOM_EP_NEUTRAL.ToString();
                else
                    _command += "NOTALLOWED";
            }

            else if (_command.ToLower() == "evil")
            {
                if (MudDude1.Default.ALLOW_SET_EVIL)
                    commandToBuild += "add evil " + MudDude1.Default.INT_EVILPOINTS_FOR_EVIL.ToString();
                else
                    _command += "NOTALLOWED";
            }

            if (_command.Contains("NOTALLOWED"))
            {
                OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
                return;
            }
            //TODO not quite working right, fully disabled isnt detected live
            // first set to neutral, so we are working with an ep value of 0
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs("sys god " + _executer + " neutral"));
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(commandToBuild));
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
        }
    }
}
