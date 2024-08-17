using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelicopterGame
{
    public class SmokeParticle
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float VelocityX { get; set; }
        public float VelocityY { get; set; }
        public float Opacity { get; set; }
        public int Lifetime { get; set; }

        public SmokeParticle(float x, float y)
        {
            X = x;
            Y = y;
            VelocityX = (float)(new Random().NextDouble() * 2 - 4); // Random velocity between -1 and 1
            VelocityY = (float)(new Random().NextDouble() * 2 - 1);
            Opacity = 1.0f;
            Lifetime = 100; // Example lifetime value
        }
    }
}

