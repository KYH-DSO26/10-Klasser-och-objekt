public class Kurs
{
    public string Kursnamn { get; set; }
    public string Kurskod { get; set; }

    // Konstruktor 1: Tar emot allt
    public Kurs(string kursnamn, string kurskod)
    {
        Kursnamn = kursnamn;
        Kurskod = kurskod;
    }

    // Konstruktor 2: Överlagring. Tar bara emot namnet
    public Kurs(string kursnamn)
    {
        Kursnamn = kursnamn;
        Kurskod = "TBD";        // Standardvärde
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Kurs k1 = new Kurs("C# programmering", "CGRP1");
        var k2 = new Kurs("Agil projektledning");           // Kurskod saknas

        Console.WriteLine($"Kurs 1: {k1.Kursnamn} ({k1.Kurskod})");
        Console.WriteLine($"Kurs 2: {k2.Kursnamn} ({k2.Kurskod})");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
