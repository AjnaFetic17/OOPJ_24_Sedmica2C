internal class Program
{
    private static void Main(string[] args)
    {
        //Trazimo od korisnika da unosi brojeve sve dok ne unese 0
        //na kraju ispisujemo zbir unesenih brojeva
        int s = 0;
        int broj;

        while (true)
        {
            broj = int.Parse(Console.ReadLine());
            if (broj == 0) break;
            s = s + broj;
        }
        bool provjera = false;

        while (provjera == false)
        {
            broj = int.Parse(Console.ReadLine());
            if (broj == 0) provjera = true;
            else s = s + broj;
        }

        int broj2 = -1;
        while (broj2 != 0)
        {
            broj2 = int.Parse(Console.ReadLine());
            s = s + broj2;
        }

        while ((broj = int.Parse(Console.ReadLine())) != 0)
        {
            s = s + broj2;
        }
    }
}