public class Medlem
{
    public string Namn { get; set; }

    // Statiskt fält som delas mellan ALLA instanser av klassen
    public static int AntalMedlemmar = 0;

    public Medlem(string namn)
    {
        Namn = namn;
        AntalMedlemmar++;       // Räkna upp den gemensamma räknaren
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Medlem m1 = new Medlem("Erik");
        Medlem m2 = new Medlem("Sandra");
        Medlem m3 = new Medlem("Ulf");

        // Satiska fält anropas via Klassnamnet
        Console.WriteLine($"Totalt antal medlemmar: {Medlem.AntalMedlemmar}");

        // Icke-statiska fält tillhör respektive INSTANS
        Console.WriteLine($"Medlem 1 Namn = {m1.Namn}");
        Console.WriteLine($"Medlem 2 Namn = {m2.Namn}");
        Console.WriteLine($"Medlem 3 Namn = {m3.Namn}");





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
