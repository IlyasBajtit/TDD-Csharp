using Demo01Bibliotheque;
namespace Demo01.Tests;



[TestClass]
public class CalculTest
{
    public void WhenAddition_10_30Then_40()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act 

        var result = calcul.Addition(10, 30); 

        // Assert 
        Assert.AreEqual(40, result);
    }


[TestMethod]

    public void WhenDivision_30_10Then_3()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act 

        var result = calcul.Division(30, 10);

        // Assert 
        Assert.AreEqual(3, result);
    }


    [TestMethod]

    public void WhenDivision_1_0_Then_DivideByZeroExeception ()
    {
        // Arrange 
        var calcul = new Calcul();

        // Act 

        double result = calcul.Division(1, 0);
    }
}

