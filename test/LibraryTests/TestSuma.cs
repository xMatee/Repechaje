using Library;
namespace LibraryTests;

public class TestSuma
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestResult1()
    {
        // Arrange
        
        EntradaNumerica ent4 = new(5);
        EntradaNumerica ent5 = new(10);
        EntradaNumerica ent6 = new(15);
        Suma opSum1 = new Suma (ent4,ent5,5);

        opSum1.addEntrada(ent6);
        double expected = 30;

        // Act
        double result = opSum1.getValue();
        Console.WriteLine(result);
        Console.WriteLine(expected);
        // Assert
        Assert.That(result.Equals(expected));

    }
}
//     public void TestResult4()
//     {
//         // Arrange
//         Multiplicacion opMul2 = new(3);
//         Multiplicacion opSum1 = new(3);

//         Multiplicacion opMul4 = new(3);

//         EntradaNumerica ent1 = new(opSum1.getValue());
//         EntradaNumerica ent2 = new(opMul2.getValue());
//         EntradaNumerica ent3 = new(2);
//         opMul4.addEntrada(ent1);
//         opMul4.addEntrada(ent2);
//         opMul4.addEntrada(ent3);
//         double expected = 600;

//         // Act
//         double result = opMul4.getValue();

//         // Assert
//         Assert.That(result.Equals(expected));

//     }
// }