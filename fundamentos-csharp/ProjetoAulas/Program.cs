// Console.WriteLine("Primeiro programa");

using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            // AulaClasses();
            // AulaPropriedadeSomenteLeitura();
            AulaHeranca();
        }

        private static void AulaHeranca()
        {
            // var pessoaFisica = new Cadastro.PessoaFisica();
            // pessoaFisica.Id = 1;
            // pessoaFisica.Endereco = "Endereco Teste";
            // pessoaFisica.Cidade = "Cidade teste";
            // pessoaFisica.Cep = "12345612";
            // pessoaFisica.CPF = "12345678912";

            // pessoaFisica.ImprimirDados();
            // pessoaFisica.ImprimirCpf();

            var funcionario = new Cadastro.Funcionario();
            funcionario.Id = 10;
            funcionario.Endereco = "Endereco Teste";
            funcionario.Cidade = "Cidade teste";
            funcionario.Cep = "12345612";
            funcionario.CPF = "12345678912";

            funcionario.ImprimirDados();
            funcionario.ImprimirCpf();
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

        private static void AulaPropriedadeSomenteLeitura()
        {
            var produto = new Cadastro.Produto();
            produto.Descricao = "Mouse";
            // produto.Estoque = 1;
            Console.WriteLine(produto.Estoque);
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
