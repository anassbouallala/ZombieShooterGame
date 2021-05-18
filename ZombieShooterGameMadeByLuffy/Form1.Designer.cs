
namespace ZombieShooterGameMadeByLuffy
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MoverTimer = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.LblKills = new System.Windows.Forms.Label();
            this.LblAmmo = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPb)).BeginInit();
            this.SuspendLayout();
            // 
            // MoverTimer
            // 
            this.MoverTimer.Enabled = true;
            this.MoverTimer.Interval = 20;
            this.MoverTimer.Tick += new System.EventHandler(this.GameMoveTimer);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(422, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Health  ";
            // 
            // LblKills
            // 
            this.LblKills.AutoSize = true;
            this.LblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblKills.ForeColor = System.Drawing.Color.White;
            this.LblKills.Location = new System.Drawing.Point(225, 9);
            this.LblKills.Name = "LblKills";
            this.LblKills.Size = new System.Drawing.Size(77, 24);
            this.LblKills.TabIndex = 11;
            this.LblKills.Text = "Kills : 0";
            // 
            // LblAmmo
            // 
            this.LblAmmo.AutoSize = true;
            this.LblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.LblAmmo.ForeColor = System.Drawing.Color.White;
            this.LblAmmo.Location = new System.Drawing.Point(42, 9);
            this.LblAmmo.Name = "LblAmmo";
            this.LblAmmo.Size = new System.Drawing.Size(99, 24);
            this.LblAmmo.TabIndex = 10;
            this.LblAmmo.Text = "Ammo : 0";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(510, 9);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(402, 23);
            this.HealthBar.TabIndex = 13;
            this.HealthBar.Value = 100;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::ZombieShooterGameMadeByLuffy.Properties.Resources.healthcare;
            this.pictureBox3.Location = new System.Drawing.Point(376, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ZombieShooterGameMadeByLuffy.Properties.Resources.skull;
            this.pictureBox2.Location = new System.Drawing.Point(179, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ZombieShooterGameMadeByLuffy.Properties.Resources.Ammo1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerPb
            // 
            this.PlayerPb.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPb.Image = global::ZombieShooterGameMadeByLuffy.Properties.Resources.SUP;
            this.PlayerPb.Location = new System.Drawing.Point(655, 260);
            this.PlayerPb.Name = "PlayerPb";
            this.PlayerPb.Size = new System.Drawing.Size(62, 94);
            this.PlayerPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PlayerPb.TabIndex = 9;
            this.PlayerPb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(924, 661);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.PlayerPb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblKills);
            this.Controls.Add(this.LblAmmo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameArea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer MoverTimer;
        private System.Windows.Forms.PictureBox PlayerPb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblKills;
        private System.Windows.Forms.Label LblAmmo;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

