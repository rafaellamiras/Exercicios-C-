/*### 📦 Collections e Lambda

> **Objetivo:** praticar as principais estruturas de coleção do C# e expressões lambda utilizando dados estáticos.
> 

### 🔹 Exercício 01 — Lista de Cidades

Crie uma `List<string>` contendo o nome de **5 cidades brasileiras**.

Utilize `foreach` para percorrer a lista e imprimir cada cidade no console.

**Conceitos:** `List<T>` • `foreach` */

internal class Program
{
    public class Cidades
    {
        public string? Nome {get;set;}
    }
    
    private static void Main(string[] args)
    {
        List<Cidades> listaCidades = new List<Cidades>();

        Cidades cidade01 = new Cidades
        {
            Nome = "Belo Horizonte"
        };
        Cidades cidade02 = new Cidades
        {
            Nome = "Bauru"
        };
        Cidades cidade03 = new Cidades
        {
            Nome = "Jaú"
        };
        Cidades cidade04 = new Cidades
        {
            Nome = "Barra Bonita"
        };
        Cidades cidade05 = new Cidades
        {
            Nome = "Brotas"
        };

        listaCidades.Add(cidade01);
        listaCidades.Add(cidade02);
        listaCidades.Add(cidade03);
        listaCidades.Add(cidade04);
        listaCidades.Add(cidade05);

        Console.WriteLine("=== 5 CIDADES ===");

        foreach (var cidades in listaCidades)
        {
            Console.WriteLine($"{cidades.Nome}");
        }
    }
}