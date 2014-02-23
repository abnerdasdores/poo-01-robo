namespace WalkingRobot
{
    public class Robo
    {
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

        public Direcao Direcao { get; private set; }

        public Posicao Posicao { get; private set; }

        public void MudarDirecao(Direcao direcao)
        {
            Direcao = direcao;
        }
        
        public void Andar()
        {
            Posicao = Posicao + IncrementoPosicao.ObterIncremento(Direcao);
        }
    }
}
