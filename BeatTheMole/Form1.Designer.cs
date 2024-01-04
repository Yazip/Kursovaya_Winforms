namespace BeatTheMole
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.SkyPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DifLevelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SkyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // SkyPictureBox
            // 
            this.SkyPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SkyPictureBox.Location = new System.Drawing.Point(0, 0);
            this.SkyPictureBox.Name = "SkyPictureBox";
            this.SkyPictureBox.Size = new System.Drawing.Size(801, 164);
            this.SkyPictureBox.TabIndex = 0;
            this.SkyPictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 72);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(568, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 72);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(306, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(189, 72);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(287, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Игра \"Бей крота\"";
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.PaleGreen;
            this.PlayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PlayButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.PlayButton.Location = new System.Drawing.Point(327, 196);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(159, 39);
            this.PlayButton.TabIndex = 5;
            this.PlayButton.Text = "Играть";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.SettingsButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.SettingsButton.Location = new System.Drawing.Point(327, 258);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(159, 39);
            this.SettingsButton.TabIndex = 6;
            this.SettingsButton.Text = "Настройки";
            this.SettingsButton.UseVisualStyleBackColor = false;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.PaleGreen;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ExitButton.ForeColor = System.Drawing.Color.DarkGreen;
            this.ExitButton.Location = new System.Drawing.Point(327, 319);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 39);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // DifLevelLabel
            // 
            this.DifLevelLabel.AutoSize = true;
            this.DifLevelLabel.Location = new System.Drawing.Point(89, 283);
            this.DifLevelLabel.Name = "DifLevelLabel";
            this.DifLevelLabel.Size = new System.Drawing.Size(44, 13);
            this.DifLevelLabel.TabIndex = 8;
            this.DifLevelLabel.Text = "Лёгкий";
            this.DifLevelLabel.Visible = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(214)))), ((int)(((byte)(111)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DifLevelLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SkyPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.SkyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SkyPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label DifLevelLabel;
    }
}

