namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        // string nomeCompleto = "GABRIEL MOYA";
        
        // Func<char, bool> filtro = c => c == 'A';
        // var resultado = nomeCompleto.Where(x => x == 'A');
        // var resultado = nomeCompleto.Where(filtro);

        // var resultado = from c in nomeCompleto where c == 'E' select c;
        
        // foreach (var letra in resultado)
        // {
        //     Console.WriteLine(letra);
        // }

        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };
        var resultado = numeros.Where(p => p >= 10);
        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

    public void AulaOrdenacao()
    {
        // var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

        var nomes = new string[] { "Gabriel", "Rafael", "Eduardo", "Bruno" };
        // var resultado = numeros.OrderByDescending(x => x);
        var resultado = nomes.OrderBy(x => x);

        foreach (var nome in resultado)
        {
            Console.WriteLine(nome);
        }
    }

    public void AulaTake()
    {
        var numeros = new int[] { 10, 6, 5, 50, 15, 2 };

        var resultado = numeros.Where(x => x > 10).Take(3).OrderBy(x => x);

        foreach (var numero in resultado)
        {
            Console.WriteLine(numero);
        }
    }

}