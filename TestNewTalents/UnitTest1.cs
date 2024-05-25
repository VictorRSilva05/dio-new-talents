using NewTalents;

namespace TestNewTalents
{
    public class UnitTest1
    {
        public Calculadora ConstruirClasse()
        {
            string data = "25/05/2024";
            Calculadora calculadora = new Calculadora("25/05/2024");
            return calculadora;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int x, int y, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Somar(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TestMultiplicar(int x, int y, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Multiplicar(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TestDividir(int x, int y, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Dividir(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(5, 5, 0)]
        public void TestSubtrair(int x, int y, int resultado)
        {
            Calculadora calculadora = ConstruirClasse();

            int resultadoCalculadora = calculadora.Subtrair(x, y);

            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calculadora = ConstruirClasse();

            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calculadora = ConstruirClasse();

            calculadora.Somar(1, 2);
            calculadora.Somar(2, 8);
            calculadora.Somar(3, 7);
            calculadora.Somar(4, 1);

            var lista = calculadora.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }
    }
}