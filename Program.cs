// See https://aka.ms/new-console-template for more information
using System;

// - Aqui, definimos uma classe chamada "Programa". 
//  - É a classe principal da nossa aplicação.

// - Aqui cria um loop infinito, com a condição de ser verdade.
while (true)
{
    // - Aqui solicito os dados do usuario e faço as conversões nescessarias.

    Console.WriteLine("Digite o seu nome: ");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite a sua idade: ");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Digite a sua altura (em metros): ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Digite o seu peso (em quilogramas): ");
    double peso = Convert.ToDouble(Console.ReadLine());

    // - Aqui chamo a função - para realizar o calculo e armazeno  nas variaveis. 

    double imc = calcularIMC(peso, altura);
    string categoriaIMC = CategoriaIMC(imc);
    string faixaEtaria = FaixaEtaria(idade);

    // Aqui, chamamos a função "geraRelatorio" 
    // e passamos o nome, a idade, o IMC, a categoria do IMC e a faixa etária como parâmetros.

    gerarRelatorio(nome, idade, imc, categoriaIMC, faixaEtaria);

    // Aqui solicito se o usurio deseja gerar um novo relatóripo 

    Console.WriteLine("Deseja gerar um novo relatório para outra pessoa? (S/N): ");

    string resposta = Console.ReadLine();

    if (resposta != "S")
    {
        break;
    }
}
// Aqui chamamos a função já estabelicida, para realizar o calculo.
double calcularIMC(double peso, double altura)
{
    return peso / (altura * altura);
}
// Aqui chamamos a função já estabelicida, para definir a categoria do usuario.
string CategoriaIMC(double imc)
{
    if (imc < 18.5)
    {
        return "Abaixo do peso";
    }
    else if (imc < 24.9)
    {
        return "Normal";
    }
    else if (imc < 29.9)
    {
        return "Sobrepeso";
    }
    else
    {
        return "Obeso";
    }
}
// Aqui chamamos a função já estabelicida, para definir a faixa etaria do usuario.
string FaixaEtaria(int idade)
{
    if (idade < 13)
    {
        return "Criança";
    }
    else if (idade < 18)
    {
        return "Adolescente";
    }
    else if (idade < 60)
    {
        return "Adulto";
    }
    else
    {
        return "Idoso";
    }
}
// Aqui chamamos a função já estabelecida, para gerar o relatório 
//  este relatório irá imprimir todas as informações solicitadas.
void gerarRelatorio(string nome, int idade, double imc, string categoriaIMC, string faixaEtaria)
{
    Console.WriteLine("\nRelatório:");
    Console.WriteLine($"Nome: {nome}");
    Console.WriteLine($"Idade: {idade} anos");
    Console.WriteLine($"IMC: {imc:F2}");
    Console.WriteLine($"Categoria do IMC: {categoriaIMC}");
    Console.WriteLine($"Faixa etária: {faixaEtaria}");
}
