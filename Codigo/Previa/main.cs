using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

class Program
{
    public static void Main()
    {
      int idcategor = 7; 
      Console.WriteLine("");
      Console.WriteLine("ListAmarela");
      Console.WriteLine("");
      List<Cliente> clientes = new List<Cliente>();
      Categoria[] categor = new Categoria[8];
      categor[0] = new Categoria(1, "Eletricista");
      categor[1] = new Categoria(2, "Diarista/Folgista");
      categor[2] = new Categoria(3, "Encanador");
      categor[3] = new Categoria(4, "Pintura");
      categor[4] = new Categoria(5, "Lavaderia");
      categor[5] = new Categoria(6, "Frete");
      categor[6] = new Categoria(7, "Gesso");
      List<Prestador> prestadores = new List<Prestador>();

      
      int op = -1;

      int escolha;
      
      while (op != 0)
      {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("[0] Sair");
        Console.WriteLine("[1] Deletar Cadastro");
        Console.WriteLine("[2] Mostrar dados");
        Console.WriteLine("[3] Cadastrar cliente");
        Console.WriteLine("[4] Cadastrar Prestador");
        Console.WriteLine("[5] Cadastrar categoria");
        Console.WriteLine("[6] Opção indiponível no momento");
        Console.WriteLine("[7] Atualizar prestador");
        Console.WriteLine("");

        op = int.Parse(Console.ReadLine());
        switch (op)
        {
          case 0: break;
          case 1:
            {

            Persistencia<Prestador> bancodados = new Persistencia<Prestador>();
            prestadores = bancodados.AbrirArquivo("./prestadores.xml");
              
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

            bancodados.SalvarArquivo("./prestadores.xml", prestadores);
            
            break;
          }
          case 2:
            {

            Persistencia<Prestador> bancodados = new Persistencia<Prestador>();
            prestadores = bancodados.AbrirArquivo("./prestadores.xml");
              
            Console.WriteLine("");
            Console.WriteLine("Lista de Prestadores");
            Console.WriteLine("");
            foreach (Prestador prestador in prestadores) {
              Console.WriteLine(prestador.ToString());
              Console.WriteLine("");
              
            }
            
           
            Console.WriteLine(""); 
            
          break;
        }     
          case 3:
            {

              Persistencia<Cliente> bancoclientes = new Persistencia<Cliente>();
              clientes = bancoclientes.AbrirArquivo("./clientes.xml");
              
              Console.WriteLine("");
              Console.WriteLine("CADASTRO");
              Console.WriteLine("");

              Console.Write("Nome: ");
              string nome = Console.ReadLine();
      
              Console.Write("Sobrenome: ");
              string sobrenome = Console.ReadLine();
           
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

              int idcliente;
              
              if (clientes.Count == 0) idcliente = 1;
              else {
                idcliente = clientes.Max(f=>f.id);
                idcliente++;
                }

              Cliente novocliente = new Cliente(idcliente, nome, sobrenome, cpf, email, sexo, endereco, bairro, cidade, telefone, senha);

              clientes.Add(novocliente);

              idcliente++;
              Console.WriteLine("");


              bancoclientes.SalvarArquivo("./clientes.xml", clientes);
              
              break;
            }
          case 4:
            {
            Persistencia<Prestador> bancodados = new Persistencia<Prestador>();
            prestadores = bancodados.AbrirArquivo("./prestadores.xml");
              
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
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("INFORME SEUS DADOS");
            Console.WriteLine("");
           
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
    
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Valor da hora de trabalho: ");
            double valor = double.Parse(Console.ReadLine());
        
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

            int idprestador;
              
            if (prestadores.Count == 0) idprestador = 1;
            else {
              idprestador = prestadores.Max(f=>f.id);
              idprestador++;
              }
 
            Prestador novoprestador = new Prestador(idprestador , nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categor[escolha-1], senha);
            prestadores.Add(novoprestador);

            Console.WriteLine("");
            Console.WriteLine("Cadastro efetuado com sucesso");
            Console.WriteLine("");
            Console.WriteLine("");
            bancodados.SalvarArquivo("./prestadores.xml", prestadores);
            
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
          case 6:
            {
            Console.WriteLine("");
            Console.WriteLine("Lista Serializada:");
            Console.WriteLine("");
            XmlSerializer serializer = new XmlSerializer(typeof(Prestador));
            using (TextWriter writer = new StreamWriter("prestador.xml"))
            {
                int count = 1;
                foreach (Prestador prestador in prestadores)
                {
                    Console.WriteLine("Nome: " + prestador.nome);
                    Console.WriteLine("ValorDaHoraTrabalhada: " + prestador.valor);
                    Console.WriteLine("Bairro: " + prestador.bairro);
                    Console.WriteLine("TelefoneParaContato: " + prestador.telefone);
                    Console.WriteLine("");
                    prestador.id = count++;
                    serializer.Serialize(writer, prestador);
                }
            }
            break;}
          case 7: 
            {

            Persistencia<Prestador> bancodados = new Persistencia<Prestador>();
            prestadores = bancodados.AbrirArquivo("./prestadores.xml");
              
            Console.WriteLine("");
            Console.WriteLine("Atualizar");
            Console.WriteLine("");

            int op2 = 1;
            foreach (Prestador prestador in prestadores) {
               Console.WriteLine($"[{op2}] {prestador.ToString()}");
               Console.WriteLine("");
               op2++;
            }              

            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
          
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
    
            Console.Write("Sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.Write("Valor da hora de trabalho: ");
            double valor = double.Parse(Console.ReadLine());

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

            Console.WriteLine("Escolha o número categoria");
            Console.WriteLine("");
            
            for (int i = 0; i < idcategor; i++)
            {
              Console.WriteLine(categor[i].ToString());
            }
            Console.WriteLine("");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");
    
            Console.Write("Informe uma senha: ");
            string senha = Console.ReadLine();

            prestadores[id-1].SetPrestador(nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categor[escolha-1], senha);

            bancodados.SalvarArquivo("./prestadores.xml", prestadores);
          
            break;
          }
          default: Console.WriteLine("Opção inválida"); break;
        }
      }
    }
}
