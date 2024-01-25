using static Bibliotheque.Exercice03.MStest.Class1;

namespace Test_Exercice03_MStest
{ [TestClass]
public class RechercheVilleTests
{
    [TestMethod]
    public void Rechercher_ReturnsEmptyList_WhenNoMatchFound()
    {
        var rechercheVille = new RechercheVille();
        var mot = "Unknown";

        var result = rechercheVille.Rechercher(mot);

        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);
    }
}
}