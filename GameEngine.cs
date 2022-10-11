using GADE_6112_Project1.GADE_6112_Project1;
using System;
using System.Collections.Generic;
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
            EmptyChar = ',';
        public  GameEngine()
        {
            map = new Map(12, 16, 12, 16, 1);
        }
        public Map Map { get => map; }
        public bool MovePlayer(Character.Movement direction) //Movement for player 
        {
            if (map.hero.ReturnMove() == direction)
            {
                map.hero.Move(direction);
                map.GameMap[map.hero.Y, map.hero.X] = new Hero(map.hero.Y, map.hero.X, 99, 99) { Type = Tile.Tiletype.Hero };
                switch (direction)
                {
                    case Character.Movement.Up:
                        Map.GameMap[map.hero.Y + 1, map.hero.X] = new EmptyTile(map.hero.Y + 1, map.hero.X) { Type = Tile.Tiletype.Hero };
                        break;
                    case Character.Movement.Down:
                        Map.GameMap[map.hero.Y - 1, map.hero.X] = new EmptyTile(map.hero.Y - 1, map.hero.X) { Type = Tile.Tiletype.Hero };
                        break;
                    case Character.Movement.Left:
                        Map.GameMap[map.hero.Y, map.hero.X + 1] = new EmptyTile(map.hero.Y, map.hero.X + 1) { Type = Tile.Tiletype.Hero };
                        break;
                    case Character.Movement.Right:
                        Map.GameMap[map.hero.Y, map.hero.X - 1] = new EmptyTile(map.hero.Y, map.hero.X - 1) { Type = Tile.Tiletype.Hero };
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
                            break;
                        case Tile.Tiletype.EmptyTile:
                            stringBuilder.Append(EmptyChar);
                            break;
                        case Tile.Tiletype.Weapon:
                            break;
                        case Tile.Tiletype.Gold:
                            break;
                        default:
                            break;

                    }
                    stringBuilder.Append(" ");
                }
                stringBuilder.Append('\n');
            }

            return stringBuilder.ToString();
        }

    }
}