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
    public class DirecaoTestes
    {
        [Test]
        public void DeveRetornarVerdadeiroAoCompararComOperadorIgualDuasDirecoesIguais()
        {
            var direcao1 = Direcao.Direita;
            var direcao2 = Direcao.Direita;

            var saoIguais = direcao1 == direcao2;

            saoIguais.Should().BeTrue();
        }

        [Test]
        public void DeveRetornarFalsoAoCompararComOperadorIgualDuasDirecoesDiferentes()
        {
            var direcao1 = Direcao.Direita;
            var direcao2 = Direcao.Esquerda;

            var saoIguais = direcao1 == direcao2;

            saoIguais.Should().BeFalse();
        }

        [Test]
        public void DeveRetornarVerdadeiroAoCompararComOperadorDiferenteDuasDirecoesDiferentes()
        {
            var direcao1 = Direcao.Direita;
            var direcao2 = Direcao.Esquerda;

            var saoDiferentes = direcao1 != direcao2;

            saoDiferentes.Should().BeTrue();
        }

        [Test]
        public void DeveRetornarFalsoAoCompararComOperadorDiferenteDuasDirecoesIguais()
        {
            var direcao1 = Direcao.Direita;
            var direcao2 = Direcao.Direita;

            var saoDiferentes = direcao1 != direcao2;

            saoDiferentes.Should().BeFalse();
        }
    }
}
