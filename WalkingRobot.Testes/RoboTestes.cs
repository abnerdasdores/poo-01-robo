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

            robo.Direcao.X.Should().Be(-1);
            robo.Direcao.Y.Should().Be(0);
        }
    }
}
