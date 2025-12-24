public class Cliente {
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Cpf { get; set; }
    public string Email { get; set; }
    public string Sexo { get; set; }
    public string Endereco { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Telefone { get; set; }
    public string Senha { get; set; }

    public Cliente() { }

    public Cliente(int id, string nome, string sobrenome, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, string senha)
    {
        this.Id = id;
        this.Nome = nome;
        this.Sobrenome = sobrenome;
        this.Cpf = cpf;
        this.Email = email;
        this.Sexo = sexo;
        this.Endereco = endereco;
        this.Bairro = bairro;
        this.Cidade = cidade;
        this.Telefone = telefone;
        this.Senha = senha;
    }

    public override string ToString() { return $"Nome: {this.Nome} {this.Sobrenome} - Telefone: {this.Telefone}"; }
}