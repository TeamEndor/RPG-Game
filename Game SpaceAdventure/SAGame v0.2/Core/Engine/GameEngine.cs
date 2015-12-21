using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Interfaces;

namespace SAGame_v0._2.Core.Engine
{
    public class GameEngine : IEngine
    {
        private readonly IInputReader reader;
        private readonly IRenderer renderer;
        private readonly IDataBase dataBase;

        public GameEngine(IInputReader reader, IRenderer renderer, IDataBase dataBase)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.dataBase = dataBase;
        }

        public virtual void Run()
        {

            var message = ChooseShipMessage();
            this.renderer.WriteLine(message);

            this.DisplayMap();
            while (true)
            {
                var input = this.reader.ReadLine();
                var inputInfo = input.Split().ToArray();
                ExecuteCommand(inputInfo);
                this.DisplayMap();
            }
        }

        protected virtual void ExecuteCommand(string[] inputInfo)
        {
            var command = inputInfo[0].ToLower();
            var commandParams = inputInfo.Skip(1).ToArray();
            switch (command)
            {
                case "create":
                    //TODO
                    break;
                case "w":           //up
                    //TODO up
                    break;
                case "s":           //down
                    //TODO: down
                    break;
                case "a":           //left
                    //TODO: left
                    break;
                case "d":           //right
                    //TODO right
                    break;
                case "status":
                    //TODO
                    break;
                case "help":
                    PrintHelp();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    this.renderer.WriteLine("Unknown command!");
                    break;
            }
        }

        protected virtual string ChooseShipMessage()
        {
            StringBuilder message = new StringBuilder();
            message.Append("Choose your ship:");
            foreach (var ship in dataBase.PlayerShipsChoice)
            {
                message.AppendFormat(Environment.NewLine + ship);
            }
            return message.ToString();
        }

        protected virtual void DisplayMap()
        {
            StringBuilder map = new StringBuilder();
            //map.AppendLine("P - Player, E - Enemy");

            for (int row = 0; row < Constants.MapHeight; row++)
            {
                for (int col = 0; col < Constants.MapWidth; col++)
                {
                    map.Append(".");
                    //if (this.player.Position.X == col && this.player.Position.Y == row)
                    //{
                    //    sb.Append('P');
                    //    continue;
                    //}

                    //IGameObject currentObject = this.entities
                    //    .FirstOrDefault(e => e.Position.X == col && e.Position.Y == row);

                    //if (currentObject is ICollectible && (currentObject as ICollectible).State == ItemState.Available)
                    //{
                    //    sb.Append('T');
                    //}
                    //else if (currentObject is ICharacter && (currentObject as ICharacter).HitPoints > 0)
                    //{
                    //    sb.Append(currentObject.GetType().Name[0]);
                    //}
                    //else
                    //{
                    //    sb.Append('.');
                    //}
                }

                map.AppendLine();
            }

            this.renderer.WriteLine(map.ToString());
        }

        protected virtual void PrintHelp()
        {
            StringBuilder help = new StringBuilder();
            help.Append("create {Write the name of the ship you are going to play with (without {}) --> " +
                        "with this command you create your player" + Environment.NewLine +
                            "w --> go up" + Environment.NewLine +
                            "s --> go down" + Environment.NewLine +
                            "a --> go left" + Environment.NewLine +
                            "d --> go right" + Environment.NewLine +
                            "status --> pints the current player status" + Environment.NewLine +
                            "exit --> ends the game");
            this.renderer.WriteLine(help.ToString());
        }
    }
}
