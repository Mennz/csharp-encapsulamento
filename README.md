# Encapsulamento em C#

Classe `Pessoa` com campos privados (`nome` e `idade`), expostos por propriedades
`Nome` e `Idade` com `get`/`set`. Os setters validam os valores antes de aceitar:
idade não pode ser negativa e nome não pode ser vazio ou só espaço.

## O que pratiquei

- Diferença entre campo privado e propriedade pública
- Validação dentro do `set` lançando `ArgumentException`
- Capturar a exceção com `try/catch` pra mostrar o erro sem quebrar o programa

## Como rodar

```
dotnet run
```

O `Program.cs` cria uma pessoa válida, imprime os dados, e depois tenta colocar
uma idade negativa e um nome vazio pra mostrar a validação funcionando.
