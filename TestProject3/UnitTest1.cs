using Atividade_PO3;

namespace TestProject3
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod1()
        {
            float valorProduto = 100.0f;
            float valorDesconto = 10.0f;
            CalcDesconto calcDesconto = new CalcDesconto();

            float resultado = (float)calcDesconto.CalcularDesconto(valorProduto, valorDesconto);

            Assert.AreEqual(resultado, 90);

            
        }
    }
}