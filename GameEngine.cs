using GADE_6112_Project1.GADE_6112_Project1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class GameEngine
    {
        public Map map;
        private static readonly char
            HeroChar = 'ඞ',
            SwampCreatureChar = 'Ω',
            ObstacleChar = '║',
            EmptyChar = ',',
            GoldChar = '⌬',
            MageChar = 'm';///3.1
        public  GameEngine()
        {
            map = new Map(12, 16, 12, 16, 1,2);
        }
        public Map Map { get => map; }
        public bool MovePlayer(Character.Movement direction) //Movement for player 
        {
            if (map.hero.ReturnMove() == direction)
            {
                map.hero.Move(direction);
                map.GameMap[map.hero.Y, map.hero.X] = new Hero(map.hero.Y, map.hero.X, 99, 99,0) { Type = Tile.Tiletype.Hero };
                switch (direction)
                {
                    case Character.Movement.Up:
                        Map.GameMap[map.hero.Y + 1, map.hero.X] = new EmptyTile(map.hero.Y + 1, map.hero.X) { Type = Tile.Tiletype.Hero };
                        break;
                    case Character.Movement.Down:
                        Map.GameMap[map.hero.Y - 1, map.hero.X] = new EmptyTile(map.hero.Y - 1, map.hero.X) { Type = Tile.Tiletype.Hero };
                        break;
                    case Character.Movement.Left:
                        Map.GameMap[map.hero.Y, map.hero.X - 1] = new EmptyTile(map.hero.Y, map.hero.X + 1) { Type = Tile.Tiletype.Hero };
                        break;
                    case Character.Movement.Right:
                        Map.GameMap[map.hero.Y, map.hero.X + 1] = new EmptyTile(map.hero.Y, map.hero.X - 1) { Type = Tile.Tiletype.Hero };
                        break;
                }
                map.UpdateVision();
                
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString() // Symbols generator for the map
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < map.MapWidth; i++)
            {
                for (int j = 0; j < map.MapHeight; j++)
                {
                    switch (map.GameMap[i, j].Type)
                    { 
                        case Tile.Tiletype.Hero:
                            stringBuilder.Append(HeroChar);
                            break;
                        case Tile.Tiletype.Obstacle:
                            stringBuilder.Append(ObstacleChar);
                            break;
                        case Tile.Tiletype.Enemy:
                            stringBuilder.Append(SwampCreatureChar);
                           stringBuilder.Append(MageChar);
                            break;
                        case Tile.Tiletype.EmptyTile:
                            stringBuilder.Append(EmptyChar);
                            break;
                        case Tile.Tiletype.Weapon:
                            break;
                        case Tile.Tiletype.Gold:
                            stringBuilder.Append(GoldChar);//3.1
                            break;
                    
                        default:
                            break;

                    }
                    stringBuilder.Append("  ");
                }
                stringBuilder.Append('\n');
            }

            return stringBuilder.ToString();
        }

        public void Save(GameEngine gameEngine)
        {

            string fileName = @"C:\Users\nasse\Documents\GitHub\GADE_6112_Project2\Save file\Map file.txt";
            FileInfo fi = new FileInfo(fileName);
            try
            {
                // Check if file already exists. If yes, delete it.     
                if (fi.Exists)
                {
                    fi.Delete();
                }

                // Create a new file     
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.WriteLine("New file created: {0}", DateTime.Now.ToString());
                    sw.WriteLine(gameEngine.ToString());
                }

                // Write file contents on console.     
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }

        }
        public string Load(GameEngine gameEngine)
        {
            string textFile = @"C:\Users\nasse\Documents\GitHub\GADE_6112_Project2\Save file\Map file.txt";
             string text = File.ReadAllText(textFile);
            return text;
        }

    }
}