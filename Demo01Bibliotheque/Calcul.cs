namespace Demo01Bibliotheque
{
    public class Calcul
    {
        public double Addition(double x, double y)
        { 
            return x + y; 
        }

        public double Division(double x, double y)
        {
            return x / y;


            throw new NotImplementedException("Division par 0 impossible");
        }
    }
}
