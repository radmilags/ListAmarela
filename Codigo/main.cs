using System;

class Program
{
    public static void Main()
    {
      int idcliente = 0; int idcategor = 0; int idprestador = 0;
      Console.WriteLine("");
      Console.WriteLine("ListAmarela");
      Console.WriteLine("");
      Cliente[] c = new Cliente[3];
      Categoria[] categor = new Categoria[3];
      categor[0] = new Categoria(1, "Mecanico");
      categor[1] = new Categoria(2, "Faxineiro");
      categor[2] = new Categoria(3, "Jardineiro");
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
            for (int i = 0; i < 4; i++)
            {
              Console.WriteLine(categor[i].ToString());
            }
            break;
          }
          case 2:
            Console.WriteLine("Cliente(1) ou prestador(2)?");
            int x = int.Parse(Console.ReadLine());
            if(x == 1){
              Console.WriteLine("Selecione o id do usuario");
              int y = int.Parse(Console.ReadLine());
              Console.WriteLine(c[y-1].ToString());
            }
            else{
                Console.WriteLine("Selecione o id do usuario");
                int y = int.Parse(Console.ReadLine());
                Console.WriteLine(prest[y-1].ToString());
            }
          break;
          case 3:
            {
              Console.WriteLine("");
              Console.WriteLine("CADASTRO");
              Console.WriteLine("");
              //id, nome, sobrenome, cpf, email, sexo,  endereco, bairro, cidade, telefone, Categoria, senha
              c[idcliente] = new Cliente(idcliente + 1, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", "senha123");
              idcliente++;
              break;
            }
          case 4:
          {
            Console.WriteLine("CADASTRO");
            Console.WriteLine("");
            Console.WriteLine("Escolha o número categoria");
            for (int i = 0; i < 3; i++)
            {
              Console.WriteLine(categor[i].ToString());
            }
            int escolha = int.Parse(Console.ReadLine());
            prest[idprestador] = new Prestador(idprestador + 1, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", categor[escolha], "senha123");
            idprestador++;
            break;
          }
          case 5:
              {
                Console.WriteLine("CADASTRAR CATEGORIA");
                Console.WriteLine("");
                Console.WriteLine("Digite o nome da categoria");
                categor[idcategor] = new Categoria(idcategor + 1, Console.ReadLine());
                idcategor++;
                break;
              }
          default: Console.WriteLine("Opção inválida"); break;
        }
      }
    }
}
