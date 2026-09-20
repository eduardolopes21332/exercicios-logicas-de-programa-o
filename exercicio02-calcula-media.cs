// Exercício 02 — Calculadora de Média
// Lê 3 notas, calcula a média e informa aprovação (>= 6).
// Conceitos: for, acumulador, validação com TryParse, média aritmética

double soma = 0;

for (int i = 1; i <= 3; i++)
{
    Console.Write($"Digite a nota {i}: ");
    if (double.TryParse(Console.ReadLine(), out double nota))
    {
        soma += nota;
    }
    else
    {
        Console.WriteLine("Nota inválida, digite novamente.");
        i--; // repete a mesma nota
    }
}

double media = soma / 3;
Console.WriteLine($"Média final: {media:F1}");
Console.WriteLine(media >= 6 ? "Situação: APROVADO ✅" : "Situação: REPROVADO ❌");
