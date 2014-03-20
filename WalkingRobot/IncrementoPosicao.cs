namespace WalkingRobot
{
    public struct IncrementoPosicao
    {
        public readonly short X;
        public readonly short Y;

        public IncrementoPosicao(short x, short y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            var direcao = (IncrementoPosicao)obj;

            return X == direcao.X && Y == direcao.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }

        public static bool operator ==(IncrementoPosicao incrementoPosicaoA, IncrementoPosicao incrementoPosicaoB)
        {
            return incrementoPosicaoA.Equals(incrementoPosicaoB);
        }

        public static bool operator !=(IncrementoPosicao incrementoPosicaoA, IncrementoPosicao incrementoPosicaoB)
        {
            return !incrementoPosicaoA.Equals(incrementoPosicaoB);
        }
    }
}
