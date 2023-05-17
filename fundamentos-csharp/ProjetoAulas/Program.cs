// Console.WriteLine("Primeiro programa");

using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            AulaClasses();            
        }

        private static void AulaClasses()
        {
            var resultado = Cadastro.Calculos.SomarNumeros(2, 3);
            Console.WriteLine(resultado);

            // var produto = new Cadastro.Produto();
            // produto.SetId(1);
            // produto.Descricao = "Teclado";

            // produto.ImprimirDescricao();
            // Console.WriteLine(produto.GetId());
        }
    }
}

/*
namespace Cadastro
{
    public class Cliente
    {
    }

    public class Funcionario
    {
    }
}

namespace Financeiro
{
    public class ContasReceber
    {
    }

    public class Funcionario
    {
    }
}
*/
