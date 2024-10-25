//Napisati jednostavni kalkulator 
//korisnik unosi 2 broja a i b i bira 1,2,3,4 za sabiranje, oduzimanje,
//mnozenje i dijeljenej
internal class Program
{
    private static void Main(string[] args)
    {
        double a, b;
        Console.WriteLine("Unesite prvi broj: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Unesite drugi broj: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Unesite zeljenu operaciju: ");
        Console.WriteLine("1-Sabiranje");
        Console.WriteLine("2-Oduzimanje");
        Console.WriteLine("3-Mnozenje");
        Console.WriteLine("4-Dijeljenje");
        int operacija = int.Parse(Console.ReadLine());

        switch (operacija)
        {
            case 1:
                Console.WriteLine("Zbir je {0}", a + b);
                break;
            case 2:
                if (a > b)
                {
                    Console.WriteLine("a-b={0}", a - b);
                }
                else
                {
                    Console.WriteLine("b-a={0}", b - a);
                }
                break;
            case 3:
                Console.WriteLine("a*b={0}", a * b);
                break;
            case 4:
                if (b != 0)
                {
                    Console.WriteLine("a/b={0}", a / b);
                }
                else
                {
                    Console.WriteLine("Dijeljenje 0 nije moguce", b - a);
                }
                break;
            default:
                Console.WriteLine("Pogresan izbor!");
                break;
        }
    }
}