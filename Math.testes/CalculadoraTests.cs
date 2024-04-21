

using AutoFixture;
using FluentAssertions;
using LUnitTest;
using Moq;

namespace Math.testes
{
    public class CalculadoraTests
    {   ///implementando a lib Moq que cria objetos e classes, facilitando isolamento de unidades...
        ///implementando o autofixture para gerar dados aleatórios para testes
        private readonly Fixture _fixture;
        private readonly Operacoes _operacoes;
        private readonly Mock<ICalculadora> _calculadoraMock = new Mock<ICalculadora>();

            public CalculadoraTests()
            {
                _operacoes = new Operacoes(_calculadoraMock.Object);
                _fixture = new Fixture();
            }

        [Fact(DisplayName = "Primeiro método/unidade de Calculadora")]
        public void Somar_QuandoInformadoDoisNumeros_DeveSomarCorretamente_Chamando_O_Metodo_Somar()
        {
            ///Arrange(Configuração de toda a unidade que está sendo testada precisa pra funcionar)
            int num1 = _fixture.Create<int>();
            int num2 = _fixture.Create<int>();

            _calculadoraMock
            .Setup(x => x.Somar(It.IsAny<int>(), It.IsAny<int>()))
            .Returns(60);

            ///Act(Executa a ação/comportamento que está sendo testada)
           var resultado =  _operacoes.RealizarSoma(num1, num2);

            ///implementando o package FluentAsserts para verificar comparações entre testes...
            ///Assert(Validação)
            resultado
                .Should()
                .NotBe(0);

            resultado
                .Should()
                .BeGreaterThan(50);

            resultado
                .Should()
                .BeLessThanOrEqualTo(60);
            /// Podemos verificar um for utilizando "Times.Exactly passando quantas x queiramos que o teste seja chamado.
            resultado
                .Should()
                .Be(60);
            _calculadoraMock.Verify(x => x.Somar(It.IsAny<int>(), It.IsAny<int>()), Times.Once);
        }

     
    }
}
