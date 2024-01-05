using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    internal class Mole : Enemy
    {
        public Mole(PictureBox[] sprites)
        {
            this.sprites = (PictureBox[])sprites.Clone();
            reverse_sprites = (PictureBox[])sprites.Clone();
            Array.Reverse(reverse_sprites);
        }
        public void StartMoleAnimation(int interval, string type = "normal")
        {
            if (type == "reversed")
            {
                Animation mole_animation = new Animation(reverse_sprites, interval);
                mole_animation.StartAnimation();
            }
            else
            {
                Animation mole_animation = new Animation(sprites, interval);
                mole_animation.StartAnimation();
            }
        }
    }
}
