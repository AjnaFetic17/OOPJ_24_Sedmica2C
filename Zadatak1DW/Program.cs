internal class Program
{
    private static void Main(string[] args)
    {
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 6);

        //ispis kvadratnog korijena brojeva od 1 do 10
        //Math.Sqrt()
        //Kvadratni korijen broja i je x 
        //$""
        int broj = 1;
        do
        {
            Console.WriteLine($"Kvadratni korijen broja {broj} je {Math.Round(Math.Sqrt(broj), 4)} ");
            Console.WriteLine($"Kvadratni korijen broja {broj} je {Math.Sqrt(broj):F3} ");
            Console.WriteLine("Kvadratni korijen broja {0} je {1:F6} ", broj, Math.Sqrt(broj));
            broj++;
        } while (broj < 11);
    }
}