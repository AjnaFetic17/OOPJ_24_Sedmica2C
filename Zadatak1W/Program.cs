internal class Program
{
    private static void Main(string[] args)
    {
        //ispis brojeva od 1 do 5
        int broj = 1;
        while (broj < 6)
        {
            Console.WriteLine(broj);
            broj++;
        }
        //ispisi kvadrat bojeva od 1 do 5
        // 1 na kvadrat je 1
        //2 na kvadrat je 4
        int br = 1;
        while (br < 6)
        {
            Console.WriteLine("{0} na kvadrat {1}", br, br * br);
            br++;
        }
    }
}