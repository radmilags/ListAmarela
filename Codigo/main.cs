using System;
using System.Collections.Generic;

class Program
{
  public static void Main()
  {
    int idcliente = 0; int idcategor = 0; int idprestador = 0; int op = -1;
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
      Console.WriteLine("[5] CRUD categoria");
      Console.WriteLine("");

      op = int.Parse(Console.ReadLine());
      
      switch (op)
      {
        case 0: break;
        case 1:
        {
          Console.Clear();
          Console.WriteLine("telefone = 400028922");
          for (int i = 0; i < categor.Count; i++) Console.WriteLine(categor[i].ToString());
          break;
        }
        case 2:
          Console.Clear();
          Console.Write("Cliente (1) ou prestador (2):\n\n");
          int x = int.Parse(Console.ReadLine());
          if(x == 1){
          Console.Write("Selecione o id do usuario: \n\n");
          int y = int.Parse(Console.ReadLine());
          Console.WriteLine(c[y].ToString());
        }
        else{
          Console.WriteLine("Selecione o id do usuario\n\n");
          int y = int.Parse(Console.ReadLine());
          Console.WriteLine(prest[y].ToString());
        }  
        break;
        case 3:
        {
          Console.Clear();
          Console.WriteLine("CADASTRO\n\n");
          //id, nome, sobrenome, cpf, email, sexo,  endereco, bairro, cidade, telefone, Categoria, senha
          c.Add(new Cliente(idcliente, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", "senha123"));
          idcliente++;
          break;
        }
        case 4:
        {
          Console.Clear();
          Console.WriteLine("CADASTRO");
          Console.WriteLine("Escolha o número categoria\n\n");
          for (int i = 0; i < 3; i++)
          {
            Console.WriteLine(categor[i].ToString());
          }
          int escolha = int.Parse(Console.ReadLine());
          prest[idprestador] = new Prestador(idprestador, "radmila", "gama", "123456789", "@gmail.com", "F", "Rua", "Bairro", "cidade", "87996", categor[escolha], "senha123");
          idprestador++;
          
          break;
        }
        case 5:
        {
          Console.Clear();
          Console.WriteLine("Escolha uma opção:");
          Console.WriteLine("[0] Sair");
          Console.WriteLine("[1] Cadastrar Categoria");
          Console.WriteLine("[2] Atualizar Categoria");
          Console.WriteLine("[3] Remover Categoria");
          if(categor.Count > 0){
            for (int i = 0; i < categor.Count; i++) Console.WriteLine(categor[i].ToString());
          }
          int op1 = int.Parse(Console.ReadLine());
          if(op1 == 0) break;
          else if(op1 == 1) {
            Console.Clear();
            Console.WriteLine("CADASTRAR CATEGORIA\n\n");
            Console.WriteLine("Digite o nome da categoria");
            categor.Add(new Categoria(idcategor, Console.ReadLine()));
            idcategor++;
          }
          else if(op1 == 2){
            Console.WriteLine("Digite o id da categoria a ser removido");
            categor.Remove(int.Parse(Console.ReadLine()));
          }
          
          break;
        }
        default: Console.WriteLine("Opção inválida"); break;
      }
    }
  }
}
