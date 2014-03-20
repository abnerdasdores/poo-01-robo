namespace WalkingRobot
{
    public static class Direcao
    {
        public static readonly IncrementoPosicao Norte = new IncrementoPosicao(0, 1);

        public static readonly IncrementoPosicao Sul = new IncrementoPosicao(0, -1);

        public static readonly IncrementoPosicao Leste = new IncrementoPosicao(1, 0);

        public static readonly IncrementoPosicao Oeste = new IncrementoPosicao(-1, 0);
        
    }
}
