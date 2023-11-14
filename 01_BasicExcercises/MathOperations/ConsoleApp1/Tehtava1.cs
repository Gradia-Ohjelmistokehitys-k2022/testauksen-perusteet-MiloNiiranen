
using System.Linq;

public static class MathOperations
{

    private static void Main(string[] args)
    {

    }

    public static int MiinusLasku(int luku1, int luku2)
    {
        int tulos = luku1 - luku2;
        return tulos;
    }

    public static int ToisenPotensiin(int luku)
    {
        int tulos = luku * luku;

        if (luku > 100)
        {
            return 0;
        }
        else
        {
            return tulos;
        }
       

    }

    public static double LuvunNeliöJuuri(int luku)
    {
        double tulos = Math.Sqrt(luku);
        return tulos;
    }

    public static double ListanPieninArvo(List<double> lista)
    {
        double pieninArvo = lista.Min();
        return pieninArvo;
    }

    public static int ListanSuurinArvo(List<int> lista)
    {
        int suurinArvo = lista.Max();
        return suurinArvo;
    }

    public static float ListanKeskiArvo(List<float> lista)
    {
        float keskiarvo = lista.Average();
        return keskiarvo; 
    }
}   