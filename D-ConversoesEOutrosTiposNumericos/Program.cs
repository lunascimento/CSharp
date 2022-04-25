// See https://aka.ms/new-console-template for more information
Console.WriteLine("Executando o Projeto 4");

double salario = 1200.50;
Console.WriteLine("Salário usando uma variável Double: " + salario);
Console.WriteLine($"Salário usando uma variável Double: {salario}"); // Interpolação de string (Mais elegante)

// Variáveis Int ocupam 32 bits
int salarioConvertidoInteiro = (int)salario;
Console.WriteLine("Salário usando uma variável Int (Perdendo a precisão): " + salarioConvertidoInteiro);

//Variáveis Long ocupam 64 bits
long idadeUniverso = 1300000000000;
Console.WriteLine("Idade universo usando uma variável Long (valores longos): " + idadeUniverso);

//Variáveis Short ocupam 16 bits
short qtdEstoque = 150;
Console.WriteLine("Estoque usando uma variável Short (valores curtos): " + qtdEstoque);

float altura = 1.84f;
Console.WriteLine("Altura usando uma variável Float (também aceita decimais, porém com uma precisão menor) - Menos usual: " + altura);

