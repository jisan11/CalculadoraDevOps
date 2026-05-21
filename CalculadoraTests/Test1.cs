using CalculadoraApp;

namespace CalculadoraTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestSuma()
    {
        Calculadora calc = new Calculadora();

        int resultado = calc.Sumar(2, 3);

        Assert.AreEqual(5, resultado);
    }
}
