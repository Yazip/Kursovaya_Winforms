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
        private Random random = new Random();
        private PictureBox[][] moles_sprites;
        private Mole[] moles = new Mole[9];
        private PictureBox[][] bombs_sprites;
        private Bomb[] bombs = new Bomb[9];
        private int delay_time;
        private int game_interval;

        public GameForm(string dif_level)
        {
            InitializeComponent();
            switch (dif_level)
            {
                case "Лёгкий":
                    delay_time = 5000;
                    break;
                case "Средний":
                    delay_time = 3000;
                    break;
                case "Сложный":
                    delay_time = 2000;
                    break;
            }
            game_interval = delay_time + 500;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            moles_sprites = new PictureBox[][] {
                new PictureBox[] { pictureBox4, pictureBox13, pictureBox22, pictureBox31 },
                new PictureBox[] { pictureBox5, pictureBox14, pictureBox23, pictureBox32 },
                new PictureBox[] { pictureBox6, pictureBox15, pictureBox24, pictureBox33 },
                new PictureBox[] { pictureBox9, pictureBox16, pictureBox25, pictureBox34 },
                new PictureBox[] { pictureBox8, pictureBox17, pictureBox26, pictureBox35 },
                new PictureBox[] { pictureBox7, pictureBox18, pictureBox27, pictureBox36 },
                new PictureBox[] { pictureBox12, pictureBox19, pictureBox28, pictureBox37 },
                new PictureBox[] { pictureBox11, pictureBox20, pictureBox29, pictureBox38 },
                new PictureBox[] { pictureBox10, pictureBox21, pictureBox30, pictureBox39 }
            };
            for (int i = 0; i < 9; i++)
            {
                moles[i] = new Mole(moles_sprites[i]);
            }
            bombs_sprites = new PictureBox[][] {
                    new PictureBox[] { pictureBox4, pictureBox40 },
                    new PictureBox[] { pictureBox5, pictureBox41 },
                    new PictureBox[] { pictureBox6, pictureBox42 },
                    new PictureBox[] { pictureBox9, pictureBox43 },
                    new PictureBox[] { pictureBox8, pictureBox44 },
                    new PictureBox[] { pictureBox7, pictureBox45 },
                    new PictureBox[] { pictureBox12, pictureBox46 },
                    new PictureBox[] { pictureBox11, pictureBox47 },
                    new PictureBox[] { pictureBox10, pictureBox48 }
            };
            for (int i = 0; i < 9; i++)
            {
                bombs[i] = new Bomb(bombs_sprites[i]);
            }
        }

        private async void GameTimer_Tick(object sender, EventArgs e)
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
                GameTimer.Interval = game_interval;
                int enemy_type;
                int holes_count = random.Next(1, 5);
                int[] holes = new int[holes_count];
                for (int i = 0; i < holes_count; i++)
                {
                    if (i == 0)
                    {
                        holes[i] = random.Next(0, 9);
                    }
                    else
                    {
                        do
                        {
                            holes[i] = random.Next(0, 9);
                        } while (Array.IndexOf(holes, holes[i], 0, i) != -1);
                    }
                }
                for (int i = 0; i < holes_count; i++)
                {
                    enemy_type = random.Next(1, 3);
                    if (enemy_type == 1)
                    {
                        moles[holes[i]].StartMoleAnimation(250);
                        await Task.Delay(250);
                        await Task.Delay(delay_time);
                        moles[holes[i]].StartMoleAnimation(250, "reversed");
                        await Task.Delay(250);
                    }
                    else
                    {
                        bombs[holes[i]].StartBombAnimation(250);
                        await Task.Delay(250);
                        await Task.Delay(delay_time);
                        bombs[holes[i]].StartBombAnimation(250, "reversed");
                        await Task.Delay(250);
                    }
                }
            }
        }
    }
}
