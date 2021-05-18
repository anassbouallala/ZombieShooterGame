using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieShooterGameMadeByLuffy
{
    class Bullets
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;

        private int Speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "Bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();
            

            form.Controls.Add(bullet);
            bulletTimer.Interval = Speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();

        }
        private void BulletTimerEvent(object sender,EventArgs e)
        {
            if (direction == "Left")
            {
                bullet.Left -= Speed;
            }
            if (direction == "Right")
            {
                bullet.Left += Speed;
            }
            if (direction == "Up")
            {
                bullet.Top -= Speed;
            }
            if (direction == "Down")
            {
                bullet.Top += Speed;
            }
            if (bullet.Left < 10 || bullet.Left > 860 || bullet.Top < 10 || bullet.Top > 600)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bullet = null;
                bulletTimer = null;

            }
        }

    }
}
