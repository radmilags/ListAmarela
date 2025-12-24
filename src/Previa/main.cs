using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

class Program
{
    public static void Main()
    {
      Console.WriteLine("");
      Console.WriteLine("ListAmarela");
      Console.WriteLine("");
      List<Cliente> clientes = new List<Cliente>();
      List<Categoria> categorias = new List<Categoria>();
      List<Prestador> prestadores = new List<Prestador>();

      
      int op = -1;

      int escolha;
      
      while (op != 0)
      {
        Console.WriteLine("");
        Console.WriteLine("[0] Sair");
        Console.WriteLine("[1] Deletar Cadastro");
        Console.WriteLine("[2] Listar prestadores");
        Console.WriteLine("[3] Cadastrar cliente");
        Console.WriteLine("[4] Cadastrar Prestador");
        Console.WriteLine("[5] Cadastrar categoria");
        Console.WriteLine("[6] Opção indisponível no momento");
        Console.WriteLine("[7] Atualizar prestador");
        
        Console.WriteLine("");
        Console.Write("Escolha uma opção: ");
        op = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        switch (op)
        {
          case 0: break;
          case 1:
            {
            // buscando listas dos prestadores no arquivo .xml
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
            Persistencia<Categoria> bancocategorias = new Persistencia<Categoria>();
            categorias = bancocategorias.AbrirArquivo("./categorias.xml");

            int op3 = 1;
            foreach (Categoria categoria in categorias) {
              Console.WriteLine($"[{op3}] - {categoria.ToString()}");
              op3++;
              
            }
            Console.WriteLine($"[99] - Todos");
  
            Console.WriteLine("");
            Console.Write("Escolha o número categoria: ");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (escolha == 99) {
              Console.WriteLine("");
              Console.WriteLine("Lista de Prestadores");
              Console.WriteLine("");
              foreach (Prestador prestador in prestadores) {
                Console.WriteLine(prestador.ToString());
                Console.WriteLine("");
              } 
            } 
            else {
              escolha = escolha - 1;
              prestadores.Sort((p1, p2) => p1.valor.CompareTo(p2.valor));
              foreach (Prestador prestador in prestadores) {
                if (prestador.cat.nome == categorias[escolha].nome) {
                  Console.WriteLine(prestador.ToString());
                  Console.WriteLine("");
                }
              }
              Console.WriteLine(">> FIM DA LISTA <<");
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

            Console.WriteLine("");


            bancoclientes.SalvarArquivo("./clientes.xml", clientes);
            
            break;
            }
          case 4:
            {
            Persistencia<Prestador> bancodados = new Persistencia<Prestador>();
            prestadores = bancodados.AbrirArquivo("./prestadores.xml");
            Persistencia<Categoria> bancocategorias = new Persistencia<Categoria>();
            categorias = bancocategorias.AbrirArquivo("./categorias.xml");
              
            Console.WriteLine("");
            Console.WriteLine("CADASTRAR PRESTADOR");
            Console.WriteLine("");
          
            int op2 = 1;
            foreach (Categoria categoria in categorias) {
              Console.WriteLine($"[{op2}] - {categoria.ToString()}");
              op2++;
              
            }
            Console.WriteLine("");
            Console.Write("Escolha o número categoria: ");  
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
 
            Prestador novoprestador = new Prestador(idprestador , nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categorias[escolha-1], senha);
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
            Persistencia<Categoria> bancocategorias = new Persistencia<Categoria>();
            categorias = bancocategorias.AbrirArquivo("./categorias.xml");

            Console.WriteLine("CADASTRAR CATEGORIA");
            Console.WriteLine("");
            Console.WriteLine("Digite o nome da categoria");
            Console.WriteLine("");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            int idcategoria;
              
            if (prestadores.Count == 0) idcategoria = 1;
            else {
              idcategoria = categorias.Max(f=>f.id);
              idcategoria++;
              }

            Categoria novacategoria = new Categoria(idcategoria, nome);
            Console.WriteLine("");

            categorias.Add(novacategoria);

            bancocategorias.SalvarArquivo("./categorias.xml", categorias);

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
            Persistencia<Categoria> bancocategorias = new Persistencia<Categoria>();
            categorias = bancocategorias.AbrirArquivo("./categorias.xml");
              
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

            
            int op3 = 1;
            foreach (Categoria categoria in categorias) {
              Console.WriteLine($"[{op3}] - {categoria.ToString()}");
              op3++;
              
            }
              
            Console.WriteLine("");
            Console.Write("Escolha o número categoria: ");
            escolha = int.Parse(Console.ReadLine());
            Console.WriteLine("");
    
            Console.Write("Informe uma senha: ");
            string senha = Console.ReadLine();

            prestadores[id-1].SetPrestador(nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categorias[escolha-1], senha);

            bancodados.SalvarArquivo("./prestadores.xml", prestadores);
          
            break;
          }
          default: Console.WriteLine("Opção inválida"); break;
        }
      }
    }
}
