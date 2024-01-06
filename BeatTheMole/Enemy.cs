using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeatTheMole
{
    internal abstract class Enemy
    {
        protected PictureBox[] sprites;
        protected PictureBox[] reverse_sprites;
    }
}
