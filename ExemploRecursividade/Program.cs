using ExemploRecursividade;

Console.WriteLine("=== multiplicacao ===");

for (int i = 0; i < 11; i++)
{
    int result = Multipl.MultiplicacaoPorSoma(5, i);
    Console.WriteLine(string.Format("5 * {0} = {1}", i, result));
}

Console.WriteLine("\n\n=== fatorial ===\n");

for (int i = 0; i < 11; i++)
{
    int result = Fatorial.CalculaFatorial(i);
    Console.WriteLine(string.Format("{0}! = {1}", i, result));
}

Console.WriteLine("\n\n=== MCD ===\n");

for (int i = 55; i <= 102; i = i + 5)
{
    int result = Mdc.CalculaMdc(50, i);
    Console.WriteLine(string.Format("MDC de 50 e {0} = {1}", i, result));
}