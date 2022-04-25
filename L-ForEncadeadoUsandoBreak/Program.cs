Console.WriteLine("Executando o Projeto 11 - Usando IF");

for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
    {
        Console.Write("*");
        if (contadorColuna == contadorLinha)
            break;
    }
    Console.WriteLine("");
}

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Executando o Projeto 11 - Condicional dentro do For");
for (int contadorLinha = 0; contadorLinha < 10; contadorLinha++)
{
    for (int contadorColuna = 0; contadorColuna <= contadorLinha; contadorColuna++)
    {
        Console.Write("*");
        if (contadorColuna == contadorLinha)
            break;
    }
    Console.WriteLine("");
}
