
// See https://aka.ms/new-console-template for more information

//Console.Clear();
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Turma13");

using ProgBackEnd.Classes;

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Adriano";
novaPf.cpf = "12345678975";

Console.WriteLine(novaPf.nome);
Console.WriteLine(novaPf.cpf);
Console.WriteLine("--------------------------------------");


// interpolacao
Console.WriteLine($"Bem Vindo {novaPf.nome}, seu Cpf é: {novaPf.cpf} !!! Sextou !!! ");
Console.WriteLine($"--------------------------------------");


//concatenacao
Console.WriteLine("Bem Vindo" +novaPf.nome+ ", seu CPF é" +novaPf.cpf+ "!!!" );
Console.WriteLine($"--------------------------------------");







