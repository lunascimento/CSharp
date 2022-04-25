int idade = 12;
int qtdPessoa = 0;

if (idade >= 18)
{
    Console.WriteLine("Acesso liberado! Usuário possui mais de 18 anos");
} 
else
{
    if (qtdPessoa >= 2)
    {
        Console.WriteLine("Acesso liberado! Usuário está acompanhado");
    }
    else
    {
        Console.WriteLine("Acesso negado! Usuário não possui mais de 18 anos");
    }
}

