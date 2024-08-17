using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace HelicopterGame
{
    public partial class Helicoppy : Form
    {
        int hurdleSpeed = 2;
        int gravity = 1;
        int score = 0;
        bool spaceKeyPressed = false;
        bool gamest = false;
        bool gameend = false;
        int totalDistance = 0;
        int blockWidth = 40;
        private Image blockImage;

        private List<SmokeParticle> smokeParticles = new List<SmokeParticle>();
        private List<WallBlock> wallBlocksTop = new List<WallBlock>();
        private List<WallBlock> wallBlocksBottom = new List<WallBlock>();

        private SoundPlayer player;

        public Helicoppy()
        {
            InitializeComponent();
            
            this.DoubleBuffered = true;
            this.MouseClick += gameStart;
            this.Paint += Form1_Paint;

            hurdleBottom.Visible = false;
            hurdleMiddle.Visible = false;
            helicopter.Visible = false;
            hurdleTop.Visible = false;
            scoreText.Visible = false;
            HighScore.Visible = false;
            distanceText.Visible = false;

            GameOver.Visible = false;
            pictureBox4.Visible = false;
            smoke.Visible = false;
            player = new SoundPlayer(Properties.Resources.soundtrack);
            player.PlayLooping();

            blockImage = Properties.Resources.block;

            GenerateWallBlocks();
        }


        private void GenerateWallBlocks()
        {
            wallBlocksTop.Clear();
            wallBlocksBottom.Clear();
            int screenHeight = this.ClientSize.Height;
            int screenWidth = this.ClientSize.Width;
            Random rand = new Random();

            int x = 0;
            while (x < screenWidth + 1000)
            {
                int heightTop = rand.Next(20, 70);
                int heightBottom = rand.Next(20, 70);

                wallBlocksTop.Add(new WallBlock(x, 0, blockWidth, heightTop, blockImage));
                wallBlocksBottom.Add(new WallBlock(x, screenHeight - heightBottom, blockWidth, heightBottom, blockImage));

                x += blockWidth;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            helicopter.Top += gravity;
            hurdleBottom.Left -= hurdleSpeed;
            hurdleTop.Left -= hurdleSpeed;
            hurdleMiddle.Left -= hurdleSpeed;

            scoreText.Text = "Score: " + score.ToString();

            totalDistance += gameTimer.Interval/10;
            distanceText.Text = "Distance: " + totalDistance.ToString();

            foreach (var block in wallBlocksTop)
            {
                block.Move(hurdleSpeed);
            }

            foreach (var block in wallBlocksBottom)
            {
                block.Move(hurdleSpeed);
            }

            if (wallBlocksTop.Any() && wallBlocksTop.First().X < -blockWidth)
            {
                wallBlocksTop.RemoveAll(b => b.X < -blockWidth);
                wallBlocksBottom.RemoveAll(b => b.X < -blockWidth);

                int screenHeight = this.ClientSize.Height;
                Random rand = new Random();
                int x = wallBlocksTop.Max(b => b.X) + blockWidth;

                int heightTop = rand.Next(20, 70);
                int heightBottom = rand.Next(20, 70);

                wallBlocksTop.Add(new WallBlock(x, 0, blockWidth, heightTop, blockImage));
                wallBlocksBottom.Add(new WallBlock(x, screenHeight - heightBottom, blockWidth, heightBottom, blockImage));
            }

            if (spaceKeyPressed)
            {
                gravity = -3;
            }
            else
            {
                gravity = 3;
            }

            if (hurdleBottom.Left < -50)
            {
                hurdleBottom.Left = 800;
                score++;
                var sc = new SoundPlayer(Properties.Resources.pickupCoin);
                sc.Play();
            }

            if(hurdleTop.Left < -50)
            {
                hurdleTop.Left = 900;
                score++;
                var sc = new SoundPlayer(Properties.Resources.pickupCoin);
                sc.Play();
            }

            if (hurdleMiddle.Left < -50)
            {
                hurdleMiddle.Left = 950;
                score++;
                var sc = new SoundPlayer(Properties.Resources.pickupCoin);
                sc.Play();
            }


            if (helicopter.Bounds.IntersectsWith(hurdleBottom.Bounds) ||
               helicopter.Bounds.IntersectsWith(hurdleTop.Bounds) ||
               helicopter.Bounds.IntersectsWith(hurdleMiddle.Bounds) || wallBlocksTop.Any(block => block.Bounds.IntersectsWith(helicopter.Bounds)) ||
           wallBlocksBottom.Any(block => block.Bounds.IntersectsWith(helicopter.Bounds)))
            {
                endGame();
            }

            // Add new smoke particle at helicopter's position
            smokeParticles.Add(new SmokeParticle(helicopter.Left + helicopter.Width / 2, helicopter.Top + helicopter.Height / 2));

            foreach (var particle in smokeParticles)
            {
                particle.X += particle.VelocityX;
                particle.Y += particle.VelocityY;
                particle.Opacity -= 0.01f; // Decrease opacity over time
                particle.Lifetime--; // Decrease lifetime
            }

            // Remove expired particles
            smokeParticles.RemoveAll(p => p.Lifetime <= 0 || p.Opacity <= 0);

            // Repaint the form
            Invalidate();
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (!gameend && gamest)
            {
                if (e.KeyCode == Keys.Space)
                {
                    spaceKeyPressed = true; // Set the flag to true when spacebar is pressed
                    //var sc = new SoundPlayer(Properties.Resources.jump);
                    //sc.Play();
                }
            }
            else
            {
                if (e.KeyCode == Keys.Space)
                {
                    
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                // Reset game state
                score = 0;
                totalDistance = 0;
                gravity = 1;
                gamest = true;
                gameend = false;
                GameOver.Visible = false;
                pictureBox4.Visible = false;
                smoke.Visible = false;

                // Reset helicopter position
                helicopter.Top = this.ClientSize.Height / 2;
                helicopter.Left = this.ClientSize.Width / 8;
                helicopter.Visible = false;

                // Reset hurdles position
                hurdleBottom.Left = this.ClientSize.Width/2;
                hurdleTop.Left = this.ClientSize.Width/2 + 100;
                hurdleMiddle.Left = this.ClientSize.Width/2 + 200;

                GenerateWallBlocks();
                gameTimer.Start();

                hurdleBottom.Visible = true;
                hurdleMiddle.Visible = true;
                helicopter.Visible = true;
                hurdleTop.Visible = true;
                scoreText.Visible = true;
                HighScore.Visible = true;
                distanceText.Visible = true;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                player.Stop();

                int highScore = GetHighScore();
                HighScore.Text = "High Score: " + highScore.ToString();
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                spaceKeyPressed = false; // Set the flag to false when spacebar is released
                var sc = new SoundPlayer(Properties.Resources.jump);
                sc.Play();
            }
        }

        private void gamemouseisup(object sender, MouseEventArgs e)
        {
            gravity = 3;
        }

        private void gamemouseisdown(object sender, MouseEventArgs e)
        {
            if (!gameend && gamest)
            {
                gravity = -5;
                var sc = new SoundPlayer(Properties.Resources.jump);
                sc.Play();
            }
            else
            {

            }  
        }

        private void hurdleTop_Click(object sender, EventArgs e)
        {

        }

        private void endGame()
        {
            gameend = true;
            gameTimer.Stop();
            helicopter.Visible = false;
            
            
            hurdleBottom.BringToFront();
            hurdleMiddle.BringToFront();
            hurdleTop.BringToFront();
            scoreText.BringToFront();
            HighScore.BringToFront();
            distanceText.BringToFront();    
            GameOver.BringToFront();

            smoke.Location = new Point(helicopter.Left, helicopter.Top);
            smoke.Visible = true;
            var exp = new SoundPlayer(Properties.Resources.explosion);
            exp.Play();

            SaveScore(score);
            timer1.Start();
        }

        private void SaveScore(int score)
        {
            string filePath = "scores.txt";
            File.AppendAllText(filePath, score + Environment.NewLine);
        }

        private void gameStart(object sender, MouseEventArgs e)
        {
            if (!gameend && e.Button==MouseButtons.Right)
            {
                GenerateWallBlocks();
                gameTimer.Start();
                gamest = true;

                hurdleBottom.Visible = true;
                hurdleMiddle.Visible = true;
                helicopter.Visible = true;
                hurdleTop.Visible = true;
                scoreText.Visible = true;
                HighScore.Visible = true;
                distanceText.Visible = true;

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                player.Stop();

                int highScore = GetHighScore();
                HighScore.Text = "High Score: " + highScore.ToString();
            }
        }

        private int GetHighScore()
        {
            string filePath = "scores.txt";
            if (File.Exists(filePath))
            {
                string[] scores = File.ReadAllLines(filePath);
                int[] intScores = Array.ConvertAll(scores, int.Parse);
                if (intScores.Length > 0)
                {
                    return intScores.Max();
                }
            }
            return 0;
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var block in wallBlocksTop)
            {
                block.Draw(e.Graphics);
            }

            foreach (var block in wallBlocksBottom)
            {
                block.Draw(e.Graphics);
            }
            // Draw smoke particles
            foreach (var particle in smokeParticles)
            {
                // Draw a simple ellipse for each particle
                using (var brush = new SolidBrush(Color.FromArgb((int)(particle.Opacity * 255), Color.Gainsboro)))
                {
                    e.Graphics.FillEllipse(brush, particle.X, particle.Y, 5, 5);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameOver.Visible = true;
            pictureBox4.Visible = true;
            var fail = new SoundPlayer(Properties.Resources.failure);
            fail.Play();
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            
        }

        private void smoke_Click(object sender, EventArgs e)
        {

        }
    }
}
