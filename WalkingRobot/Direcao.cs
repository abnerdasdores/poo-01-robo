using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkingRobot
{
    public class Direcao
    {
        public Direcao(short X, short Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public short X { get; private set; }

        public short Y { get; private set; }
    }
}
