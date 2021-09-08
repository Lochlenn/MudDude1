using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MidlandSocketServer;

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
            mParser.RaiseCommandReceivedEvent += ProcessReceivedCommand;
        }

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

        private void ProcessAlignmentCommand(string _executer, string _command)
        {
            // build telepath header
            string telepathHeader = "sys god " + _executer + " ";

            // set executer to neutral first in all cases
            string completedCommandToSend = telepathHeader + "neutral";
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(completedCommandToSend));

            // if evil is requested, manually set evil points to 100
            // otherwise use the word from _command
            if (_command == "evil")
                completedCommandToSend = telepathHeader + "add evil 100";
            else
                completedCommandToSend = telepathHeader + _command;

            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(completedCommandToSend));
            OnRaiseSendCommandToHostEvent(this, new SendCommandToHostEventArgs(AssembleConfirmation(_executer, _command)));
        }

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
            Console.WriteLine("Home Command Received");
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
                    break;
                case CommandType.Life:
                    postCommand = "Added 1 life.";
                    break;
                case CommandType.Home:
                    //TODO change this when @home is added
                    postCommand = "Not yet implemented.";
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

        public void OnRaiseSendCommandToHostEvent(object sender, SendCommandToHostEventArgs scea)
        {
            EventHandler<SendCommandToHostEventArgs> handler = RaiseSendCommandToHostEvent;

            if (handler != null)
                handler(this, scea);
        }

    }
}
