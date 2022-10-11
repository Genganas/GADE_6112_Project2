using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_6112_Project1
{
    public partial class Form1 : Form
    {
        GameEngine gameEngine = new GameEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            redMap.Text = gameEngine.ToString();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
           
            if (gameEngine.map.Enemies[cmbEnemyatk.SelectedIndex].isDead())

            {
                gameEngine.Map.GameMap[
                    gameEngine.map.Enemies[ cmbEnemyatk.SelectedIndex].Y,
                    gameEngine.map.Enemies[cmbEnemyatk.SelectedIndex].X
                ] = new EmptyTile(
                        gameEngine.Map.Enemies[cmbEnemyatk.SelectedIndex].X,
                        gameEngine.Map.Enemies[cmbEnemyatk.SelectedIndex].Y )
                { Type = Tile.Tiletype.EmptyTile };

                redMap.Text = gameEngine.map.ToString();
                return;
            }
            if (gameEngine.map.Enemies[cmbEnemyatk.SelectedIndex].CheckRange(gameEngine.Map.HeroPlayer))
            {
                gameEngine.Map.hero.Attack(gameEngine.Map.Enemies[cmbEnemyatk.SelectedIndex]);
                outputInfoTextBox.Text = gameEngine.Map.Enemies[cmbEnemyatk.SelectedIndex].ToString();
            }
            else
            {
                outputInfoTextBox.Text = "Attack Unsuccessful";
            }
            redMap.Text = gameEngine.map.ToString();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(GADE_6112_Project1.Character.Movement.Left);
            redMap.Text = gameEngine.ToString();
            outputInfoTextBox.Text = gameEngine.Map.HeroPlayer.ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(GADE_6112_Project1.Character.Movement.Up);
            redMap.Text = gameEngine.ToString();
            outputInfoTextBox.Text = gameEngine.Map.HeroPlayer.ToString();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(GADE_6112_Project1.Character.Movement.Right);
            redMap.Text = gameEngine.ToString();
            outputInfoTextBox.Text = gameEngine.Map.HeroPlayer.ToString();

        }

        private void btnDown_Click(object sender, EventArgs e)
        {
           
            gameEngine.MovePlayer(GADE_6112_Project1.Character.Movement.Down);
            redMap.Text = gameEngine.ToString();
            outputInfoTextBox.Text = gameEngine.Map.HeroPlayer.ToString();

        }
    }
}
