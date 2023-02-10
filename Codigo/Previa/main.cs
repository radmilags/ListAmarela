using System;
using System.Collections.Generic;
// using System.IO;
// using System.Xml.Serialization;

class Program
{
    public static void Main()
    {
      int idcliente = 10; int idcategor = 7; int idprestador = 0;
      Console.WriteLine("");
      Console.WriteLine("ListAmarela");
      Console.WriteLine("");
      List<Cliente> clientes = new List<Cliente>();
      // Cliente[] c = new Cliente[3];
      Categoria[] categor = new Categoria[8];
      categor[0] = new Categoria(1, "Eletricista");
      categor[1] = new Categoria(2, "Diarista/Folgista");
      categor[2] = new Categoria(3, "Encanador");
      categor[3] = new Categoria(4, "Pintura");
      categor[4] = new Categoria(5, "Lavaderia");
      categor[5] = new Categoria(6, "Frete");
      categor[6] = new Categoria(7, "Gesso");
      List<Prestador> prestadores = new List<Prestador>();
      // Prestador[] prest = new Prestador[3];
      int op = -1;

      Prestador prestador1 = new Prestador(1, "Kauã", "Charles", 100.00, "11111111111", "email1@email.com", "M", "Rua 1", "Lagoa Nova", "Natal", "99999-1111", categor[2], "senha");
      Prestador prestador2 = new Prestador(2, "Pedro", "Costas", 220.00, "22222222222", "email2@email.com", "M", "Rua 2", "Planalto", "Natal", "98888-2333", categor[2], "senha");
      Prestador prestador3 = new Prestador(3, "Paulo", "Ricardo", 300.00, "33333333333", "email3@email.com", "M", "Rua 3", "Satélite", "Natal", "98888-1458", categor[1], "senha");
      Prestador prestador4 = new Prestador(4, "Rafael", "Oliveira", 135.00, "4444444444", "email4@email.com", "M", "Rua 4", "Igapó", "Natal", "99999-1574", categor[7], "senha");
      Prestador prestador5 = new Prestador(5, "Roberta", "Ferreira", 210.00, "55555555555", "email5@email.com", "F", "Rua 2", "Nova Natal", "Natal", "99999-2558", categor[3], "senha");
      Prestador prestador6 = new Prestador(6, "Cláudia", "Rodrigues", 180.00, "66666666666", "email6@email.com", "F", "Rua 3", "Tirol", "Natal", "99999-5568", categor[5], "senha");
      Prestador prestador7 = new Prestador(7, "Neide", "Almeida", 140.00, "77777777777", "email7@email.com", "F", "Rua 10", "Mãe Luíza", "Natal", "99999-1295", categor[4], "senha");
      Prestador prestador8 = new Prestador(8, "José", "Antônio", 85.00, "88888888888", "email8@email.com", "M", "Rua 19", "Dis. Rosado", "Natal", "99999-9889", categor[1], "senha");
      Prestador prestador9 = new Prestador(9, "Paula", "sobrenome", 190.00, "99999999999", "email9@email.com", "F", "Rua 20", "Nova Parnamirim", "Parnamirim", "99999-1581", categor[4], "senha");
      Prestador prestador10 = new Prestador(10, "Paula", "sobrenome", 190.00, "99999999999", "email9@email.com", "F", "Rua 20", "Nova Parnamirim", "Parnamirim", "99999-1582", categor[5], "senha");
      
      prestadores.Add(prestador1);
      prestadores.Add(prestador2);
      prestadores.Add(prestador3);
      prestadores.Add(prestador4);
      prestadores.Add(prestador5);
      prestadores.Add(prestador6);
      prestadores.Add(prestador7);
      prestadores.Add(prestador8);
      prestadores.Add(prestador9);
      prestadores.Add(prestador10);
      
      
      while (op != 0)
      {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("[0] Sair");
        Console.WriteLine("[1] Deletar Cadastro");
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
            int op2 = 1;
            int op3 = 0;
            Console.WriteLine("");
            foreach (Prestador prestador in prestadores) {
               Console.WriteLine($"[{op2}] {prestador.ToString()}");
               Console.WriteLine("");
               op2++;
            }

            Console.Write("Escolha um opção para deletar: ");
            op3 = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            
            prestadores.RemoveAt(op3-1);
            break;
          }
          case 2:
            Console.WriteLine("");
            // Console.Write("Cliente [1] ou prestador [2] : ");
            Console.WriteLine("Lista de Prestadores");
            Console.WriteLine("");
            foreach (Prestador prestador in prestadores) {
               Console.WriteLine(prestador.ToString());
               Console.WriteLine("");
            }
          
            // int x = int.Parse(Console.ReadLine());
            // if (x == 1) {
            //   foreach (Cliente cliente in clientes) {
            //     Console.WriteLine(cliente.ToString());
            //     Console.WriteLine("");
            //   }
            // }
            // else {
            // foreach (Prestador prestador in prestadores) {
            //   Console.WriteLine(prestador.ToString());
            //   Console.WriteLine("");
            //   }
            // }
            // if(x == 1){
            //   Console.WriteLine("");
            //   Console.Write("Selecione o id do usuario: ");
            //   int y = int.Parse(Console.ReadLine());
            //   Console.WriteLine(c[y-1].ToString());
            // }
            
            // else{
            //   Console.WriteLine("");
            //   Console.WriteLine("Selecione o id do usuario");
            //   int y = int.Parse(Console.ReadLine());
            //   Console.WriteLine("");
            //   Console.WriteLine(prest[y-1].ToString());
            // }
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

              Cliente novocliente = new Cliente(idcliente + 1, nome, sobrenome, cpf, email, sexo, endereco, bairro, cidade, telefone, senha);

              clientes.Add(novocliente);
  
              // c[idcliente] = new Cliente(idcliente + 1, nome, sobrenome, cpf, email, sexo, endereco, bairro, cidade, telefone, senha);
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

            Prestador novoprestador = new Prestador(idprestador +1, nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categor[escolha-1], senha);
            prestadores.Add(novoprestador);

            // ToXML(prestadores);

            // prest[idprestador] = new Prestador(idprestador +1, nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categor[escolha], senha);
            
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


  // public static void ToXML(List<Prestador> prest) {
  //   XmlSerializer xml = new XmlSerializer(typeof(List<Prestador>));
    
  //   StreamWriter arq = new StreamWriter("Prestadores.xml");
  //   xml.Serialize(arq, prest);
  //   arq.Close();
  // }
}