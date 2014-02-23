using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalkingRobot
{
    public struct Posicao
    {
        public readonly int X;
        public readonly int Y;

        public Posicao(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var posicao = (Posicao)obj;

            return X == posicao.X && Y == posicao.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
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
