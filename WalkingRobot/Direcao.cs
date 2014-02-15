using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkingRobot
{
    public struct Direcao
    {
        public static Direcao Direita = new Direcao(1, 0);

        public static Direcao Esquerda = new Direcao(-1, 0);

        private short x;
        private short y;

        private Direcao(short x, short y)
        {
            this.x = x;
            this.y = y;
        }

        public short X { get { return x; } }

        public short Y { get { return y; } }

        public static bool operator ==(Direcao direcaoA, Direcao direcaoB)
        {
            return direcaoA.Equals(direcaoB);
        }

        public static bool operator !=(Direcao direcaoA, Direcao direcaoB)
        {
            return !direcaoA.Equals(direcaoB);
        }
    }
}
