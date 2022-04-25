// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando projeto 9 - Calcula rendimento poupança");

double valorInvestido = 1000;
int contadorMes = 1;

while (contadorMes <= 12)
{
    valorInvestido = valorInvestido + valorInvestido * 0.0036; // 0.0036 equivale a 0.36%
    Console.WriteLine($"Após o mês {contadorMes} você terá R$: {valorInvestido}");
    contadorMes++;
}
