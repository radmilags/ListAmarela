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
    if(bariro != "") this.bairro = bairro;
    if(cidade!="") this.cidade = cidade;
    if(telefone!="") this.telefone = telefone;
    if(senha!="") this.senha = senha;
  }
}
