class Pessoa
{
    private string nome;
    private int idade;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("nome nao pode ser vazio");
            nome = value;
        }
    }

    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
                throw new ArgumentException("idade nao pode ser negativa");
            idade = value;
        }
    }
}
