
// See https://aka.ms/new-console-template for more information

//Console.Clear();
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Turma13");

using ProgBackEnd.Classes;

PessoaFisica novaPf = new PessoaFisica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPf = new Endereco();

novaPf.nome = "Adriano";
novaPf.cpf = "12345678975";
novaPf.rendimento = 7000.5f;
novaPf.dataNasc = new DateTime(1979,01,01);

// Console.WriteLine($"Pessoa Fisica ===================");
// float resultado = novaPf.CalcularImposto(novaPf.rendimento);
// Console.WriteLine(resultado);
// Console.WriteLine($"Validação de Datas ===================");
// DateTime temp = new DateTime(2000,01,01);
// //Console.WriteLine(novaPf.ValidarDataNasc(temp));
// Console.WriteLine(novaPf.ValidarDataNasc("2004/12/08"));

novoEndPf.logradouro = "Rua Niteroi";
novoEndPf.numero = 180;
novoEndPf.complemento = "Predio";
novoEndPf.endComercial = true;

novaPf.endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, Num: {novaPf.endereco.numero}
Maior de Idade: {novaPf.ValidarDataNasc(novaPf.dataNasc)}
");

//Console.WriteLine(novaPf.nome);
//Console.WriteLine(novaPf.cpf);
//Console.WriteLine("--------------------------------------");


// interpolacao
//Console.WriteLine($"Bem Vindo {novaPf.nome}, seu Cpf é: {novaPf.cpf} !!! Sextou !!! ");
//Console.WriteLine($"--------------------------------------");


//concatenacao
//Console.WriteLine("Bem Vindo " +novaPf.nome+ ", seu CPF é " +novaPf.cpf+ "!!!" );
//Console.WriteLine($"--------------------------------------");

// Console.WriteLine($"Pessoa Juridica ===================");


// float impostoPagar = novaPj.CalcularImposto(12000.5f);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine($"{impostoPagar.ToString("C")}");









