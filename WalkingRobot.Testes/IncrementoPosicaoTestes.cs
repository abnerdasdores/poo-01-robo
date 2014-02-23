using FluentAssertions;
using NUnit.Framework;

namespace WalkingRobot.Testes
{
    [TestFixture]
    public class IncrementoPosicaoTestes
    {
        [Test]
        public void DeveRetornarVerdadeiroAoCompararComOperadorIgualDoisIncrementosIguais()
        {
            var incrementoPosicao1 = Direcao.Leste;
            var incrementoPosicao2 = Direcao.Leste;

            var saoIguais = incrementoPosicao1 == incrementoPosicao2;

            saoIguais.Should().BeTrue();
        }

        [Test]
        public void DeveRetornarFalsoAoCompararComOperadorIgualDoisIncrementosDiferentes()
        {
            var incrementoPosicao1 = Direcao.Leste;
            var incrementoPosicao2 = Direcao.Oeste;

            var saoIguais = incrementoPosicao1 == incrementoPosicao2;

            saoIguais.Should().BeFalse();
        }

        [Test]
        public void DeveRetornarVerdadeiroAoCompararComOperadorDiferenteDoisIncrementosDiferentes()
        {
            var incrementoPosicao1 = Direcao.Leste;
            var incrementoPosicao2 = Direcao.Oeste;

            var saoDiferentes = incrementoPosicao1 != incrementoPosicao2;

            saoDiferentes.Should().BeTrue();
        }

        [Test]
        public void DeveRetornarFalsoAoCompararComOperadorDiferenteDoisIncrementosIguais()
        {
            var incrementoPosicao1 = Direcao.Leste;
            var incrementoPosicao2 = Direcao.Leste;

            var saoDiferentes = incrementoPosicao1 != incrementoPosicao2;

            saoDiferentes.Should().BeFalse();
        }
    }
}
