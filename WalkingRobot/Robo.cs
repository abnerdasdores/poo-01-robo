using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingRobot
{
    public class Robo
    {
        public Direcao Direcao { get; private set; }

        public void Esquerda()
        {
            Direcao = new Direcao(-1, 0);
        }

        public void Direita()
        {
            Direcao = new Direcao(1, 0);
        }
    }
}
