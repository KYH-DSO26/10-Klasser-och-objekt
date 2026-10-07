public class Bil
{
    public string Modell { get; set; }
    public bool IsTrasig { get; set; }

    public Bil(string modell)
    {
        Modell = modell;
        IsTrasig = true;    // Alla bilar som kommer in är trasiga från början
    }
}

public class Mekaniker
{
    public string Namn { get; set; }
    public Mekaniker(string namn)
    {
        Namn = namn;
    }

    // Metod som tar emot ett helt objekt av typen Bil som parameter
    public void Reparera(Bil b)
    {
        if (b.IsTrasig)
        {
            b.IsTrasig = false;
            Console.WriteLine($"Mekaniker {Namn} har lagat {b.Modell}!");
        }
        else
        {
            Console.WriteLine($"{b.Modell} är redan i utmärkt skick.");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var minBil = new Bil("Volvo V40");
        var meken = new Mekaniker("Bosse");

        Console.WriteLine($"Är bilen trasig före beök? {minBil.IsTrasig}");

        // Mekanikern fixar bilen
        meken.Reparera(minBil);
        Console.WriteLine($"Är bilen trasig efter beök? {minBil.IsTrasig}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
