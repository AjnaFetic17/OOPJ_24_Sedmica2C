internal class Program
{
    private static void Main(string[] args)
    {
        //napisati program koji ce za ucitanu vrijednost broja n izracunati
        //vrijednost izraza i ispisati ga
        int i = 1, n, k;
        double s = 0, p = 1, s1 = 0, s2 = 0;

        Console.WriteLine("Unesite parametar k");
        k = int.Parse(Console.ReadLine());

        Console.WriteLine("Unesite parametar n");
        n = int.Parse(Console.ReadLine());

        do
        {
            p *= i;
            if (i % 2 == 0)
            {
                s2 += k * p;
            }
            else
            {
                s1 += k * p;
            }
            i++;
        } while (i <= n);
        s = s1 - s2;
        Console.WriteLine("Rezltat je {0}", s);
    }
}