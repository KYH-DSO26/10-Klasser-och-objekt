public class Användare 
{ 
    // Egenskaper (properties) skyddar och kapslar in data på ett smidigt sätt
    public string Användarnamn {  get; set; }
    public string Epost { get; set; }
}


internal class Program
{
    private static void Main(string[] args)
    {
        var user = new Användare();
        user.Användarnamn = "kod_kungen";
        user.Epost = "king@code.se";

        Console.WriteLine($"Användare: {user.Användarnamn} ({user.Epost})");



        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}