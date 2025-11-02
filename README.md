# Builder

Ідея будівельника: 

покроково створювати складний об’єкт (наприклад, великий букет).

Як працює код: 

є “будівельник”, який по черзі додає частини — квіти, упаковку, стрічку, картку.

Навіщо: 

дозволяє збирати різні варіанти об’єктів з одних і тих самих деталей.

## Код
```csharp
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
```
## Результат
![Результат виконання](sc3.png)
