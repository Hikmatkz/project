namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bg1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.bg2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.lose = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelcoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // bg1
            // 
            this.bg1.Image = ((System.Drawing.Image)(resources.GetObject("bg1.Image")));
            this.bg1.Location = new System.Drawing.Point(0, 0);
            this.bg1.Name = "bg1";
            this.bg1.Size = new System.Drawing.Size(840, 650);
            this.bg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg1.TabIndex = 1;
            this.bg1.TabStop = false;
            this.bg1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(362, 310);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(128, 128);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            // 
            // bg2
            // 
            this.bg2.Image = ((System.Drawing.Image)(resources.GetObject("bg2.Image")));
            this.bg2.Location = new System.Drawing.Point(0, -651);
            this.bg2.Name = "bg2";
            this.bg2.Size = new System.Drawing.Size(840, 650);
            this.bg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg2.TabIndex = 3;
            this.bg2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(185, -130);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(128, 128);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 6;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(525, -400);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(128, 128);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 7;
            this.enemy2.TabStop = false;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.BackColor = System.Drawing.Color.IndianRed;
            this.lose.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lose.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lose.Location = new System.Drawing.Point(282, 82);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(287, 45);
            this.lose.TabIndex = 8;
            this.lose.Text = "Вы проиграли!";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(267, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Перезапустить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(435, -550);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 10;
            this.coin.TabStop = false;
            this.coin.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // labelcoins
            // 
            this.labelcoins.AutoSize = true;
            this.labelcoins.BackColor = System.Drawing.Color.IndianRed;
            this.labelcoins.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcoins.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelcoins.Location = new System.Drawing.Point(76, 9);
            this.labelcoins.Name = "labelcoins";
            this.labelcoins.Size = new System.Drawing.Size(128, 27);
            this.labelcoins.TabIndex = 11;
            this.labelcoins.Text = "Монеты : 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.labelcoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bg2);
            this.Controls.Add(this.bg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.bg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox bg1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox bg2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelcoins;
    }
}

