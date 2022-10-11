using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE_6112_Project1
{
    internal class Map
    {
        public Tile[,] map;
        public Hero hero;   //A Hero object to represent the player character
        public Enemy[] enemies;    //An Enemy array for the enemies
        public int mapHeight, mapWidth;   //Variables for storing the map’s width and height
        public Random rnd = new Random();   // A Random object for randomising numbers.

        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyCount)
        {
            hero = new Hero(5, 5, 100, 100);
            mapWidth = rnd.Next(minWidth, maxWidth);
            mapHeight = rnd.Next(minHeight, maxHeight);
            map = new Tile[mapWidth, mapHeight];

            for (int i = 0; i < mapWidth; i++)
            {
                for (int j = 0; j < mapHeight; j++)
                {
                    if (i == 0 || i == mapWidth - 1)
                    {
                        map[i, j] = new Obstacle(i, j) { Type = Tile.Tiletype.Obstacle };
                    }
                    else if (j == 0 || j == mapHeight - 1)
                    {
                        map[i, j] = new Obstacle(i, j) { Type = Tile.Tiletype.Obstacle };
                    }
                    else
                    {
                        map[i, j] = new EmptyTile(i, j) { Type = Tile.Tiletype.EmptyTile };
                    }
                }
            }
            hero = (Hero)Create(Tile.Tiletype.Hero);
            enemies = new Enemy[enemyCount];
                
            for (int j = 0; j < enemyCount; j++)
            {
                enemies[j] = (Swamp_Creature)Create(Tile.Tiletype.Enemy);
            }
        }
        public Tile[,] GameMap { get => map; }
        public Hero HeroPlayer { get => hero; }
        public Enemy[] Enemies { get => enemies; }
        public int MapWidth { get => mapWidth; }
        public int MapHeight { get => mapHeight; }

        // Updates the vision for each player
        public void UpdateVision()
        {
            //Hero 
            Tile[] vision = new Tile[4];
            vision[0] = map[hero.X, hero.Y + 1]; //up
            vision[1] = map[hero.X, hero.Y - 1]; //down
            vision[2] = map[hero.X - 1, hero.Y]; //left
            vision[3] = map[hero.X + 1, hero.Y]; //right
            hero.VisionTiles = vision;

            //Enemies
            for (int i = 0; i < enemies.Length; i++)
            {
                Tile[] enemyVision = new Tile[4];
                enemyVision[0] = map[enemies[i].X, enemies[i].Y + 1]; //up
                enemyVision[1] = map[enemies[i].X, enemies[i].Y - 1]; //down
                enemyVision[2] = map[enemies[i].X - 1, enemies[i].Y]; //left
                enemyVision[3] = map[enemies[i].X + 1, enemies[i].Y]; //right
                enemies[i].VisionTiles = enemyVision;

            }
        }

        private Tile Create(Tile.Tiletype type)
        {
            bool loop;
            int rndmX, rndmY;
            do
            {
                rndmX = rnd.Next(1, mapWidth - 1);
                rndmY = rnd.Next(1, mapHeight - 1);

                loop = (map[rndmX, rndmY] is null || map[rndmX, rndmY] == null);
            } while (loop);
            switch (type)
            {
                case Tile.Tiletype.Hero:
                    Hero playerhero = new Hero(rndmX, rndmY,10,10) { Type = type };
                    map[rndmX, rndmY] = playerhero;
                    return playerhero;
                case Tile.Tiletype.Enemy:
                    Swamp_Creature swamp_Creature = new Swamp_Creature(rndmX, rndmY) { Type = type };
                    map[rndmX, rndmY] = swamp_Creature;
                    return swamp_Creature;
                default:
                    return new EmptyTile (rndmX,rndmY);
                    
                    
            }
        }
    }
}
