using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace BulletFest
    {
    public partial class Form1 : Form
        {
        WindowsMediaPlayer GameMedia;
        WindowsMediaPlayer ShootMedia;
        WindowsMediaPlayer CollisionMedia;

        PictureBox[] stars;
        PictureBox[]enemiesArray;
        PictureBox[] PlayerBullets;
        PictureBox[] EnemyBullets;
        Random Rnd;

        int backgroundSpeed;
        int PlayerSpeed;             
        int munitionSpeed;        
        int enemySpeed;
        int enemyBulletSpeed;
        int score;
        int level;
        bool pause;
        bool gameOver;
        int difficulty;
        int health;


        public Form1()
            {
            InitializeComponent();
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            stars = new PictureBox[15];
            PlayerBullets = new PictureBox[5];
            enemiesArray = new PictureBox[10];
            EnemyBullets = new PictureBox[10];

            Rnd = new Random();
            backgroundSpeed = 6;
            PlayerSpeed = 12;
            munitionSpeed= 20;
            enemySpeed = 4;
            enemyBulletSpeed = 15;
            score = 0;
            level = 1;
            pause = false;
            gameOver = false;
            difficulty = 9;
            health = 100;



            // setting background stuff 
            for (int i = 0; i < stars.Length; i++)
                {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(Rnd.Next(20, 1540), Rnd.Next(-10, 400));
                if (i % 2 == 0)
                    {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.Wheat;
                    }
                else
                    {
                    stars[i].Size = new Size(4, 4);
                    stars[i].BackColor = Color.DarkGray;
                    }
                this.Controls.Add(stars[i]);
                }

            // setting up music stuff 
            GameMedia = new WindowsMediaPlayer();
            GameMedia.URL = @"C:\Users\Administrator\Desktop\BulletFest\songs\GameSong.mp3";
            GameMedia.settings.setMode("loop", true);
            GameMedia.controls.play();
            GameMedia.settings.volume = 50;

            ShootMedia = new WindowsMediaPlayer();
            ShootMedia.URL = @"C:\Users\Administrator\Desktop\BulletFest\songs\shoot.mp3";
            CollisionMedia = new WindowsMediaPlayer();
            ShootMedia.settings.volume = 30;

            CollisionMedia.URL = @"C:\Users\Administrator\Desktop\BulletFest\songs\boom.mp3";
            CollisionMedia.settings.volume = 80;
            
            // setting up with enemies
            //loading enemy images
            Image enemy1 = Image.FromFile(@"C:\Users\Administrator\Desktop\BulletFest\assets\E1.png");
            Image enemy2 = Image.FromFile(@"C:\Users\Administrator\Desktop\BulletFest\assets\E2.png");
            Image enemy3 = Image.FromFile(@"C:\Users\Administrator\Desktop\BulletFest\assets\E3.png");
            Image Boss1 = Image.FromFile(@"C:\Users\Administrator\Desktop\BulletFest\assets\Boss1.png");
            Image Boss2 = Image.FromFile(@"C:\Users\Administrator\Desktop\BulletFest\assets\Boss2.png");
            // initializing enemy images
            for(int i=0; i< enemiesArray.Length; i++)
                {
                enemiesArray[i] = new PictureBox();
                enemiesArray[i].Size = new Size(40,40);
                enemiesArray[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemiesArray[i].BorderStyle = BorderStyle.None;
                enemiesArray[i].Visible = false;
                enemiesArray[i].Location = new Point((i+1)*140, (-50));
                this.Controls.Add(enemiesArray[i]);
                }

            enemiesArray[0].Image = Boss1;
            enemiesArray[1].Image = enemy2;
            enemiesArray[2].Image = enemy1;
            enemiesArray[3].Image = enemy3;
            enemiesArray[4].Image = enemy3;
            enemiesArray[5].Image = enemy1;
            enemiesArray[6].Image = enemy2;
            enemiesArray[7].Image = enemy3;
            enemiesArray[8].Image = enemy2;
            enemiesArray[9].Image = Boss2;

            // setting up Player bullets stuff
            Image munitionsImage = Image.FromFile(@"C:\Users\Administrator\Desktop\BulletFest\assets\munition.png");
            for (int i = 0; i < PlayerBullets.Length; i++)
                {
                PlayerBullets[i] = new PictureBox();
                PlayerBullets[i].Size = new Size(10, 10);
                PlayerBullets[i].Image = munitionsImage;
                PlayerBullets[i].SizeMode = PictureBoxSizeMode.Zoom;
                PlayerBullets[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(PlayerBullets[i]);
                }

            // setting up enemy bullets stuff
            for (int i = 0; i < EnemyBullets.Length; i++)
                {
                EnemyBullets[i] = new PictureBox();
                EnemyBullets[i].Size = new Size(2, 25);
                EnemyBullets[i].BackColor = Color.Red;
                EnemyBullets[i].Visible = false;
                int x = Rnd.Next(0, 10);
                EnemyBullets[i].Location = new Point(enemiesArray[x].Location.X, enemiesArray[x].Location.Y - 20);
                this.Controls.Add(EnemyBullets[i]);
                }
            }

        
        
         
        
               
        private void BgTimer_Tick(object sender, EventArgs e)
            {
            for(int i = 0; i < stars.Length / 2; i++)
                {
                stars[i].Top += backgroundSpeed;
                if (stars[i].Top >= this.Height)
                    {
                    stars[i].Top = -stars[i].Height;
                    }
                }
            for(int i = stars.Length / 2; i < stars.Length; i++)
                {
                stars[i].Top += backgroundSpeed-2;
                if (stars[i].Top >= this.Height)
                    {
                    stars[i].Top = -stars[i].Height;
                    }
                }
            }
        // move playerdown
        private void DownMoveTimer_Tick(object sender, EventArgs e)
            {
            if(Player.Top <= 795)
                {
                Player.Top += PlayerSpeed;
                }

            }
        // move playerup
        private void UpMoveTimer_Tick(object sender, EventArgs e)
            {
            if(Player.Top > 10)
                {
                Player.Top -= PlayerSpeed;
                }

            }
        // move playerRight
        private void RightMoveTimer_Tick(object sender, EventArgs e)
            {
            if(Player.Right <= 1480)
                {Z
                Player.Left += PlayerSpeed;
                }
            }
        // move playerLeft
        private void LeftMoveTimer_Tick(object sender, EventArgs e)
            {
            if (Player.Left > 10)
                {
                Player.Left -= PlayerSpeed;
                }
            }
        // key pressing functions
        private void Form1_KeyDown(object sender, KeyEventArgs e)
            {
            if (!pause)
                {
                if (e.KeyCode == Keys.Down)
                    {
                    DownMoveTimer.Start();
                    }
                if (e.KeyCode == Keys.Up)
                    {
                    UpMoveTimer.Start();
                    }
                if (e.KeyCode == Keys.Right)
                    {
                    RightMoveTimer.Start();
                    }
                if (e.KeyCode == Keys.Left)
                    {
                    LeftMoveTimer.Start();
                    }
                }
                
            }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
            {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            UpMoveTimer.Stop();
            DownMoveTimer.Stop();



            // pause the game when pressing Escape
            if(!gameOver)
                {
                if (e.KeyCode == Keys.Escape)
                    {
                    if (!pause)
                        {
                        StopAllTimers();
                        GameMedia.settings.volume = 0;
                        pause = true;
                        MessageBox.Show("Game Paused, press Esc again to Resume");
                        }
                    else
                        {
                        StartAllTimers();
                        GameMedia.settings.volume = 50;
                        pause = false;
                        }
                    }
                }
            
            }
        //enemy bullets controller
        private void MoveMunitionTimer_Tick(object sender, EventArgs e)
            {
            // playing the shoot sound
            ShootMedia.controls.play();
            ShootMedia.settings.volume=10;
            CollisionHandelling();

            for(int i = 0; i < PlayerBullets.Length; i++)
                {
                if (PlayerBullets[i].Top > 0)
                    {
                    PlayerBullets[i].Visible = true;
                    PlayerBullets[i].Top -= munitionSpeed;
                    }
                else
                    {
                    PlayerBullets[i].Visible = false;
                    PlayerBullets[i].Location = new Point(Player.Location.X + 20, Player.Location.Y-i*30);
                    }
                }
            }
        // enemy movement controller
        private void MoveEnemyTimer_Tick(object sender, EventArgs e)
            {
            MoveEnemies(enemiesArray, 10);
            }
        private void MoveEnemies(PictureBox[] array , int speed)
            {
                for (int i=0;  i<array.Length; i++)
                {
                array[i].Visible = true;
                array[i].Top += speed;
                if (array[i].Top>this.Height)
                    {
                    array[i].Location=new Point((i+1)*140, -200);
                    }
                }
            }

          
        private void StartAllTimers()
            {
            BgTimer.Start();
            MoveMunitionTimer.Start();
            MoveEnemyTimer.Start();
            MoveEnemyBulletsTimer.Start();
            }
        private void StopAllTimers()
            {
            BgTimer.Stop();
            MoveMunitionTimer.Stop();
            MoveEnemyTimer.Stop();
            MoveEnemyBulletsTimer.Stop();
            }
        private void GameOver()
            {
            StopAllTimers();
            GameMedia.controls.stop();
            MessageBox.Show("Game Over");
            Form back = new LandingPage();
            back.Show();
            this.Hide();
            }

        private void MoveEnemyBulletsTimer_Tick(object sender, EventArgs e)
            {
            EnemyBulletCollisionHandling();
            if (EnemyBullets[0].Top < this.Height)
                {
                for(int i = 0; i < (EnemyBullets.Length); i++)
                    {
                    EnemyBullets[i].Visible = true;
                    EnemyBullets[i].Top += enemyBulletSpeed;
                    }
                }
            else
                {
                for (int i = 0; i < (EnemyBullets.Length); i++)
                    {
                    EnemyBullets[i].Visible = false;
                    int x = Rnd.Next(0, 10);
                    EnemyBullets[i].Location = new Point(enemiesArray[x].Location.X+ 20, enemiesArray[x].Location.Y + 30);
                    }
                }   
            }


        // Handeling Collisions
        private void CollisionHandelling()
            {
            for (int i = 0; i < enemiesArray.Length; i++)
                {

                // enemy-bullet collision
                if ((PlayerBullets[0].Bounds.IntersectsWith(enemiesArray[i].Bounds))
                || (PlayerBullets[1].Bounds.IntersectsWith(enemiesArray[i].Bounds))
                || (PlayerBullets[2].Bounds.IntersectsWith(enemiesArray[i].Bounds)))
                    {
                    CollisionMedia.controls.play();
                    enemiesArray[i].Location = new Point((i + 1) * 140, (-100));
                    AddScore();
                    }
                // enemy-player collsion
                if (Player.Bounds.IntersectsWith(enemiesArray[i].Bounds)) 
                    {
                   
                        {
                        CollisionMedia.settings.volume = 100;
                        CollisionMedia.controls.play();
                        Player.Visible = false;
                        GameOver();
                        }
                    }
                }

            }
        // Handeling Enemy-Bullet and player Collisions
        private void EnemyBulletCollisionHandling()
            {
            for (int i = 0; i < EnemyBullets.Length; i++)
                {
                if (EnemyBullets[i].Bounds.IntersectsWith(Player.Bounds))
                    {
                    // Decrease player health
                    health--;
                    EnemyBullets[i].Visible = false;
                    // Play collision sound
                    CollisionMedia.settings.volume = 50; // Adjust volume as needed
                    CollisionMedia.controls.play();

                    // Check for game over
                    if (health <= 0) // Consider using <= to handle negative health values
                        {
                        Player.Visible = false;
                        GameOver();
                        // Optionally, break out of the loop if the game is over
                        break;
                        }
                    }
                }
            }

        // making a function to add score when a bullet hits an enemy
        private void AddScore()
            {
            score += 5;
            ScoreLabel.Text = (score<10) ? "0" + score.ToString(): score.ToString();
            // get to the next level when the score is a multiple of 30
            if (score % 40 == 0)
                {
                level++;
                LevelLabel.Text = (level < 10) ? "0" + level.ToString() : level.ToString();
                }
            healthlbl.Text = (health < 10) ? "0" + health.ToString() : health.ToString();
            // setting the difficulty of the game
            if (enemySpeed<10 && enemyBulletSpeed < 10 && difficulty>0)
                {
                difficulty--;
                enemySpeed+=6;
                enemyBulletSpeed+=7;
                }
            if (level>=10)
                {
                    StopAllTimers();
                    GameMedia.settings.volume = 0;
                    MessageBox.Show("Congratulations! You Won 😊");
                    Form back = new LandingPage();
                    back.Show();
                    this.Hide();
                }
            }


            }

        }
    