using MeuProjeto.App;

namespace MeuProjeto.Testes;

public class CalculadoraTestes
{
    [Fact]
    public void DeveSomarDoisNumeros()
    {
        // Arrange
        // Act
        var resultado = Calculadora.Somar(1, 2);

        // Assert
        Assert.Equal(3, resultado);
    }
}