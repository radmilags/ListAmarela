using System;

class Program
{
  public static void Main()
  {
    int idcliente = 0; int idcategor = 0; int idprestador = 0;
    Console.WriteLine("ListAmarela\n\n");
    Cliente[] c = new Cliente[3];
    Categoria[] categor = new Categoria[5];
    categor[0] = new Categoria(1, "Eletricista");
    categor[1] = new Categoria(2, "Diarista");
    categor[2] = new Categoria(3, "Encanador");
    categor[3] = new Categoria(4, "Pintura");
    categor[4] = new Categoria(5, "Lavaderia");
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
          Console.Clear();
          Console.WriteLine("telefone = 400028922");
          for (int i = 0; i < idcategor; i++)
          {
            Console.WriteLine(categor[i].ToString());
          }
          Console.WriteLine("");

          break;
        }
        case 2:
        {
          Console.Clear();
          Console.WriteLine("");
          Console.Write("Cliente [1] ou prestador [2] : ");
          int x = int.Parse(Console.ReadLine());
          if (x == 1)
          {
            Console.WriteLine("");
            Console.Write("Selecione o id do usuario: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(c[y - 1].ToString());
          }
          else
          {
            Console.WriteLine("");
            Console.WriteLine("Selecione o id do usuario");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine(prest[y - 1].ToString());
          }

          break;
        }

        case 3:
        {
          Console.Clear();
          Console.WriteLine("CADASTRO\n");
          c[idcliente] = new Cliente(idcliente, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", "senha123");
          idcliente++;

          break;
        }
        case 4:
        {
          Console.Clear();
          Console.WriteLine("CADASTRAR PRESTADOR\n");
          Console.WriteLine("Escolha o número categoria\n");

          for (int i = 0; i < idcategor; i++)
          {
              Console.WriteLine(categor[i].ToString());
          }
          Console.WriteLine("");
          int escolha = int.Parse(Console.ReadLine());
          Console.WriteLine("");

          Console.WriteLine("INFORME SEUS DADOS");
          Console.WriteLine("");

          prest[idprestador] = new Prestador(idprestador, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", categor[escolha], "senha123");

          idprestador++;
          Console.WriteLine("Cadastro efetuado com sucesso\n");

          break;
        }
        case 5:
        {
          Console.Clear();
          Console.WriteLine("CADASTRAR CATEGORIA\n");
          Console.WriteLine("Digite o nome da categoria\n");
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
