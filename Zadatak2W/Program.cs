internal class Program
{
    private static void Main(string[] args)
    {
        //ispisati parne brojeve od 1 do 17
        int i = 1;
        Console.WriteLine("Parni brojevi:");
        while (i <= 17)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}