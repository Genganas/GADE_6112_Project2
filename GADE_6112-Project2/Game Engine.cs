using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
    internal class Game_Engine
    {
            public Map map;
            private static readonly char
                HeroChar = 'H',
                SwampCreatureChar = 'Ω',
                ObstacleChar = '║',
                EmptyChar = ',';
            public Game_Engine()
            {
                map = new Map(12, 16, 12, 16, 1);
            }
            public Map Map { get => map; }
            public bool MovePLayer(GADE_6112_Project2.Character.Movement direction) //Movement for player 
            {
                if (map.hero.ReturnMove() == direction)
                {
                    map.hero.Move(direction);
                    map.MapLayout[map.hero.Y, map.hero.X] = new Hero(map.hero.Y, map.hero.X, 99, 99, 2) { Type = Tile.Tiletype.Hero };
                    switch (direction)
                    {
                        case Character.Movement.Up:
                            Map.MapLayout[map.hero.Y + 1, map.hero.X] = new EmptyTile(map.hero.Y + 1, map.hero.X, 99, 99) { Type = Tile.Tiletype.Hero };
                            break;
                        case Character.Movement.Down:
                            Map.MapLayout[map.hero.Y - 1, map.hero.X] = new EmptyTile(map.hero.Y - 1, map.hero.X, 99, 99) { Type = Tile.Tiletype.Hero };
                            break;
                        case Character.Movement.Left:
                            Map.MapLayout[map.hero.Y, map.hero.X + 1] = new EmptyTile(map.hero.Y, map.hero.X + 1, 99, 99) { Type = Tile.Tiletype.Hero };
                            break;
                        case Character.Movement.Right:
                            Map.MapLayout[map.hero.Y, map.hero.X - 1] = new EmptyTile(map.hero.Y, map.hero.X - 1, 99, 99) { Type = Tile.Tiletype.Hero };
                            break;

                    }

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
                for (int i = 0; i < map.MapWidth_player; i++)
                {
                    for (int j = 0; j < map.MapHeight_player; j++)
                    {


                        switch (map.Map_player[i, j].Type)
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
                    }
                    stringBuilder.Append('\n');
                }

                return stringBuilder.ToString();
            }

            public bool MovePlayer(GADE_6112_Project2.Character.Movement move)
            {
                bool cMove = false;
                if (move != Character.Movement.noMovement)
                {
                    cMove = true;
                }
                return cMove;
            }

        
    }
}

