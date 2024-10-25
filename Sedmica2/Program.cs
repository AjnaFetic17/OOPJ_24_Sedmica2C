//Korisnik unoisi broj 1-12, ispisati naziv mjeseca
//ako je broj izvan 1-12, poruka Neispravan broj
internal class Program
{
    private static void Main(string[] args)
    {
        //int dan = 8;
        //string nazivDana;

        //switch (dan) {
        //    case 1:
        //        nazivDana = "Ponedjeljak";
        //        break;
        //    case 2:
        //        nazivDana = "Utorak";
        //        break;
        //    case 3:
        //        nazivDana = "Srijeda";
        //        break;
        //    case 4:
        //        nazivDana = "Cetvrtak";
        //        break;
        //    case 5:
        //        nazivDana = "Petak";
        //        break;
        //    case 6:
        //        nazivDana = "Subota";
        //        break;
        //    case 7:
        //        nazivDana = "Nedjelja";
        //        break;
        //    default:
        //        nazivDana = "Neispravan dan";
        //        break;
        //}
        //Console.WriteLine(nazivDana);
        Console.WriteLine("Uneiste broj od 1 do 12");
        int dan;
        dan = int.Parse(Console.ReadLine());

        switch (dan)
        {
            case 1:
                Console.WriteLine("Januar");
                break;
            case 2:
                Console.WriteLine("Februar");
                break;
            case 3:
                Console.WriteLine("Mart");
                break;
            case 4:
                Console.WriteLine("April");
                break;
            case 5:
                Console.WriteLine("Maj");
                break;
            case 6:
                Console.WriteLine("Juni");
                break;
            case 7:
                Console.WriteLine("juli");
                break;
            case 8:
                Console.WriteLine("August");
                break;
            case 9:
                Console.WriteLine("Septembar");
                break;
            case 10:
                Console.WriteLine("Oktobar");
                break;
            case 11:
                Console.WriteLine("Novembar");
                break;
            case 12:
                Console.WriteLine("Decembar");
                break;
            default:
                Console.WriteLine("Nesipravan broj");
                break;

        }
    }
}