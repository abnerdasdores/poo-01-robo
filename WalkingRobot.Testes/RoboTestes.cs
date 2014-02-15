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
    }
}
