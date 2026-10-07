public class Hund
{
    public string Namn { get; set; }
    public Hund(string namn)
    {
        Namn = namn;
    }

    // Instansmetod som använder objektets interna tillstånd (Namn)
    public void Skall()
    {
        Console.WriteLine($"{Namn} skäller: voff voff!");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Hund Tossan = new Hund("Tossan");
        Tossan.Skall();                     // Anropa via instansen



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}