namespace BeatTheMole
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.DifLevel_comboBox = new System.Windows.Forms.ComboBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Выберите уровень сложности";
            // 
            // DifLevel_comboBox
            // 
            this.DifLevel_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DifLevel_comboBox.FormattingEnabled = true;
            this.DifLevel_comboBox.Items.AddRange(new object[] {
            "Лёгкий",
            "Средний",
            "Сложный"});
            this.DifLevel_comboBox.Location = new System.Drawing.Point(126, 88);
            this.DifLevel_comboBox.Name = "DifLevel_comboBox";
            this.DifLevel_comboBox.Size = new System.Drawing.Size(121, 21);
            this.DifLevel_comboBox.TabIndex = 0;
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(148, 143);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(75, 23);
            this.OK_button.TabIndex = 2;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.DifLevel_comboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DifLevel_comboBox;
        private System.Windows.Forms.Button OK_button;
    }
}