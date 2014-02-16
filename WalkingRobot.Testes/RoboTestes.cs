using System;
using NUnit.Framework;
using FluentAssertions;

namespace WalkingRobot.Testes
{
    [TestFixture]
    public class RoboTestes
    {
        private Robo robo;

        [SetUp]
        public void Inicalizar()
        {
            robo = new Robo();
        }

        [Test]
        public void DeveVirarParaAEsquerda()
        {
            robo.Esquerda();

            robo.Direcao.Should().Be(Direcao.Esquerda);
        }

        [Test]
        public void DeveVirarParaADireita()
        {
            robo.Direita();

            robo.Direcao.Should().Be(Direcao.Direita);
        }

        [Test]
        public void DeveAndarParaAEsquedaQuandoADirecaoForEsquerda()
        {
            robo.Esquerda();

            robo.Andar();

            var posicao = new Posicao(-1, 0);
            robo.Posicao.Should().Be(posicao);
        }

        [Test]
        public void DeveAndarParaAEsquedaQuandoADirecaoForDireita()
        {
            robo.Direita();

            robo.Andar();

            var posicao = new Posicao(1, 0);
            robo.Posicao.Should().Be(posicao);
        }

        [Test]
        public void DeveLancarExcecaoAoTentarAndarSemUmaDirecaoDefinida()
        {
            Action acao = () => robo.Andar();

            acao.ShouldThrow<InvalidOperationException>()
                    .WithMessage("O robô não possui uma direção definida");
        }
    }
}
