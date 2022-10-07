using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project2
{
    internal class Map
    {
        public Tile[,] MapLayout;
        public Hero hero;   //A Hero object to represent the player character
        public Enemy[] enemies;    //An Enemy array for the enemies
        public int mapHeight, mapWidth;   //Variables for storing the map’s width and height
        public Random rnd = new Random();   // A Random object for randomising numbers.

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyCount)
        {
            hero = new Hero(5, 5, 100, 100, 1);
            mapWidth = rnd.Next(minWidth, maxWidth);
            mapHeight = rnd.Next(minHeight, maxHeight);
            MapLayout = new Tile[mapWidth, mapHeight];

            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if (i == 0 || i == mapWidth - 1)
                    {
                        MapLayout[i, j] = new Obstacle(i, j);
                        MapLayout[i, j].Type = Tile.Tiletype.Obstacle;
                    }
                    else if (j == 0 || j == mapHeight - 1)
                    {
                        MapLayout[i, j] = new Obstacle(i, j);
                        MapLayout[i, j].Type = Tile.Tiletype.Obstacle;
                    }
                    else
                    {
                        MapLayout[i, j] = new EmptyTile(i, j);
                        MapLayout[i, j].Type = Tile.Tiletype.EmptyTile;
                    }
                }
                hero = (Hero)Create(Tile.Tiletype.Hero);
                hero.Type = Tile.Tiletype.Hero;
                enemies = new Enemy[enemyCount];
                
                

                for (int j = 0; j < enemyCount; j++)
                {
                    Create(Tile.Tiletype.Enemy);
                }
            }
        }
        public Tile[,] Map_player { get => MapLayout; }
        public Hero Hero_player { get => hero; }
        public Enemy[] Enemies_player { get => enemies; }
        public int MapWidth_player { get => mapWidth; }
        public int MapHeight_player { get => mapHeight; }

        // Updates the vision for each player
        public void UpdateVision()
        {
            //Hero 
            Tile.Tiletype[] vision = new Tile.Tiletype[4];
            vision[0] = MapLayout[hero.X, hero.Y + 1].Type; //up
            vision[1] = MapLayout[hero.X, hero.Y - 1].Type; //down
            vision[2] = MapLayout[hero.X - 1, hero.Y].Type; //left
            vision[3] = MapLayout[hero.X + 1, hero.Y].Type; //right
            hero.VisionTiles = vision;

            //Enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                Tile.Tiletype[] enemyVision = new Tile.Tiletype[4];
                enemyVision[0] = MapLayout[enemies[i].X, enemies[i].Y + 1].Type; //up
                enemyVision[1] = MapLayout[enemies[i].X, enemies[i].Y - 1].Type; //down
                enemyVision[2] = MapLayout[enemies[i].X - 1, enemies[i].Y].Type; //left
                enemyVision[3] = MapLayout[enemies[i].X + 1, enemies[i].Y].Type; //right
                enemies[i].VisionTiles = enemyVision;

            }
        }

        private void Create(Tile.Tiletype type)
        {
            bool loop;
            int rndmX, rndmY;
            do
            {
                rndmX = rnd.Next(mapWidth);
                rndmY = rnd.Next(mapHeight);

                loop = (MapLayout[rndmX, rndmY] is null || MapLayout[rndmX, rndmY] == null);
            } while (loop);
            switch (type)
            {
                case Tile.Tiletype.Hero:
                    hero.X = rndmX;
                    hero.Y = rndmY;
                    MapLayout[rndmX, rndmY] = hero;
                    MapLayout[rndmX, rndmY].Type = type;
                    break;
                case Tile.Tiletype.Enemy:
                    MapLayout[rndmX, rndmY] = new Swamp_Creature(rndmX, rndmY, 10, 10, 1) { Type = type };
                    break;
                default:
                    break;
            }
        }
    }
}

