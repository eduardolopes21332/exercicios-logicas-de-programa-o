// Exercício 01 — Par ou Ímpar
// Lê um número inteiro e informa se é par ou ímpar.
// Conceitos: entrada de dados, if/else, operador % (resto da divisão)

Console.Write("Digite um número inteiro: ");
if (int.TryParse(Console.ReadLine(), out int numero))
{
    if (numero % 2 == 0)
        Console.WriteLine($"{numero} é PAR.");
    else
        Console.WriteLine($"{numero} é ÍMPAR.");
}
else
{
    Console.WriteLine("Entrada inválida. Digite um número inteiro.");
}
