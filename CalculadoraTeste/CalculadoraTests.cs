using Calculadora.Services;
using System;

namespace CalculadoraTeste;


public class CalculadoraTests

{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }


    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {

        int num1 = 5;
        int num2 = 10;

        int resultado = _calc.somar(num1, num2);

        //resultado esperado || resultado que vai sair
        Assert.Equal(15, resultado);

    }


    [Fact]

    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        int num = 4;

        bool resultado = _calc.EhPar(num);

        Assert.True(resultado);

    }


    [Theory]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(6)]
    [InlineData(8)]
    [InlineData(10)]
    public void DeveVerificarSeOsNumerosSaoParERetornarVerdadeiro(int numero)
    {
        bool resultado = _calc.EhPar(numero);

        Assert.True(resultado);
    }


    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void DeveVerificarSeOsNumerosSaoParERetornarVerdadeiros(int[] numeros)
    {

        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));


    }

}

