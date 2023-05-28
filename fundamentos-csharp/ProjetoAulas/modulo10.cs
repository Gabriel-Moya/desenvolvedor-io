namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

    public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

    public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informação: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(0, 7));
        Console.WriteLine(linha.Substring(8));
    }

    public void AulaRange()
    {
        string nomeArquivo = "2023_05_28_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);

        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }
}
