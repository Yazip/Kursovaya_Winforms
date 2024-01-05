using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settings_form = new SettingsForm();
            Visible = false;
            if (settings_form.ShowDialog() == DialogResult.Cancel)
            {
                DifLevelLabel.Text = settings_form.DifficultyLevel;
                Visible = true;
            }
        }

        public string DifLevel
        {
            get { return DifLevelLabel.Text; }
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            GameForm game_form = new GameForm(DifLevel);
            Visible = false;
            if (game_form.ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }
    }
}
