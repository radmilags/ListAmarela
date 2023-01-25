using System;

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
  public string GetNome(){return this.nome;}
  public string GetSobrenome(){return this.sobrenome;}
  public DateTime GetdataNascimento(){return this.dataNascimento;}
  public string Getcpf(){return this.cpf;}
  public string Getemail(){return this.email;}
  public string Getsexo(){return this.sexo;}
  public string Getendereco(){return this.endereco;}
  public string Getbairro(){return this.bairro;}
  public string Getcidade(){return this.cidade;}
  public string Gettelefone(){return this.telefone;}
  public string Getsenha(){return this.senha;}

  //ToString

  public override string ToString(){return $"{this.nome} {this.sobrenome} - {this.telefone}";}
}

class Prestador{
    
}

class Program {
  public static void Main() {
    Console.WriteLine("");
    Console.WriteLine("ListAmarela");
    Console.WriteLine("");
    
    
    
    int op = 0;
    while (op == 0) {
      Console.WriteLine("Escolha uma opção:");
      Console.WriteLine("[1] Visitar sistema");
      Console.WriteLine("[2] Login");
      Console.WriteLine("[3] Cadastrar cliente");
      Console.WriteLine("[4] Cadastrar prestador");
      Console.WriteLine("[5] Cadastrar categoria");
      
      //ADICIONAR AS OUTRAS OPÇÕES (MUDAR DADOS, ACESSAR DADOS)
      //ONDE QUE FICA A PARTE DE SOLICITAR SERVICO? TEM QUE VER ISSO AI
      
      
      Console.WriteLine("");
      op = int.Parse(Console.ReadLine());
      int id = 0;
      switch (op) 
      {
      case 1: Console.WriteLine("[MOSTRAR DADOS DE CONTATO E CATEGORIAS]"); break;
      //MOSTRAR AS CATEGORIAS E DADOS DE CONTATO
      case 2: Console.WriteLine("[mostrando área de login]"); break;
      case 3: {
        Console.WriteLine("");
        Console.WriteLine("CADASTRO");
        Console.WriteLine("");

        Console.Write("Nome:");
        string nome = Console.ReadLine();
        
        Console.Write("Sobrenome:");
        string sobrenome = Console.ReadLine();
        
        Console.Write("Data de nascimento:");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine()); // yyyy-MM-dd
        
        Console.Write("CPF:");
        string cpf = Console.ReadLine();

        Console.Write("E-mail para contato:");
        string email = Console.ReadLine();

        Console.Write("Sexo: (M ou F)");
        string sexo = Console.ReadLine();

        Console.Write("Endereço:");
        string endereço = Console.ReadLine();

        Console.Write("Bairro:");
        string bairro = Console.ReadLine();

        Console.Write("Cidade:");
        string cidade = Console.ReadLine();

        Console.Write("Telefone para contato:");
        string telefone = Console.ReadLine();

        Console.Write("Informe uma senha:");
        string senha = Console.ReadLine();
        
        Pessoa p = new Pessoa(id, nome, sobrenome, dataNascimento, cpf, email, sexo, endereço, bairro, cidade, telefone, senha);
        id++;
        break;
      }
      default: Console.WriteLine("Opção inválida"); break;
      }
    }
  }
}
