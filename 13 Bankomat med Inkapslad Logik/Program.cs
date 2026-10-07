class Bankkonto
{
    private double _saldo; // Strikt dolt utifrån
    public Bankkonto(double startSaldo)
    {
        if (startSaldo >= 0) _saldo = startSaldo;
    }
    public double VisaSaldo() // Publik läsmetod istället för property
    {
        return _saldo;
    }
    public void SattIn(double belopp)
    {
        if (belopp > 0)
        {
            _saldo += belopp;
            Console.WriteLine($"Insättning lyckades. Nytt saldo: {_saldo} kr");
        }
        else
        {
            Console.WriteLine("Fel: Insättningsbeloppet måste vara positivt!");
        }
    }
    public void TaUt(double belopp)
    {
        if (belopp <= 0)
        {
            Console.WriteLine("Fel: Uttagsbeloppet måste vara positivt!");
        }
        else if (belopp > _saldo)
        {
            Console.WriteLine("Fel: Medel saknas på kontot!");
        }
        else
        {
            _saldo -= belopp;
            Console.WriteLine($"Uttag lyckades. Nytt saldo: {_saldo} kr");
        }
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Bankkonto konto = new Bankkonto(500);
        konto.SattIn(200);
        konto.TaUt(1000); // Ska misslyckas 
        konto.TaUt(300); // Ska lyckas




        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
