namespace WalkingRobot
{
    public class Robo
    {
        public readonly IncrementoPosicao Incremento;

        public readonly Posicao Posicao;

        public Robo()
            : this(new Posicao(0, 0), Direcao.Leste)
        { }

        public Robo(Posicao posicao)
            : this(posicao, Direcao.Leste)
        { }

        public Robo(IncrementoPosicao incremento)
            : this(new Posicao(0, 0), incremento)
        { }

        public Robo(Posicao posicao, IncrementoPosicao incremento)
        {
            Posicao = posicao;
            Incremento = incremento;
        }

        public Robo MudarDirecao(IncrementoPosicao incremento)
        {
            return new Robo(Posicao, incremento);
        }

        public Robo Andar()
        {
            var novaPosicao = Posicao + Incremento;
            return new Robo(novaPosicao, Incremento);
        }
    }
}
