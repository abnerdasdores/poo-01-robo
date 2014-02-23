namespace WalkingRobot
{
    public struct IncrementoPosicao
    {
        public static IncrementoPosicao ObterIncremento(Direcao direcao)
        {
            switch (direcao)
            {
                case Direcao.Norte:
                    return new IncrementoPosicao(0, 1);
                    break;
                case Direcao.Sul:
                    return new IncrementoPosicao(0, -1);
                    break;
                case Direcao.Leste:
                    return new IncrementoPosicao(1, 0);
                    break;
                case Direcao.Oeste:
                    return new IncrementoPosicao(-1, 0);
                    break;
                default:
                    return new IncrementoPosicao(0, 0);
                    break;
            }
        }

        public readonly short X;
        public readonly short Y;

        private IncrementoPosicao(short x, short y)
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
