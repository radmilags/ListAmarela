using System;

class Pessoa{
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
  public Pessoa(int id, string nome, string sobrenome, DateTime dataNascimento, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, string senha){
    if(nome != "") this.nome = nome;
    if(sobrenome != "") this.sobrenome = sobrenome;
    this.dataNascimento = dataNascimento;
    if(cpf != "") this.cpf = cpf;
    if(email != "") this.email = email;
    if(sexo != "") this.sexo = sexo;
    if(endereco != "") this.endereco = endereco;
    if(bairro != "") this.bairro = bairro;
    if(cidade!="") this.cidade = cidade;
    if(telefone!="") this.telefone = telefone;
    if(senha!="") this.senha = senha;
  }
  
  // Criar metodos get para receber o valor do atributos
  
  
  /*class Pessoa
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
  }*/
}
