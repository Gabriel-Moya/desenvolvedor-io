﻿// Console.WriteLine("Primeiro programa");

using System;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            // AulaClasses();
            // AulaPropriedadeSomenteLeitura();
            // AulaHeranca();
            // AulaClasseSelada();
            // AulaClasseAbstrata();
            AulaRecord();
        }

        private static void AulaRecord()
        {
            // var curso1 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };
            // var curso2 = new Cadastro.Curso { Id = 1, Descricao = "Curso" };

            var curso1 = new Cadastro.Curso(1, "Curso");
            var curso2 = curso1 with { Descricao = "Teste novo" };

            // var curso1 = new Cadastro.CursoTeste { Id = 1, Descricao = "Curso" };
            // var curso2 = curso1;
            // curso2.Descricao = "Teste teste";
            // var curso2 = new Cadastro.CursoTeste();
            // curso2.Id = curso1.Id;
            // curso2.Descricao = "Nova Descricao";
            
            Console.WriteLine(curso1.Descricao);
            Console.WriteLine(curso2.Descricao);

            // Console.WriteLine(curso1.Equals(curso2));
            // Console.WriteLine(curso1 == curso2);
        }

        private static void AulaClasseAbstrata()
        {
            var cachorro = new Cadastro.Cachorro();
            cachorro.Nome = "Dog";
            cachorro.ImprimirDados();
        }

        private static void AulaClasseSelada()
        {
            // var configuracao = new Cadastro.Configuracao();
            // configuracao.Host = "localhost";

            var configuracao = new Cadastro.Configuracao
            {
                Host = "localhost"
            };

            Console.WriteLine(configuracao.Host);
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
