﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTeste
{
    public class ValidacoesStringTests
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTests()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3CaracteresEmOlaRetornar3()
        {
            string texto = "ola";

            int resultado = _validacoes.ContarCaracteres(texto);

            Assert.Equal(3, resultado);

        }
    }
}
