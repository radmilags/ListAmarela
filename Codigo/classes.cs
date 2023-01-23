using System;

namespace Modelo {

  class Pessoa
  {
    private int id;
    private string nome;
    private string sobrenome;
    private DateTime dataNascimento;
    private string cpf;
    private string email;
    private string sexo;
    private string endereco;
    private string bairro;
    private string cidade;
    private string telefone;
    private string senha;

    // Construtor
    public Pessoa(int id, string nome, string sobrenome, DateTime dataNascimento, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, string senha)
    {
      this.id = id;
      this.nome = nome;
      this.sobrenome = sobrenome;
      this.dataNascimento = dataNascimento;
      this.cpf = cpf;
      this.email = email;
      this.sexo = sexo;
      this.endereco = endereco;
      this.bairro = bairro;
      this.cidade = cidade;
      this.telefone = telefone;
      this.senha = senha;
    }

    // Métodos de acesso get e set para cada atributo
    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Sobrenome { get => sobrenome; set => sobrenome = value; }
    public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    public string Cpf { get => cpf; set => cpf = value; }
    public string Email { get => email; set => email = value; }
    public string Sexo { get => sexo; set => sexo = value; }
    public string Endereco { get => endereco; set => endereco = value; }
    public string Bairro { get => bairro; set => bairro = value; }
    public string Cidade { get => cidade; set => cidade = value; }
    public string Telefone { get => telefone; set => telefone = value; }
    public string Senha { get => senha; set => senha = value; }
  }

  class Servico
    {
    private int id;
    private string nome;
    private double preco;
    private string descricao;
    private string categoria;

    // Construtor
    public Servico(int id, string nome, double preco, string descricao, string categoria)
    {
        this.id = id;
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }

    // Métodos de acesso get e set para cada atributo
    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public double Preco { get => preco; set => preco = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public string Categoria { get => categoria; set => categoria = value; }
  }

  class Categoria
  {
    private int id;
    private string nome;

    // Construtor
    public Categoria(int id, string nome)
    {
        this.id = id;
        this.nome = nome;
    }

    // Métodos de acesso get e set para cada atributo
    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
  }

  class Prestador {
    
  }
  
  class Contratante {
    
  }
  
  class Login {
    
  }
}