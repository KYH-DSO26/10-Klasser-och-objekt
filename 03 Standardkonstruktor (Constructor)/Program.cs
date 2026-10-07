public class Bil
{
    public string Märke { get; set; }
    public string Modell { get; set; }

    // Konstruktor som tvingar fram värden vid skapandet
    public Bil(string märke, string modell)
    {
        Märke = märke;
        Modell = modell;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        // Nu kan vi initiera objektet, inklusive värden, på en enda rad
        Bil minBil = new Bil("Volvo", "XC90");
        
        //Bil minAndraBil = new Bil();      // Ger kompileringsfel

        Console.WriteLine($"Min bil: {minBil.Märke} {minBil.Modell}");


        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}