// Console.WriteLine("Hello, World!");

// int idade = 33;
// Console.WriteLine(idade);
// string nomePessoa = "Gabriel Moya";
// Console.WriteLine(nomePessoa);
// decimal valor = 200.99m;
// double valorDouble = 200.99;
// float valorFloat = 200.99f;
// Console.WriteLine(valor);
// Console.WriteLine(valorDouble);
// Console.WriteLine(valorFloat);
// var idadeNova = 34;
// char flag = 'Y';
// Console.WriteLine(flag);
// bool ativo = true;
// ativo = false;
// Console.WriteLine(ativo);


// const string descricao = "Curso CSHARP";
// // descricao = "Curso";
// Console.WriteLine(descricao);
/*
    Comentário
    multiline
*/

// int numero1 = 1;
// var numero2 = 2;
/*
var soma = numero1 + numero2;
Console.WriteLine(soma);

var subtracao = numero1 - numero2;
Console.WriteLine(subtracao);

var multiplicacao = (numero1 * numero2) * 10;
Console.WriteLine(multiplicacao);

var divisao = numero1 / numero2;
Console.WriteLine(divisao);
*/

// bool igual = numero1 == numero2;
// Console.WriteLine(igual);

// bool maior = numero2 > numero1;
// Console.WriteLine(maior);

// bool menor = numero2 < numero1;
// Console.WriteLine(menor);

// bool maiorOuIgual = numero2 >= numero1;
// Console.WriteLine(maiorOuIgual);

// bool menorOuIgual = numero2 <= numero1;
// Console.WriteLine(menorOuIgual);

// bool diferente = numero2 != numero1;
// Console.WriteLine(diferente);

// int numero1 = 1;
// var numero2 = 2;

// bool valido = numero2 > numero1 && 6 > 7;
// Console.WriteLine(valido);

// bool valido2 = numero2 > 10 || 6 > 7;
// Console.WriteLine(valido2);

// bool valido3 = !(numero2 > 3);
// Console.WriteLine(valido3);

// bool ativo = false;
// string status = ativo ? "Cadastro Ativo" : "Cadastro Inativo";
// Console.WriteLine(status);


// EscreverNome();


// void EscreverNome()
// {
//     var nome = NomeCompleto();
//     var soma = SomaValores();

//     Console.WriteLine(nome);
//     Console.WriteLine(soma);
// }

// string NomeCompleto()
// {
//     string primeiroNome = "Gabriel";
//     string segundoNome = "Moya";

//     return primeiroNome + " " + segundoNome;
// }

// int SomaValores()
// {
//     return 8 + 2;
// }

var soma = SomaValores(3, 5);
Console.WriteLine(soma);

var nome = NomeEIdade("Gabriel", 26);
Console.WriteLine(nome);

int SomaValores(int a, int b)
{
    return a + b;
}

string NomeEIdade(string nome, int idade)
{
    return "Meu nome é " + nome + " e tenho " + idade + " anos";
}
