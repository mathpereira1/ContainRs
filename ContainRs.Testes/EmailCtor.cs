using ContainRs.WebApp.Models;


namespace ContainRs.Testes;

public class EmailCtor
{
    [Fact]
    public void Test1()
    {
        /// Fases do Teste
        /// 1. Arrange
        /// 2. Act
        /// 3. Assert


        // Arrange
        string emailInvalido = "www.google.com.br"; 


        // No xUnit, ele faz a captação de Exceções simultâneamente ao Act e o Assert
        Assert.Throws<ArgumentException>(() => new Email(emailInvalido));

    }
}
