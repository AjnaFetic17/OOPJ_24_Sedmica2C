internal class Program
{
    private static void Main(string[] args)
    {
        //naci proizvod prirodnih brojeva u intervalu od k do n cija je cifra jedinica 4
        int k, n, proizvod = 1;
        Console.WriteLine("Unesite broj k");
        k = int.Parse(Console.ReadLine());
        Console.WriteLine("unesite broj n");
        n = int.Parse(Console.ReadLine());
        do
        {
            if (k % 10 == 4)
            {
                proizvod *= k;
            }
            k++;
        } while (k < n);
        Console.WriteLine("Proizvod svih unesenih brojeva je: {0}", proizvod);
    }
}