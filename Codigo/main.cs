using System;
using Modelo;

class Program {
  public static void Main() {
    Console.WriteLine("");
    Console.WriteLine("ListAmarela");
    Console.WriteLine("");
    int op = 0;
    while (op == 0) {
      Console.WriteLine("Escolha uma opção:");
      Console.WriteLine("[1] ~ Visitar sistema");
      Console.WriteLine("[2] ~ Login");
      Console.WriteLine("[3] ~ Cadastrar");
      Console.WriteLine("");
      op = int.Parse(Console.ReadLine());
      int id = 0;
      switch (op) 
      {
      case 1: Console.WriteLine("[mostrando categorias]"); break;
      case 2: Console.WriteLine("[mostrando área de login]"); break;
      case 3: {
        Console.WriteLine("");
        Console.WriteLine("CADASTRO");
        Console.WriteLine("");

        id += 1;
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Sobrenome: ");
        string sobrenome = Console.ReadLine();
        
        Console.Write("Data de nascimento: ");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine()); // yyyy-MM-dd
        
        Console.Write("CPF: ");
        string cpf = Console.ReadLine();

        Console.Write("E-mail para contato: ");
        string email = Console.ReadLine();

        Console.Write("Sexo: ");
        string sexo = Console.ReadLine();

        Console.Write("Endereço: ");
        string endereço = Console.ReadLine();

        Console.Write("Bairro: ");
        string bairro = Console.ReadLine();

        Console.Write("Cidade: ");
        string cidade = Console.ReadLine();

        Console.Write("Telefone para contato: ");
        string telefone = Console.ReadLine();

        Console.Write("Informe uma senha: ");
        string senha = Console.ReadLine();
        
        Pessoa pessoa = new Pessoa(id, nome, sobrenome, dataNascimento, cpf, email, sexo, endereço, bairro, cidade, telefone, senha);
        
        break;
      }
      default: Console.WriteLine("Opção inválida"); break;
      }
    }
  }
}