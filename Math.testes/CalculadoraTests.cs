

using LUnitTest;

namespace Math.testes
{
    public class CalculadoraTests
    {
        private readonly Calculadora _calculadora;

            public CalculadoraTests()
            {
                _calculadora = new Calculadora();
            }

        [Fact(DisplayName = "Primeiro método/unidade de Calculadora")]
        public void Somar_QuandoInformadoDoisNumeros_DeveSomarCorretamente()
        {
            ///Arrange(Configuração de toda a unidade que está sendo testada precisa pra funcionar)
            int num1 = 10;
            int num2 = 20;

            ///Act(Executa a ação/comportamento que está sendo testada)
           var resultado =  _calculadora.Somar(num1, num2);

            ///Assert(Validação)
            Assert.Equal(30, resultado);
        }

        [Fact(DisplayName = "Primeiro método/unidade de Calculadora")]
        public void Multiplicar_QuandoInformadoDoisNumeros_DeveMultiplicarCorretamente()
        {
            ///Arrange 
            int num1 = 5;
            int num2 = 10;

            ///Act 
            var resultado = _calculadora.Multiplicar(num1, num2);

            ///Assert 
            Assert.Equal(50, resultado);
        }


        [Fact(DisplayName = "Primeiro método/unidade de Calculadora")]
        public void Subtrair_QuandoInformadoDoisNumeros_DeveSubtrairCorretamente()
        {
            ///Arrange 
            int num1 = 50;
            int num2 = 40;

            ///Act 
            var resultado = _calculadora.Subtrair(num1, num2);

            ///Assert 
            Assert.Equal(10, resultado);
        }
    }
}
