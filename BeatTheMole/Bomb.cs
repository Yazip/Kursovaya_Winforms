using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    internal class Bomb : Enemy
    {
        public Bomb(PictureBox[] sprites)
        {
            this.sprites = (PictureBox[])sprites.Clone();
            reverse_sprites = (PictureBox[])sprites.Clone();
            Array.Reverse(reverse_sprites);
        }
        public void StartBombAnimation(int interval, string type = "normal")
        {
            if (type == "reversed")
            {
                Animation bomb_animation = new Animation(reverse_sprites, interval);
                bomb_animation.StartAnimation();
            }
            else
            {
                Animation bomb_animation = new Animation(sprites, interval);
                bomb_animation.StartAnimation();
            }
        }
    }
}
