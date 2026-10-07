public class Bok
{
    // Publika fält för datalagring
    public string Titel;
    public string Författare;
}




internal class Program
{
    private static void Main(string[] args)
    {
        Bok minBok = new Bok();
        minBok.Titel = "Sagan om ringen";
        minBok.Författare = "J.R.R. Tolkien";

        Console.WriteLine($"Min bok titel: {minBok.Titel}, Författare: {minBok.Författare}");






        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}