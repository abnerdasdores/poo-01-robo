using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkingRobot
{
    public class Robo
    {
        public Robo()
        {
            Posicao = new Posicao(0, 0);
        }

        public Robo(Posicao posicao)
        {
            Posicao = posicao;
        }

        public Direcao Direcao { get; private set; }

        public Posicao Posicao { get; private set; }

        public void Esquerda()
        {
            Direcao = WalkingRobot.Direcao.Esquerda;
        }

        public void Direita()
        {
            Direcao = WalkingRobot.Direcao.Direita;
        }

        public void Andar()
        {
            Posicao incremento = new Posicao(Direcao.X, Direcao.Y);

            Posicao = Posicao + incremento;
        }
    }
}
