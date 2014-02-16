using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkingRobot
{
    public struct Posicao
    {
        private int x;
        private int y;

        public Posicao(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get { return x; } }

        public int Y { get { return y; } }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var posicao = (Posicao)obj;

            return x == posicao.X && y == posicao.Y;
        }

        public override int GetHashCode()
        {
            return x ^ y;
        }

        public static bool operator ==(Posicao posicaoA, Posicao posicaoB)
        {
            return posicaoA.Equals(posicaoB);
        }

        public static bool operator !=(Posicao posicaoA, Posicao posicaoB)
        {
            return !posicaoA.Equals(posicaoB);
        }

        public static Posicao operator +(Posicao posicaoA, Posicao posicaoB)
        {
            return new Posicao(posicaoA.X + posicaoB.X, posicaoA.Y + posicaoB.Y);
        }
    }
}
