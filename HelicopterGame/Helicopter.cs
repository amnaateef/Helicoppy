using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelicopterGame
{
    public class Helicopter
    {
        public PictureBox PictureBox { get; private set; }
        public int Gravity { get; set; }

        public Helicopter(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }

        public void Move()
        {
            PictureBox.Top += Gravity;
        }
    }
}
