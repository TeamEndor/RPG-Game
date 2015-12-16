using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame.Interfaces;
using SAGame.UI;

namespace SAGame.Engine
{
    public class Engine :IEngine
    {
        private bool GameIsRunning = true;
        private IReader reader;
        private IRender render;

        public void Run()
        {
            while (GameIsRunning)
            {
                var input = reader.Reade();
                ExecuteCommand(input);
            }
        }

       private void ExecuteCommand(string input)
        {

            var comandInfo = input.Split().ToArray();

            Execute(comandInfo);
        }

        protected virtual void Execute(string[] comandInfo)
        {
            switch (comandInfo[0].ToLower())
            {
                case "create":
                    //TODO: command
                    break;
                case "left":
                    //TODO: command
                    break;
                case "right":
                    //TODO: command
                    break;
                case "up":
                    //TODO: command
                    break;
                case "down":
                    //TODO: command
                    break;
                case "status":
                    //TODO: command
                    break;
                case "exit":
                    GameIsRunning = false;
                    break;
            }
        }
        
    }
}
