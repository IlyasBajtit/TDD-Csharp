namespace Bibliotheque.Exercice03.MStest
{
    public class Class1
    {
        private List<String> _villes;


        public static List<string> Villes = new List<string> {
            "Paris", "Budapest", "Skopje", "Rotterdam", "Valence",
            "Vancouver", "Amsterdam", "Vienne", "Sydney", "New York",
            "Londres", "Bangkok", "Hong Kong", "Dubai", "Rome", "Istanbul"
        };

        public List<string> Rechercher(string mot)
        {
            if (mot == "*")
            {
                return _villes;
            }
            if (mot.Length < 2)
            {
                throw new NotFoundException();
            }
            return _villes.Where(ville => ville.ToLower().Contains(mot.ToLower())).ToList();
        }

    }
}


