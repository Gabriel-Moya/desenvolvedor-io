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

// var soma = SomaValores(3, 5);
// Console.WriteLine(soma);

// var nome = NomeEIdade("Gabriel", 26);
// Console.WriteLine(nome);

// int SomaValores(int a, int b)
// {
//     return a + b;
// }

// string NomeEIdade(string nome, int idade)
// {
//     return "Meu nome é " + nome + " e tenho " + idade + " anos";
// }


// using System.Collections;

// var arrayList = new ArrayList();
// arrayList.Add(1);
// arrayList.Add("Gabriel");
// arrayList.Add(true);

// // Console.WriteLine(arrayList[1]);

// arrayList.RemoveAt(1);

// arrayList.Clear();

// foreach (var item in arrayList)
// {
//     Console.WriteLine(item);
// }


// var arrayTipadoNumero = new int[3] { 1, 2, 3 };
// var arrayTipadoNumero = new int[3];

// arrayTipadoNumero[0] = 5;
// arrayTipadoNumero[1] = 5;
// arrayTipadoNumero[2] = 10;

// Array.Resize(ref arrayTipadoNumero, 100);
// arrayTipadoNumero[10] = 100;

// foreach (var item in arrayTipadoNumero)
// {
//     Console.WriteLine(item);
// }

// var arrayTipadoString = new string[2] { "Gabriel", "Moya" };
// var arrayTipadoString = new string[2];
// arrayTipadoString[0] = "Gabriel";
// arrayTipadoString[1] = "Moya";

// foreach (var item in arrayTipadoString)
// {
//     Console.WriteLine(item);
// }


// var lista = new List<string>(10)
// {
//     "Gabriel",
//     "Moya",
// };
// lista.Add("Gabriel");
// lista.Add("Moya");
// lista.Add("Curso");

// var nome = lista[0];
// Console.WriteLine(nome);

// lista.RemoveAt(1);
// foreach (var item in lista)
// {
//     Console.WriteLine(item);
// }


// var dicionario = new Dictionary<string, string>()
// {
//     { "teste", "Teste" },
//     { "teste6", "teste 6" }
// };
// dicionario.Add("nome", "Gabriel");

// dicionario["curso"] = "Curso";

// var nome = dicionario["curso"];
// // Console.WriteLine(nome);

// foreach (var item in dicionario)
// {
//     Console.WriteLine($"Key: {item.Key}");
//     Console.WriteLine($"Value: {item.Value}");
// }


// var queue = new Queue<string>();
// queue.Enqueue("Gabriel");
// queue.Enqueue("Moya");

// var nome = queue.Peek();
// var nome1 = queue.Peek();

// var nome = queue.Dequeue();
// var nome1 = queue.Dequeue();

// Console.WriteLine(nome);
// Console.WriteLine(nome1);

// foreach (var item in queue)
// {
//     Console.WriteLine(item);
// }



// var stack = new Stack<string>();
// stack.Push("Gabriel");
// stack.Push("Moya");

// var nome = stack.Pop();
// var nome1 = stack.Pop();
// Console.WriteLine(nome);
// Console.WriteLine(nome1);

// foreach (var item in stack)
// {
//     Console.WriteLine(item);
// }

// MODULO 7 - Aula 1
// var diaDaSemana = 0;
// var diaDeTrabalho = false;

// if (diaDaSemana == 0 && diaDeTrabalho == true)
// {
//     Console.WriteLine("Hoje é domingo");
// }
// else if (diaDaSemana == 0 && diaDeTrabalho == false)
// {
//     Console.WriteLine("Hoje é domingo, mas não é dia de trabalho");
// }
// else
// {
//     Console.WriteLine("Hoje não é domingo");
// }

// var diaDaSemana = 10;
// if (diaDaSemana == 0)
// {
//     Console.WriteLine("Hoje é domingo");
// }
// else if (diaDaSemana == 1)
// {
//     Console.WriteLine("Hoje é segunda");
// }
// else if (diaDaSemana == 2)
// {
//     Console.WriteLine("Hoje é terça");
// }
// else if (diaDaSemana == 3)
// {
//     Console.WriteLine("Hoje é quarta");
// }
// else if (diaDaSemana == 4)
// {
//     Console.WriteLine("Hoje é quinta");
// }
// else if (diaDaSemana == 5)
// {
//     Console.WriteLine("Hoje é sexta");
// }
// else if (diaDaSemana == 6)
// {
//     Console.WriteLine("Hoje é sábado");
// }
// else
// {
//     Console.WriteLine("Dia da semana inválido");
// }

// MODULO 7 - Aula 2
// var diaDaSemana = 3;
// switch (diaDaSemana)
// {
//     case 0:
//         Console.WriteLine("Hoje é domingo");
//         break;
//     case 1:
//         Console.WriteLine("Hoje é segunda");
//         break;
//     case 2:
//         Console.WriteLine("Hoje é terça");
//         break;
//     case 3:
//         Console.WriteLine("Hoje é quarta");
//         break;
//     case 4:
//         Console.WriteLine("Hoje é quinta");
//         break;
//     case 5:
//         Console.WriteLine("Hoje é sexta");
//         break;
//     case 6:
//         Console.WriteLine("Hoje é sábado");
//         break;
//     default:
//         Console.WriteLine("Dia da semana inválido");
//         break;
// }

var diaDaSemana = 0;
if (diaDaSemana < 1)
{
        Console.WriteLine("Hoje é domingo");
}
else
{
    Console.WriteLine("Dia da semana inválido");
}
