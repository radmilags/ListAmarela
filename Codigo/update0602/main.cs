using System;

class Program
{
    public static void Main()
    {
      int idcliente = 0; int idcategor = 7; int idprestador = 0;
      Console.WriteLine("");
      Console.WriteLine("ListAmarela");
      Console.WriteLine("");
      Cliente[] c = new Cliente[3];
      Categoria[] categor = new Categoria[8];
      categor[0] = new Categoria(1, "Eletricista");
      categor[1] = new Categoria(2, "Diarista/Folgista");
      categor[2] = new Categoria(3, "Encanador");
      categor[3] = new Categoria(4, "Pintura");
      categor[4] = new Categoria(5, "Lavaderia");
      categor[5] = new Categoria(6, "Frete");
      categor[6] = new Categoria(7, "Gesso");
      Prestador[] prest = new Prestador[3];
      int op = -1;
      while (op != 0)
      {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("[0] Sair");
        Console.WriteLine("[1] Visitar sistema");
        Console.WriteLine("[2] Mostrar dados");
        Console.WriteLine("[3] Cadastrar cliente");
        Console.WriteLine("[4] Cadastrar Prestador");
        Console.WriteLine("[5] Cadastrar categoria");
        Console.WriteLine("");

        op = int.Parse(Console.ReadLine());
        switch (op)
        {
          case 0: break;
          case 1:
          {
            Console.WriteLine("telefone = 400028922");
            for (int i = 0; i < idcategor; i++)
            {
              Console.WriteLine(categor[i].ToString());
            }
            Console.WriteLine("");
            
            break;
          }
          case 2:
            Console.WriteLine("");
            Console.Write("Cliente [1] ou prestador [2] : ");
            int x = int.Parse(Console.ReadLine());
            if(x == 1){
              Console.WriteLine("");
              Console.Write("Selecione o id do usuario: ");
              int y = int.Parse(Console.ReadLine());
              Console.WriteLine(c[y-1].ToString());
            }
            else{
                Console.WriteLine("");
                Console.WriteLine("Selecione o id do usuario");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine(prest[y-1].ToString());
            }
            Console.WriteLine("");
            
          break;

          
          case 3:
            {
              Console.WriteLine("");
              Console.WriteLine("CADASTRO");
              Console.WriteLine("");

              Console.Write("Nome: ");
              string nome = Console.ReadLine();
      
              Console.Write("Sobrenome: ");
              string sobrenome = Console.ReadLine();
      
              // Console.Write("Data de nascimento [yyyy-MM-dd]: ");
              // DateTime dataNascimento = DateTime.Parse(Console.ReadLine()); // yyyy-MM-dd
      
              Console.Write("CPF: ");
              string cpf = Console.ReadLine();
      
              Console.Write("E-mail para contato: ");
              string email = Console.ReadLine();
      
              Console.Write("Sexo: ");
              string sexo = Console.ReadLine();
      
              Console.Write("Endereço: ");
              string endereco = Console.ReadLine();
      
              Console.Write("Bairro: ");
              string bairro = Console.ReadLine();
      
              Console.Write("Cidade: ");
              string cidade = Console.ReadLine();
      
              Console.Write("Telefone para contato: ");
              string telefone = Console.ReadLine();
      
              Console.Write("Informe uma senha: ");
              string senha = Console.ReadLine();
              //id, nome, sobrenome, cpf, email, sexo,  endereco, bairro, cidade, telefone, Categoria, senha
  
              c[idcliente] = new Cliente(idcliente + 1, nome, sobrenome, cpf, email, sexo, endereco, bairro, cidade, telefone, senha);
              // c[idcliente] = new Cliente(idcliente + 1, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", "senha123");
              idcliente++;
              Console.WriteLine("");
              
              break;
            }
          case 4:
          {
            Console.WriteLine("");
            Console.WriteLine("CADASTRAR PRESTADOR");
            Console.WriteLine("");
            Console.WriteLine("Escolha o número categoria");
            Console.WriteLine("");
            
            for (int i = 0; i < idcategor; i++)
            {
              Console.WriteLine(categor[i].ToString());
            }
            Console.WriteLine("");
            int escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("INFORME SEUS DADOS");
            Console.WriteLine("");
           
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
    
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Valor da hora de trabalho: ");
            double valor = double.Parse(Console.ReadLine());
    
            // Console.Write("Data de nascimento [yyyy-MM-dd]: ");
            // DateTime dataNascimento = DateTime.Parse(Console.ReadLine()); // yyyy-MM-dd
    
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
    
            Console.Write("E-mail para contato: ");
            string email = Console.ReadLine();
    
            Console.Write("Sexo: ");
            string sexo = Console.ReadLine();
    
            Console.Write("Endereço: ");
            string endereco = Console.ReadLine();
    
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();
    
            Console.Write("Cidade: ");
            string cidade = Console.ReadLine();
    
            Console.Write("Telefone para contato: ");
            string telefone = Console.ReadLine();
    
            Console.Write("Informe uma senha: ");
            string senha = Console.ReadLine();

            prest[idprestador] = new Prestador(idprestador +1, nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categor[escolha], senha);
            
            idprestador++;
            Console.WriteLine("");
            Console.WriteLine("Cadastro efetuado com sucesso");
            Console.WriteLine("");
            Console.WriteLine("");
            // prest[idprestador] = new Prestador(idprestador + 1, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", categor[escolha], "senha123");

            
            // idprestador++;
            Console.WriteLine("");
            
            break;
          }
          case 5:
              {
                Console.WriteLine("CADASTRAR CATEGORIA");
                Console.WriteLine("");
                Console.WriteLine("Digite o nome da categoria");
                categor[idcategor] = new Categoria(idcategor + 1, Console.ReadLine());
                idcategor++;
                Console.WriteLine("");
                
                break;
              }
          default: Console.WriteLine("Opção inválida"); break;
        }
      }
    }
}
