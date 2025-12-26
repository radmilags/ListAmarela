using System;
using System.Collections.Generic;
using ListAmarela.Models;
using ListAmarela.Services;

class Program
{
    static PrestadorService prestadorService = new PrestadorService();
    static CategoriaService categoriaService = new CategoriaService();
    static ClienteService clienteService = new ClienteService(); 

    public static void Main()
    {
        Console.WriteLine("");
        Console.WriteLine(" ListAmarela ");
        Console.WriteLine("");

        int op = -1;

        while (op != 0)
        {
            ExibirMenu(); 

            if (!int.TryParse(Console.ReadLine(), out op)) {
                Console.WriteLine("Opção inválida! Digite um número.");
                continue;
            }

            switch (op)
            {
                case 0: 
                    Console.WriteLine("Saindo... Até logo!");
                    break;

                case 1:
                {
                    Console.WriteLine(" DELETAR PRESTADOR ");
                    var lista = prestadorService.Listar();
                    
                    int i = 1;
                    foreach (var p in lista) {
                        Console.WriteLine($"[{i}] {p.Nome} {p.Sobrenome}");
                        i++;
                    }

                    Console.Write("Escolha o número para deletar: ");
                    if(int.TryParse(Console.ReadLine(), out int index)) {
                        prestadorService.Deletar(index - 1);
                        Console.WriteLine("Prestador removido com sucesso!");
                    }
                    break;
                }

                case 2: 
                {
                    Console.WriteLine(" LISTA DE PRESTADORES ");
                    var lista = prestadorService.Listar();

                    foreach (var p in lista) {
                        Console.WriteLine(p.ToString());
                        Console.WriteLine("--");
                    }
                    break;
                }

                case 3: 
                {
                    Console.WriteLine(" CADASTRO DE CLIENTE ");
                    
                    Console.Write("Nome: "); string nome = Console.ReadLine();
                    Console.Write("Sobrenome: "); string sobrenome = Console.ReadLine();
                    Console.Write("CPF: "); string cpf = Console.ReadLine();
                    Console.Write("E-mail: "); string email = Console.ReadLine();
                    Console.Write("Sexo: "); string sexo = Console.ReadLine();
                    Console.Write("Endereço: "); string endereco = Console.ReadLine();
                    Console.Write("Bairro: "); string bairro = Console.ReadLine();
                    Console.Write("Cidade: "); string cidade = Console.ReadLine();
                    Console.Write("Telefone: "); string telefone = Console.ReadLine();
                    Console.Write("Senha: "); string senha = Console.ReadLine();

        
                    int idCliente = clienteService.GerarId();
                    Cliente novoCliente = new Cliente(idCliente, nome, sobrenome, cpf, email, sexo, endereco, bairro, cidade, telefone, senha);
                    
                    clienteService.Cadastrar(novoCliente);
                    
                    Console.WriteLine("\nCliente cadastrado com sucesso!");
                    break;
                }

                case 4:
                {
                    Console.WriteLine(" CADASTRAR PRESTADOR ");

                    
                    var listaCategorias = categoriaService.Listar();
                    
                    if (listaCategorias.Count == 0) {
                        Console.WriteLine("Nenhuma categoria cadastrada! Cadastre uma categoria antes.");
                        break;
                    }

                    int i = 1;
                    foreach (var cat in listaCategorias) {
                        Console.WriteLine($"[{i}] - {cat.Nome}");
                        i++;
                    }
                    Console.Write("Escolha a categoria: ");
                    int catIndex = int.Parse(Console.ReadLine()) - 1;

                    Console.Write("Nome: "); string nome = Console.ReadLine();
                    Console.Write("Sobrenome: "); string sobrenome = Console.ReadLine();
                    Console.Write("Valor/h: "); double valor = double.Parse(Console.ReadLine());
                    Console.Write("CPF: "); string cpf = Console.ReadLine();
                    Console.Write("E-mail: "); string email = Console.ReadLine();
                    Console.Write("Sexo: "); string sexo = Console.ReadLine();
                    Console.Write("Endereço: "); string endereco = Console.ReadLine();
                    Console.Write("Bairro: "); string bairro = Console.ReadLine();
                    Console.Write("Cidade: "); string cidade = Console.ReadLine();
                    Console.Write("Telefone: "); string telefone = Console.ReadLine();
                    Console.Write("Senha: "); string senha = Console.ReadLine();

                    int novoId = prestadorService.GerarId();
                    Prestador novoPrestador = new Prestador(novoId, nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, listaCategorias[catIndex], senha);
                    
                    prestadorService.Cadastrar(novoPrestador);

                    Console.WriteLine("\nPrestador cadastrado com sucesso!");
                    break;
                }

                case 5: 
                {
                    Console.WriteLine(" CADASTRAR CATEGORIA ");
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    
                    int novoId = categoriaService.GerarId();
                    Categoria novaCat = new Categoria(novoId, nome);
                    
                    categoriaService.Cadastrar(novaCat);
                    Console.WriteLine("Categoria cadastrada com sucesso!");
                    break;
                }

                case 6: 
                {
                     Console.WriteLine("Funcionalidade em manutenção para migração de arquitetura.");
                     break;
                }

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    public static void ExibirMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("[0] Sair");
        Console.WriteLine("[1] Deletar Prestador");
        Console.WriteLine("[2] Listar Prestadores");
        Console.WriteLine("[3] Cadastrar Cliente");
        Console.WriteLine("[4] Cadastrar Prestador");
        Console.WriteLine("[5] Cadastrar Categoria");
        Console.WriteLine("[6] Atualizar Prestador");
        Console.WriteLine("");
        Console.Write("Opção: ");
    }
}