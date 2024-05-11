using MeuProjeto.App;

namespace MeuProjeto.Testes;

public class CalculadoraTestes
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 4, 7)]
    public void DeveSomarDoisNumeros(int a, int b, int resultadoEsperado)
    {
        // Arrange
        // Act
        var resultado = Calculadora.Somar(a, b);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}