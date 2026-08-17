/*
### Exercício 03 — Dictionary de Produtos

Crie um `Dictionary<int, string>` representando um **cardápio de lanchonete**.

- A chave deve representar o **código do produto**;
- O valor deve representar o **nome do produto**;
- Cadastre pelo menos **4 produtos**.

Utilize `foreach` para imprimir os produtos no seguinte formato:

```
Código - Nome
```
**Conceitos:** `Dictionary<TKey,TValue>` • `Key` • `Value` • `foreach`*/

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, string> cardapio = new Dictionary<int, string>();

        cardapio.Add(1, "X-Bacon");
        cardapio.Add(2, "Cachorro Quente");
        cardapio.Add(3, "Batata Frita");
        cardapio.Add(4, "X-Salada");

        Console.WriteLine("-CARDÁPIO-");
        Console.WriteLine();

        foreach (var produto in cardapio)
        {
            Console.WriteLine($"{produto.Key} - {produto.Value}");
        }
    }
}