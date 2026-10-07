public class Batteri
{
    public int Kapacitet { get; set; }
    public Batteri(int kapacitet)
    {
        Kapacitet = kapacitet;
    }
}

public class Mobiltelefon
{
    public string Modell { get; set; }

    // En egenskap vars datatyp är en annan klass
    public Batteri TelefonBatteri { get; set; }

    public Mobiltelefon(string modell, Batteri batteri)
    {
        Modell = modell;
        TelefonBatteri = batteri;
    }

    public void VisaStatus()
    {
        Console.WriteLine($"Mobiltelefon: {Modell}");
        if (TelefonBatteri != null)
        {
            Console.WriteLine($"Batterinivå: {TelefonBatteri.Kapacitet}");
        }
        else
        {
            Console.WriteLine("Inget batteri installerat!");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        // Skapa först batteriet
        var standardBatteri = new Batteri(85);

        // Skicka in batteriet till mobiltelefonens konstruktor
        var minTelefon = new Mobiltelefon("iPhone76", standardBatteri);

        // Visa status (kommer åt data i nästlade objekt)
        minTelefon.VisaStatus();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
