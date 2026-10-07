class Item
{
    public string Namn { get; set; }
    public Item(string namn)
    {
        Namn = namn;
    }
}
class Inventory
{
    private List<Item> _items = new List<Item>();
    private int _maxKapacitet;
    public Inventory(int maxKapacitet)
    {
        _maxKapacitet = maxKapacitet;
    }
    public bool AddItem(Item i)
    {
        if (_items.Count >= _maxKapacitet)
        {
            Console.WriteLine($"Kunde inte plocka upp '{i.Namn}' - Ryggsäcken är full!");
            return false;
        }
        _items.Add(i);
        Console.WriteLine($"Du plockade upp: {i.Namn}");
        return true;
    }
    public void ShowItems()
    {
        Console.WriteLine($"--- RYGGSÄCK ({_items.Count}/{_maxKapacitet}) ---");
        if (_items.Count == 0) Console.WriteLine("Tom");

        foreach (var item in _items)
        {
            Console.WriteLine($"- {item.Namn}");
        }
    }
}
internal class Program
{
    static void Main()
    {
        Inventory ryggsack = new Inventory(3);
        ryggsack.AddItem(new Item("Svärd"));
        ryggsack.AddItem(new Item("Hälsobrygd"));
        ryggsack.AddItem(new Item("Sköld"));
        ryggsack.AddItem(new Item("Guldring")); // Denna bör nekas!

        ryggsack.ShowItems();





        Console.Write("\n\nTryck på en tangent för att stänga fönstret...");
        Console.ReadKey();
    }
}
