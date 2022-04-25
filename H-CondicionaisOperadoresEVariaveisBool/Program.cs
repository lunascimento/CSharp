int idade = 11;
//int qtdPessoa = 4;
// bool acompanhado = qtdPessoa >= 2; // Pode ser atribuir uma expressão
bool acompanhado = true;

if (idade >= 18 || acompanhado)
{
    Console.WriteLine("Acesso liberado!");
}
else
{
    Console.WriteLine("Acesso negado!");
}