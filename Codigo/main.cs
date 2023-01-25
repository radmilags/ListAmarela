using System;

class Program {
  public static void Main() {
      
    //Lista de categorias
    int idc = 0; idc++;
    
    Console.WriteLine("");
    Console.WriteLine("ListAmarela");
    Console.WriteLine("");
    
    
    
    int op = 0;
    while (op == 0) {
      Console.WriteLine("Escolha uma opção:");
      Console.WriteLine("[0] Sair");
      Console.WriteLine("[1] Visitar sistema");
      Console.WriteLine("[2] Login");
      Console.WriteLine("[3] Cadastrar cliente");
      Console.WriteLine("[4] Cadastrar prestador");
      if (c[2] == "") Console.WriteLine("[5] Cadastrar categoria");
      
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
        id++;
        Console.WriteLine("");
        Console.WriteLine("CADASTRO");
        Console.WriteLine("");

        Console.Write("Nome:");
        string nome = Console.ReadLine();
        
        Console.Write("Sobrenome:");
        string sobrenome = Console.ReadLine();
        
        Console.Write("Data de nascimento:");
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine()); // dd/mm/yyyy
        
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
        
        Cliente c = new Cliente(id, nome, sobrenome, dataNascimento, cpf, email, sexo, endereço, bairro, cidade, telefone, senha);
        break;
      }
    
      default: Console.WriteLine("Opção inválida"); break;
      }
    }
  }
}
