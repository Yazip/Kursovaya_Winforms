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
    public partial class GameForm : Form
    {
        public GameForm(string dif_level)
        {
            InitializeComponent();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // Обратный отсчёт
            if (CountdownLabel.Visible)
            {
                if (CountdownLabel.Text == "1")
                {
                    CountdownLabel.Visible = false;
                    StartLabel.Visible = true;
                }
                else
                {
                    int countdown_value = int.Parse(CountdownLabel.Text);
                    --countdown_value;
                    CountdownLabel.Text = countdown_value.ToString();
                }
            }
            // Игровой процесс
            else
            {
                StartLabel.Visible = false;
                GameTimer.Stop();
            }
        }
    }
}
