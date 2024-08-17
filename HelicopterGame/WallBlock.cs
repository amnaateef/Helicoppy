using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelicopterGame
{
    public class WallBlock
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        private Image BlockImage { get; set; }

        public Rectangle Bounds => new Rectangle(X, Y, Width, Height);

        public WallBlock(int x, int y, int width, int height, Image blockImage)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
            BlockImage = blockImage;
        }

        public void Move(int speed)
        {
            X -= speed;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(BlockImage, Bounds);
        }
    }
}
