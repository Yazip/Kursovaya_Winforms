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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            DifLevel_comboBox.SelectedItem = "Лёгкий";
        }
        public string DifficultyLevel
        {
            get { return (DifLevel_comboBox.SelectedItem).ToString(); }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
