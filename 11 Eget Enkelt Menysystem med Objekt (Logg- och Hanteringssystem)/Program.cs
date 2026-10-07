public class Hotellrum
{
    public int RumNummer { get; set; }
    public string GästNamn { get; set; }
    public bool IsOckuperat { get; set; }

    public Hotellrum(int rumNummer)
    {
        RumNummer = rumNummer;
        GästNamn = "Ingen";
        IsOckuperat = false;
    }

    public void CheckaIn(string gäst)
    {
        GästNamn = gäst;
        IsOckuperat = true;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        List<Hotellrum> reception = new List<Hotellrum>
        {
            new Hotellrum(101),
            new Hotellrum(102),
            new Hotellrum(103),
            new Hotellrum(104),
        };

        while (true)
        {
            //Console.Clear();
            Console.WriteLine("\n--- HOTELLRECEPTION ---");
            Console.WriteLine("1. Visa alla rum");
            Console.WriteLine("2. Checka in gäst");
            Console.WriteLine("3. Avsluta");
            Console.Write("Välj: ");
            string val = Console.ReadLine();

            if (val == "1")
            {
                foreach (var rum in reception)
                {
                    string status = rum.IsOckuperat ? $"Upptaget av {rum.GästNamn}" : "Ledigt";
                    Console.WriteLine($"Rum {rum.RumNummer}: {status}");
                }
            }

            else if (val == "2")
            {
                Console.Write("Ange rumsnummer (101-104): ");
                int nr = int.Parse(Console.ReadLine());

                Hotellrum valtRum = reception.Find(r => r.RumNummer == nr);
                if (valtRum != null && !valtRum.IsOckuperat)
                {
                    Console.Write("Ange gästens namn: ");
                    string namn = Console.ReadLine();
                    valtRum.CheckaIn(namn);
                    Console.WriteLine("Incheckning klar!");
                }
                else
                {
                    Console.WriteLine("Rummet hittades inte eller var upptaget.");
                }
            }
            else if (val == "3")
            {
                Console.WriteLine("\n\nProgrammet avslutas. Tack för idag!");
                break;
            }
        }




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
