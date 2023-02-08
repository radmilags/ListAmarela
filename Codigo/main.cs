using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    int idcliente = 0; int idcategor = 3; int idprestador = 0; int op = -1;
    Console.WriteLine("ListAmarela\n\n");
    
    List<Cliente> c  = new List<Cliente>();
    List<Categoria> categor = new List<Categoria>();
    Prestador[] prest = new Prestador[3];
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
          Console.Write("Cliente (1) ou prestador (2) : ");
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
          Console.WriteLine("CADASTRO\n\n");
          //id, nome, sobrenome, cpf, email, sexo,  endereco, bairro, cidade, telefone, Categoria, senha
          c.Add(new Cliente(idcliente, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", "senha123"));
          idcliente++;
          Console.WriteLine("");
          
          break;
        }
        case 4:
        {
          Console.WriteLine("");
          Console.WriteLine("CADASTRO");
          Console.WriteLine("");
          Console.WriteLine("Escolha o número categoria");
          Console.WriteLine("");
          
          for (int i = 0; i < 3; i++)
          {
            Console.WriteLine(categor[i].ToString());
          }
          Console.WriteLine("");
          int escolha = int.Parse(Console.ReadLine());
          prest[idprestador] = new Prestador(idprestador, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", categor[escolha], "senha123");
          idprestador++;
          Console.WriteLine("");
          
          break;
        }
        case 5:
        {
          Console.WriteLine("CADASTRAR CATEGORIA\n\n");
          Console.WriteLine("Digite o nome da categoria");
          categor.Add(new Categoria(idcategor, Console.ReadLine()));
          idcategor++;
          Console.WriteLine("");
          
          break;
        }
        default: Console.WriteLine("Opção inválida"); break;
      }
    }
  }
}
