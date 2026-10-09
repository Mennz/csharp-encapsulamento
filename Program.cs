Pessoa pessoa = new Pessoa();
pessoa.Nome = "Maria";
pessoa.Idade = 28;

Console.WriteLine($"{pessoa.Nome}, {pessoa.Idade} anos");

try
{
    pessoa.Idade = -5;
}
catch (ArgumentException erro)
{
    Console.WriteLine($"Erro ao mudar idade: {erro.Message}");
}

try
{
    pessoa.Nome = "   ";
}
catch (ArgumentException erro)
{
    Console.WriteLine($"Erro ao mudar nome: {erro.Message}");
}

Console.WriteLine($"depois das tentativas invalidas: {pessoa.Nome}, {pessoa.Idade} anos");
