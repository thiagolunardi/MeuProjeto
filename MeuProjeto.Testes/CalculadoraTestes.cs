namespace MeuProjeto.Testes;

public class CalculadoraTestes
{
    [Fact]
    public void DeveSomarDoisNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();

        // Act
        var resultado = calculadora.Somar(1, 2);

        // Assert
        Assert.Equal(3, resultado);
    }
}