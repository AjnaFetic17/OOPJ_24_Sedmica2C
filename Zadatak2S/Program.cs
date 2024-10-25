//Na osnovu broja mjeseca odrediti godisnje doba
//12,1,2 zima, 3,4,5 proljece
//<1 i >12 Neispravan broj mjeseca
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("unesite mjesec");
        int mjesec = int.Parse(Console.ReadLine());
        string godisnjedoba;
        switch (mjesec)
        {
            case 12:
            case 1:
            case 2:
                godisnjedoba = "zima";
                break;
            case 3:
            case 4:
            case 5:
                godisnjedoba = "proljece";
                break;
            case 6:
            case 7:
            case 8:
                godisnjedoba = "ljeto";
                break;
            case 9:
            case 10:
            case 11:
                godisnjedoba = "jesen";
                break;
            default:
                godisnjedoba = "pogresanunos";
                break;
        }
        Console.WriteLine(godisnjedoba);
    }
}