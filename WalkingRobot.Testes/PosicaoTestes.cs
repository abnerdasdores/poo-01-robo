using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace WalkingRobot.Testes
{
    [TestFixture]
    public class PosicaoTestes
    {
        [Test]
        public void DeveRetornarVerdadeiroAoCompararComOperadorIgualDuasPosicoesIguais()
        {
            var posicao1 = new Posicao(5, 10);
            var posicao2 = new Posicao(5, 10);

            var saoIguais = posicao1 == posicao2;

            saoIguais.Should().BeTrue();
        }

        [Test]
        public void DeveRetornarFalsoAoCompararComOperadorIgualDuasPosicoesDiferentes()
        {
            var posicao1 = new Posicao(5, 10);
            var posicao2 = new Posicao(10, 10);

            var saoIguais = posicao1 == posicao2;

            saoIguais.Should().BeFalse();
        }


        [Test]
        public void DeveRetornarVerdadeiroAoCompararComOperadorDiferenteDuasPosicoesDiferentes()
        {
            var posicao1 = new Posicao(5, 10);
            var posicao2 = new Posicao(10, 10);

            var saoDiferentes = posicao1 != posicao2;

            saoDiferentes.Should().BeTrue();
        }

        [Test]
        public void DeveRetornarFalsoAoCompararComOperadorDiferenteDuasPosicoesIguais()
        {
            var posicao1 = new Posicao(5, 10);
            var posicao2 = new Posicao(5, 10);

            var saoDiferentes = posicao1 != posicao2;

            saoDiferentes.Should().BeFalse();
        }

        [Test]
        [TestCase(0, 0, 0, 0, 0, 0)]
        [TestCase(1, 2, 3, 4, 4, 6)]
        [TestCase(1, 2, -3, -4, -2, -2)]
        [TestCase(-3, -5, 2, 3, -1, -2)]
        [TestCase(-2, -1, -5, -3, -7, -4)]
        public void DeveSomarDuasPosicoes(int posicao1X, int posicao1Y, int posicao2X, int posicao2Y,
                                            int posicaoResX, int posicaoResY)
        {
            var posicao1 = new Posicao(posicao1X, posicao1Y);
            var posicao2 = new Posicao(posicao2X, posicao2Y);
            var posicaoResultante = new Posicao(posicaoResX, posicaoResY);

            var resultado = posicao1 + posicao2;

            resultado.Should().Be(posicaoResultante);
        }
    }
}
