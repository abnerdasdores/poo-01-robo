﻿using FluentAssertions;
using NUnit.Framework;

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
            robo.MudarDirecao(Direcao.Oeste);

            robo.Direcao.Should().Be(Direcao.Oeste);
        }

        [Test]
        public void DeveVirarParaADireita()
        {
            robo.MudarDirecao(Direcao.Leste);

            robo.Direcao.Should().Be(Direcao.Leste);
        }

        [Test]
        public void DeveAndarParaAEsquerdaQuandoADirecaoForEsquerda()
        {
            robo.MudarDirecao(Direcao.Oeste);

            robo.Andar();

            var posicao = new Posicao(-1, 0);
            robo.Posicao.Should().Be(posicao);
        }

        [Test]
        public void DeveAndarParaADireitaQuandoADirecaoForDireita()
        {
            robo.MudarDirecao(Direcao.Leste);

            robo.Andar();

            var posicao = new Posicao(1, 0);
            robo.Posicao.Should().Be(posicao);
        }
    }
}
