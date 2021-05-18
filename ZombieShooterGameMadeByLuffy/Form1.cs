using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieShooterGameMadeByLuffy
{
    public partial class Form1 : Form
    {
        bool GoLeft, GoRight, GoUp, GoDown, GameOver;
        int Speed = 12;
        string facing = "Up";
        int Ammo =10;
        int kills;
        int PlayerHealth = 100;
        Random RandNum = new Random();
        int ZombieSpeed = 3;
        List<PictureBox> ZombieList = new List<PictureBox>();


        private void keyisup(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Up)
            {
                GoUp = false;
                
            }
            if (e.KeyCode == Keys.Down)
            {
                GoDown = false;
               
            }
            if (e.KeyCode == Keys.Left)
            {
                GoLeft = false;
               
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
               
            }
            if (e.KeyCode == Keys.Space && Ammo > 0 &&GameOver==false)
            {
                Ammo--;
                ShootBullets(facing);
                if (Ammo < 1)
                {
                    DropAmmo();
                }
            }
            

        }

        private void GameMoveTimer(object sender, EventArgs e)
        {
            if (PlayerHealth > 1)
            {
                HealthBar.Value = PlayerHealth;
            }
            else
            {
                GameOver = true;
                PlayerPb.Image = Properties.Resources.SDeaD;
                MoverTimer.Stop();
            }
            LblAmmo.Text = "Ammo  " + Ammo;
            LblKills.Text = "Kills  " + kills;
            if (PlayerHealth < 20)
            {
                HealthBar.ForeColor = System.Drawing.Color.Red;
            }
            if (GoLeft == true && PlayerPb.Left > 0)
            {
                PlayerPb.Left -= Speed;
            }
            if (GoRight == true && PlayerPb.Left + PlayerPb.Width < this.ClientSize.Width)
            {
                PlayerPb.Left += Speed;
            }
            if (GoUp == true && PlayerPb.Top > 37)
            {
                PlayerPb.Top -= Speed;
            }
            if (GoDown == true && PlayerPb.Top + PlayerPb.Height < this.ClientSize.Height)
            {
                PlayerPb.Top += Speed;
            }
            foreach (Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (PlayerPb.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        Ammo += 5;
                        
                    }
                }

                if(x is PictureBox && (string)x.Tag == "Zombie")
                {
                    if (PlayerPb.Bounds.IntersectsWith(x.Bounds))
                    {
                        PlayerHealth-=1;
                    }
                    if (x.Left > PlayerPb.Left)
                    {
                        x.Left -= ZombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ZLeft;
                    }
                    if (x.Left < PlayerPb.Left)
                    {
                        x.Left += ZombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ZRight;
                    }
                    if (x.Top < PlayerPb.Top)
                    {
                        x.Top += ZombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ZDown;
                    }
                    if (x.Top > PlayerPb.Top)
                    {
                        x.Top -= ZombieSpeed;
                        ((PictureBox)x).Image = Properties.Resources.ZUP;
                    }
                   

                }
                foreach (Control j in this.Controls)
                {
                    if(j is PictureBox && (string)j.Tag== "Bullet" && x is PictureBox && (string)x.Tag=="Zombie")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            kills++;
                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            ZombieList.Remove((PictureBox)x);
                            MakeZombies();
                        }

                    }
                }
                
            }
        }
        

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (GameOver == true)
            {
                return;
            }
            if (e.KeyCode == Keys.Up)
            {
                facing = "Up";
                GoUp = true;
                PlayerPb.Image = Properties.Resources.SUP;
            }
            if (e.KeyCode == Keys.Down)
            {
                facing = "Down";
                GoDown = true;
                PlayerPb.Image = Properties.Resources.SDown;
            }
            if (e.KeyCode == Keys.Left)
            {
                facing = "Left";
                GoLeft = true;
                PlayerPb.Image = Properties.Resources.SLeft;
            }
            if (e.KeyCode == Keys.Right)
            {
                facing = "Right";
                GoRight = true;
                PlayerPb.Image = Properties.Resources.SRight;
            }
            
        }

      

        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }
        private void ShootBullets(string direction)
        {
            Bullets ShootBullet = new Bullets();
            ShootBullet.direction = direction;
            if (facing == "Down")
            {
                ShootBullet.bulletTop = PlayerPb.Top + (PlayerPb.Height / 2);
                ShootBullet.bulletLeft = PlayerPb.Left + (PlayerPb.Width / 4);
            }
            if (facing == "Up")
            {
                ShootBullet.bulletTop = PlayerPb.Top + (PlayerPb.Height / 2);
                ShootBullet.bulletLeft = PlayerPb.Left + (PlayerPb.Width / 2);
            }
            if (facing == "Left"||facing=="Right")
            {
                ShootBullet.bulletLeft = PlayerPb.Left + (PlayerPb.Width / 2);
                ShootBullet.bulletTop = PlayerPb.Top + (PlayerPb.Height / 2);
            }
            
            ShootBullet.MakeBullet(this);
           
           
        }
        private void RestartGame()
        {
            PlayerPb.Image = Properties.Resources.SUP;
            foreach (PictureBox i in ZombieList)
            {
                this.Controls.Remove(i);
            }
            ZombieList.Clear();
            for(int i = 0; i < 3; i++)
            {
                MakeZombies();
            }
            GoUp = false;
            GoLeft = false;
            GoRight = false;
            GoDown = false;
            PlayerHealth = 100;
            kills = 0;
            Ammo = 10;
            MoverTimer.Start();
        }
        private void MakeZombies()
        {
            PictureBox Zombie = new PictureBox();
            Zombie.Tag = "Zombie";
            Zombie.Image = Properties.Resources.ZDown;
            Zombie.BackColor = Color.Transparent;
            Zombie.Left = RandNum.Next(0, 900);
            Zombie.Top = RandNum.Next(0, 800);
            Zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            ZombieList.Add(Zombie);
            this.Controls.Add(Zombie);
            PlayerPb.BringToFront();
        }
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = RandNum.Next(10, this.ClientSize.Width-ammo.Width);
            ammo.Top = RandNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront();
            PlayerPb.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
