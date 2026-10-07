public class Produkt
{
    public string Namn { get; set; }
    public double Pris { get; set; }

    public Produkt(string namn, double pris)
    {
        Namn = namn; 
        Pris = pris;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        // Skapa en lista för att hålla våra objekt
        List<Produkt> varukorg = new List<Produkt>();

        Produkt produkt = new Produkt("Öl", 14.25);
        varukorg.Add(produkt);

        varukorg.Add(new Produkt("Kaffe", 45.50));      // Ett mer kompakt skrivsätt
        varukorg.Add(new Produkt("Mjölk", 18.90));
        varukorg.Add(new Produkt("Bröd", 32.00));

        Console.WriteLine("Din varukorg innehåller:");
        foreach (var p in varukorg)
        {
            Console.WriteLine($"- {p.Namn} ({p.Pris:C2})");
        }




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
