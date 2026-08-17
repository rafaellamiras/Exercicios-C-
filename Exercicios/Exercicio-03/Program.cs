/*### Exercício 02 — Manipulação de List

Crie uma `List<int>` com os valores:

```csharp
{ 10, 25, 8, 42, 15, 30 }
```

Realize as seguintes operações:

1. Insira o número `100` na posição `2`;
2. Remova o elemento que está na última posição;
3. Imprima a lista final.

**Conceitos:** `List<T>` • `Insert()` • `RemoveAt()` • `Count`*/

using System.Xml;

internal class Program
{

    public class Numero
    {
        public int Num {get;set;}
    }
    private static void Main(string[] args)
    {
        List<Numero> listaNumero = new List<Numero>();

        Numero num1 = new Numero
        {
            Num = 10
        };
        Numero num2 = new Numero
        {
            Num = 25
        };
        Numero num3 = new Numero
        {
            Num = 8
        };
        Numero num4 = new Numero
        {
            Num = 42
        };
        Numero num5 = new Numero
        {
            Num = 15
        };
        Numero num6 = new Numero
        {
            Num = 30
        };

        listaNumero.Add(num1);
        listaNumero.Add(num2);
        listaNumero.Add(num3);
        listaNumero.Add(num4);
        listaNumero.Add(num5);
        listaNumero.Add(num6);

        Console.WriteLine("-LISTA-");

        foreach (var numero in listaNumero)
{
    Console.WriteLine(numero.Num);
}

Console.WriteLine();
Console.WriteLine("-ALTERANDO VALOR-");

listaNumero[2].Num = 100;
 foreach (var numero in listaNumero)
{
    Console.WriteLine(numero.Num);
}


Console.WriteLine("-REMOVENDO-");


listaNumero.Remove(num6);
 foreach (var numero in listaNumero)
{
    Console.WriteLine(numero.Num);
}

    }
}
