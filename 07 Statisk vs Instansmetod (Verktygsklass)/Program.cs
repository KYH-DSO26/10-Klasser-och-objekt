public class TextVerktyg
{
    // Statisk metod - tillhör KLASSEN, inte ett specifikt objekt
    public static string RensaText(string indata)
    {
        return indata.Trim().ToLower();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        string smutsigText = "      HeJ PÅ DIg!     ";

        // Vi behöver INTE skriva 'new TextVerktyg()' tack vare 'static'
        string renText = TextVerktyg.RensaText(smutsigText);

        Console.WriteLine($"Före: {smutsigText}");
        Console.WriteLine($"Efter: {renText}");




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
