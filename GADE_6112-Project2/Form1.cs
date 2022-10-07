using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE_6112_Project2
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
      

            private void Form1_Activated(object sender, EventArgs e)
            {
                var gameENGINE = new Game_Engine();
                redMap.Text = gameENGINE.ToString();

            }

            private void btnAttack_Click(object sender, EventArgs e)
            {
                var gameEngine = new Game_Engine();
                if (gameEngine.map.Enemies_player[cmbEnemyatk.SelectedIndex].IsDead())

                {
                    gameEngine.Map.MapLayout[
                        gameEngine.map.MapLayout[cmbEnemyatk.SelectedIndex].Y,
                        gameEngine.map.MapLayout[cmbEnemyatk.SelectedIndex].X
                    ]
                          = new EmptyTile(
                            gameEngine.Map.Enemies_player[cmbEnemyatk.SelectedIndex].X,
                            gameEngine.Map.Enemies_player[cmbEnemyatk.SelectedIndex].Y
                            )
                          { Type = Tile.Tiletype.EmptyTile };
                    redMap.Text = gameEngine.map.ToString();
                    return;
                }
                gameEngine.Map.hero.Attack(gameEngine.Map.UpdateVision);
                redMap.Text = gameEngine.map.ToString();
            }



            private void btnLeft_Click(object sender, EventArgs e)
            {
                var gameEngine = new Game_Engine();
                gameEngine.MovePlayer(GADE_6112_Project2.Character.Movement.Left);
                redMap.Text = gameEngine.map.hero.ToString();
                gameEngine.map.UpdateVision();
            }

            private void btnUp_Click(object sender, EventArgs e)
            {
                var gameEngine = new Game_Engine();
                gameEngine.MovePlayer(GADE_6112_Project2.Character.Movement.Up);
                redMap.Text = gameEngine.map.hero.ToString();
                gameEngine.map.UpdateVision();
            }

            private void btnRight_Click(object sender, EventArgs e)
            {
                var gameEngine = new Game_Engine();
                gameEngine.MovePlayer(GADE_6112_Project2.Character.Movement.Right);
                redMap.Text = gameEngine.map.hero.ToString();
                gameEngine.map.UpdateVision();
            }

            private void btnDown_Click(object sender, EventArgs e)
            {
                var gameEngine = new Game_Engine();
                gameEngine.MovePlayer(GADE_6112_Project2.Character.Movement.Down);
                redMap.Text = gameEngine.map.hero.ToString();
                gameEngine.map.UpdateVision();
            }
        }

}
