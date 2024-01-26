using Bibliotheque.Exercice03.MStest;
using static Bibliotheque.Exercice03.MStest.Class1;

namespace Test_Exercice03_MStest
{ [TestClass]
public class RechercheVilleTests
{
    [TestMethod]
    public void RechercheVille_LancerExceptionSiTexteTropCourt()
    {
        var rechercheVille = new Class1(new List<string>());

        Assert.ThrowsException<NotFoundException>(() => rechercheVille.Recherche("a"));
    }
}
}