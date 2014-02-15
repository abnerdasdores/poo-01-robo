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
        
        public static bool operator ==(Posicao posicaoA, Posicao posicaoB) 
        {
            return posicaoA.Equals(posicaoB);
        }

        public static bool operator !=(Posicao posicaoA, Posicao posicaoB) 
        {
            return !posicaoA.Equals(posicaoB);
        }
    }
}
