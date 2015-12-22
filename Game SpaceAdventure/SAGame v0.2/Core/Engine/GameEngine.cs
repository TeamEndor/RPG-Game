using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using SAGame_v0._2.Enums;
using SAGame_v0._2.GameDataBase;
using SAGame_v0._2.Interfaces;
using SAGame_v0._2.Items;

namespace SAGame_v0._2.Core.Engine
{
    public class GameEngine : IEngine
    {
        private const int MinItemsCount = 3;
        private const int MaxItemsCount = 8;

        private const int MinEnemyCount = 2;
        private const int MaxEnemyCount = 6;

        private static readonly Random Rand = new Random();
        private readonly IInputReader reader;
        private readonly IRenderer renderer;
        private readonly IDataBase dataBase;
        private readonly IFactory factory;
        

        public GameEngine(IInputReader reader, IRenderer renderer, IDataBase dataBase, IFactory factory)
        {
            this.reader = reader;
            this.renderer = renderer;
            this.dataBase = dataBase;
            this.factory = factory;
        }

        public virtual void Run()
        {

            var message = ChooseShipMessage();
            this.renderer.WriteLine(message);
            this.AddEnemies();
            this.AddItems();
            
            
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
                    var playerShip = this.factory.CreatePlayer(commandParams);
                    this.dataBase.Player.Add(playerShip);
                    break;
                case "w":           //up
                    this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X, this.dataBase.Player[0].Position.Y - 1);
                    this.renderer.Clear();
                    this.CheckIfInMap();
                    this.CheckForCollision();
                    break;
                case "s":           //down
                    this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X, this.dataBase.Player[0].Position.Y + 1);
                    this.renderer.Clear();
                    this.CheckIfInMap();
                    this.CheckForCollision();
                    break;
                case "a":           //left
                    this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X - 1, this.dataBase.Player[0].Position.Y);
                    this.renderer.Clear();
                    this.CheckIfInMap();
                    this.CheckForCollision();
                    break;
                case "d":           //right
                    this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X + 1, this.dataBase.Player[0].Position.Y);
                    this.renderer.Clear();
                    this.CheckIfInMap();
                    this.CheckForCollision();
                    break;
                case "status":
                    this.PrintStatus();
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

        private string ChooseShipMessage()
        {
            StringBuilder message = new StringBuilder();
            message.Append("Choose your ship:");
            foreach (var ship in dataBase.PlayerShipsChoice)
            {
                message.AppendFormat(Environment.NewLine + ship);
            }
            return message.ToString();
        }

        private void AddEnemies()
        {
            
            int randEnemyCount = Rand.Next(MinEnemyCount, MaxEnemyCount);
            for (int i = 0; i < randEnemyCount; i++)
            {
                int randEnemyType = Rand.Next(1, 4);
                int enemyRandPosX = Rand.Next(1, Constants.MapWidth - 1);
                int enemyRandPosY = Rand.Next(1, Constants.MapHeight - 1);
                var enemy = this.factory.CreateEnemies(randEnemyType, enemyRandPosX, enemyRandPosY);
                this.dataBase.Enemy.Add(enemy);
            }
        }

        private void AddItems()
        {
            int randItemsCount = Rand.Next(MinItemsCount, MaxItemsCount);
            for (int i = 0; i < randItemsCount; i++)
            {
                int itemType = Rand.Next(1, 3);
                int itemRandPosX;
                int itemRandPosY;
                bool isEmpty = true;
                do
                {
                    itemRandPosX = Rand.Next(1, Constants.MapWidth - 1);
                    itemRandPosY = Rand.Next(1, Constants.MapHeight - 1);
                    foreach (var enemy in this.dataBase.Enemy)
                    {
                        if (itemRandPosX != enemy.Position.X || itemRandPosY != enemy.Position.Y)
                        {
                            isEmpty = false;
                            break;
                        }
                    }

                } while (isEmpty);

                var item = this.factory.CreateItem(itemType, itemRandPosX, itemRandPosY);
                this.dataBase.AddToItems(item);
            }
        }

        private void CheckIfInMap()
        {
            if (this.dataBase.Player[0].Position.Y < 0)                                                 //up 
            {
                this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X, this.dataBase.Player[0].Position.Y + 1);
            }
            if (this.dataBase.Player[0].Position.Y + 1 > Constants.MapHeight)                           //down
            {
                this.dataBase.Player[0].Position = new Position(
                       this.dataBase.Player[0].Position.X, this.dataBase.Player[0].Position.Y - 1);     
            }
            if (this.dataBase.Player[0].Position.X < 0)                                                 //left
            {
                this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X + 1, this.dataBase.Player[0].Position.Y);   
            }
            if (this.dataBase.Player[0].Position.X + 1 > Constants.MapWidth)
            {
                this.dataBase.Player[0].Position = new Position(
                        this.dataBase.Player[0].Position.X - 1, this.dataBase.Player[0].Position.Y);    //right
            }
        }

        private void DisplayMap()
        {
            StringBuilder map = new StringBuilder();
            for (int row = 0; row < Constants.MapHeight; row++)
            {
                for (int col = 0; col < Constants.MapWidth; col++)
                {
                    if (this.dataBase.Player[0].Position.X == col && this.dataBase.Player[0].Position.Y == row)
                    {
                        map.Append(this.PlayerName(this.dataBase.Player[0].Name));
                    }
                    else if (this.dataBase.Enemy.Any())
                    {
                        foreach (var enemy in this.dataBase.Enemy)
                        {
                            if ((enemy.ShieldStatus > 0) && (enemy.Position.X == col && enemy.Position.Y == row))
                            {
                                map.Append(this.EnemyName(enemy.Name));
                            }
                        }
                    }
                    else if (this.dataBase.Items.Any())
                    {
                        foreach (var item in this.dataBase.Items)
                        {
                            if (item.State == ItemState.Available && (item.Position.X == col && item.Position.Y == row))
                            {
                                map.Append(this.ItemName(item.Name));
                            }
                            
                        }
                    }
                    

                    if (this.CheckIfEmptySpace(col, row))
                    {
                        map.Append('.');
                    }
                }
                map.AppendLine();
            }
            this.renderer.WriteLine(map.ToString());
        }

        private char PlayerName(string name)
        {
            switch (name)
            {
                case "Starfighter":
                    return 'S';
                case "MillenniumFalcon":
                    return 'M';
                default:
                    throw new AggregateException("Unknown player name!");
            }
        }

        private char EnemyName(string name)
        {
            switch (name)
            {
                case "Gunship":
                    return 'G';
                case "Ramship":
                    return 'R';
                case "Warship":
                    return 'W';
                default:
                    throw new AggregateException("Unknown ship name!");
            }
        }

        private char ItemName(string name)
        {
            switch (name)
            {
                case "RegularDC17":
                    return 'D';
                case "Imperium":
                    return 'I';
               default:
                    throw new AggregateException("Unknown ship name!");
            }
        }

        private bool CheckIfEmptySpace(int col, int row)
        {
            if (this.dataBase.Player[0].Position.X == col && this.dataBase.Player[0].Position.Y == row)
            {
                return false;
            }
            
            foreach (var enemy in this.dataBase.Enemy)
            {
                if ((enemy.ShieldStatus > 0) && (enemy.Position.X == col && enemy.Position.Y == row))
                {
                    return false;
                }
            }

            foreach (var item in this.dataBase.Items)
            {
                if (item.State == ItemState.Available && (item.Position.X == col && item.Position.Y == row))
                {
                    return false;
                }
            }

            return true;
        }

        private void CheckForCollision()
        {
            var collidingObject = this.dataBase.Enemy.
                FirstOrDefault(e => e.Position.Equals(this.dataBase.Player[0].Position));

            var item = collidingObject as Item;

            if (item != null)
            {
                this.dataBase.Player[0].AddItemToInventory(item);
                this.renderer.WriteLine("Added item to inventory:" + item.GetType().Name);
                item.State = ItemState.Collected;
            }

            var enemy = collidingObject as ICharacter;

            if (enemy != null)
            {
                this.EnterAttackPhase(enemy);
            }
        }

        private void EnterAttackPhase(ICharacter enemy)
        {
            if (enemy.ShieldStatus == 0)
            {
                return;
            }

            this.renderer.WriteLine(
                "Enemy encountered: {0} (damage: {1}, shield status: {2})" ,
                enemy.GetType().Name,
                enemy.Damage,
                enemy.ShieldStatus);

            while (enemy.ShieldStatus > 0)
            {
                this.renderer.WriteLine("Do you want to attack? (y/n)");

                string choice = this.reader.ReadLine();

                while (choice != "n" & choice != "y")
                {
                    this.renderer.WriteLine("Invalid choice, please enter 'y' or 'n'.");
                    choice = this.reader.ReadLine();
                }

                switch (choice)
                {
                    case "n":
                        this.renderer.WriteLine("Loser !!!");
                        return;
                    case "y":
                        this.PerformAttack(enemy);
                        break;
                }
            }
        }
        private void PerformAttack(ICharacter enemy)
        {
            dataBase.Player[0].Attack(enemy);

            if (enemy.ShieldStatus == 0)
            {
                this.dataBase.Enemy.Remove(enemy);
                this.renderer.WriteLine("Enemy was defeated!");
                return;
            }

            enemy.Attack(this.dataBase.Player[0]);
            this.renderer.WriteLine("Damage taken!");
            this.renderer.WriteLine("Player hit points: {0}", this.dataBase.Player[0].ShieldStatus);
            this.renderer.WriteLine("Enemy hit points: {0}" , enemy.ShieldStatus);
        }

        private void PrintStatus()
        {
            StringBuilder playerStatus = new StringBuilder();
            playerStatus.AppendFormat(this.dataBase.Player[0].ToString());
            if (this.dataBase.Inventory.Any())
            {
                playerStatus.Append(Environment.NewLine + "Items: ");
                foreach (var item in this.dataBase.Inventory)
                {
                    playerStatus.AppendFormat(string.Join(" ,", item.Name));
                }
            }
            this.renderer.WriteLine(playerStatus.ToString());
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
