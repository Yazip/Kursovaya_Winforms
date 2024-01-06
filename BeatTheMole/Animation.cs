using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    internal class Animation
    {
        private PictureBox[] sprites;
        private int interval;
        private Timer animation_timer;
        private int sprite_index;
        private int sprites_length;
        public Animation(PictureBox[] sprites, int interval)
        {
            this.sprites = (PictureBox[])sprites.Clone();
            this.interval = interval / (sprites.Length);
            sprite_index = 0;
            sprites_length = sprites.Length;
        }
        public void StartAnimation()
        {
            animation_timer = new Timer();
            animation_timer.Interval = interval;
            animation_timer.Tick += Animation_Timer_Tick;
            animation_timer.Start();
        }
        private void Animation_Timer_Tick(object sender, EventArgs e)
        {
            if (sprite_index < sprites_length)
            {
                for (int i = 0; i < sprites_length; i++)
                {
                    if (i == sprite_index)
                    {
                        sprites[i].Visible = true;
                    }
                    else
                    {
                        sprites[i].Visible = false;
                    }
                }
            }
            else
            {
                animation_timer.Stop();
            }
            ++sprite_index;
        }
    }
}
