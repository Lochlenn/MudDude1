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
        public CmdProcessor(Parser _parser)
        {
            mParser = _parser;
            mParser.RaiseCommandReceivedEvent += ProcessReceivedCommand;
        }

        private void ProcessReceivedCommand(object sender, CommandReceivedEventArgs crea)
        {
            //Console.WriteLine("command received at processor");
            string[] commandSplit = crea.CommandToBeExecuted.Split(' ');
            string commandKeyWord = commandSplit[0].ToLower();
            switch (commandKeyWord)
            {
                case "good":
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "evil":
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "neutral":
                    ProcessAlignmentCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "life":
                    ProcessLifeCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "home":
                    ProcessHomeCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                case "retrain":
                    ProcessRetrainCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
                default:
                    ProcessUnknownCommand(crea.CommandExecuter, crea.CommandToBeExecuted);
                    break;
            }
        }

        private void ProcessAlignmentCommand(string _executer, string _command)
        {
            Console.WriteLine("Alignment Command Received");
        }

        private void ProcessLifeCommand(string _executer, string _command)
        {
            Console.WriteLine("Life command received");
        }

        private void ProcessRetrainCommand(string _executer, string _command)
        {
            Console.WriteLine("Retrain Command Received");
        }

        private void ProcessHomeCommand(string _executer, string _command)
        {
            Console.WriteLine("Home Command Received");
        }

        private void ProcessUnknownCommand(string _executer, string _command)
        {
            Console.WriteLine("Unknown Command Received");
        }
    }
}
