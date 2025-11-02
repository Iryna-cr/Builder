using System;

class Bouquet
{
    public string Flowers;
    public string Wrapper;
    public string Ribbon;

    public void Show() => Console.WriteLine($"{Flowers}, {Wrapper}, {Ribbon}");
}

class BouquetBuilder
{
    private Bouquet b = new Bouquet();

    public void AddFlowers() => b.Flowers = "Троянди ";
    public void AddWrapper() => b.Wrapper = "Паперове пакування ";
    public void AddRibbon() => b.Ribbon = "Червона стрічка ";
    public Bouquet GetBouquet() => b;
}

class Program
{
    static void Main()
    {
        var builder = new BouquetBuilder();
        builder.AddFlowers();
        builder.AddWrapper();
        builder.AddRibbon();

        var bouquet = builder.GetBouquet();
        bouquet.Show();
    }
}





