/*
 * Detta är ett avancerat men otroligt spännande mönster. 
 * Det visar hur man med hjälp av åtkomstmodifierare (private) och statiska metoder kan 
 * kontrollera exakt hur objekt skapas.
 */

class Anvandare
{
    public string Namn { get; set; }
    public string Roll { get; set; }

    // PRIVAT konstruktor - förhindrar 'new Anvandare()' utifrån
    private Anvandare(string namn, string roll)
    {
        Namn = namn; 
        Roll = roll;
    }

    // Statisk fabriksmetod för Admins
    public static Anvandare SkapaAdmin(string namn)
    {
        return new Anvandare(namn, "Administrator");
    }

    // Statisk fabriksmetod för Standardanvändare
    public static Anvandare SkapaStandardAnvandare(string namn)
    {
        return new Anvandare(namn, "Standard");
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        // Användarna skapas via de statiska fabriksmetoderna istället för 'new'
        Anvandare admin = Anvandare.SkapaAdmin("Chef-Olof"); 
        Anvandare user = Anvandare.SkapaStandardAnvandare("Kalle"); 
        
        Console.WriteLine($"Användare: {admin.Namn}, Roll: {admin.Roll}"); 
        Console.WriteLine($"Användare: {user.Namn}, Roll: {user.Roll}");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
