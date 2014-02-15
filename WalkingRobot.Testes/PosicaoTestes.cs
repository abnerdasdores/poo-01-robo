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
    }
}
