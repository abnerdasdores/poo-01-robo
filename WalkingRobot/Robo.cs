namespace WalkingRobot
{
    public class Robo
    {
        public readonly Direcao Direcao;

        public readonly Posicao Posicao;

        public Robo()
            : this(new Posicao(0, 0), Direcao.Leste)
        { }

        public Robo(Posicao posicao)
            : this(posicao, Direcao.Leste)
        { }

        public Robo(Direcao direcao)
            : this(new Posicao(0, 0), direcao)
        { }

        public Robo(Posicao posicao, Direcao direcao)
        {
            Posicao = posicao;
            Direcao = direcao;
        }

        public Robo MudarDirecao(Direcao direcao)
        {
            return new Robo(Posicao, direcao);
        }

        public Robo Andar()
        {
            var novaPosicao = Posicao + IncrementoPosicao.ObterIncremento(Direcao);
            return new Robo(novaPosicao, Direcao);
        }
    }
}
