using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Linq;

class Program
{
    // Instanciando o Service globalmente para usar no Main
    static PrestadorService prestadorService = new PrestadorService();

    public static void Main()
    {
        Console.WriteLine("");
        Console.WriteLine("=== ListAmarela ===");
        Console.WriteLine("");

        // Manter listas antigas por enquanto (Cliente/Categoria ainda não têm Service)
        List<Cliente> clientes = new List<Cliente>();
        List<Categoria> categorias = new List<Categoria>();
        
        // Carregando categorias para poder usar no cadastro (Modo antigo ainda)
        Persistencia<Categoria> bancoCategorias = new Persistencia<Categoria>();
        categorias = bancoCategorias.AbrirArquivo("./categorias.xml");

        // Carregando clientes (Modo antigo ainda)
        Persistencia<Cliente> bancoClientes = new Persistencia<Cliente>();
        clientes = bancoClientes.AbrirArquivo("./clientes.xml");

        int op = -1;

        while (op != 0)
        {
            ExibirMenu(); // Menu isolado para limpar o código

            // Tratamento de erro se o usuário digitar letra em vez de número
            if (!int.TryParse(Console.ReadLine(), out op)) {
                Console.WriteLine("Opção inválida! Digite um número.");
                continue;
            }

            switch (op)
            {
                case 0: 
                    Console.WriteLine("Saindo... Até logo!");
                    break;

                case 1: // Deletar Prestador
                {
                    Console.WriteLine(" DELETAR PRESTADOR ");
                    var lista = prestadorService.Listar();
                    
                    int i = 1;
                    foreach (var p in lista) {
                        Console.WriteLine($"[{i}] {p.Nome} {p.Sobrenome}");
                        i++;
                    }

                    Console.Write("Escolha o número para deletar: ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    
                    prestadorService.Deletar(index);
                    Console.WriteLine("Prestador removido com sucesso!");
                    break;
                }

                case 2: // Listar Prestadores
                {
                    Console.WriteLine(" LISTA DE PRESTADORES ");
                    var lista = prestadorService.Listar();

                    foreach (var p in lista) {
                        Console.WriteLine(p.ToString());
                        Console.WriteLine("--");
                    }
                    break;
                }

                case 3: // Cadastrar Cliente (Ainda no modo antigo - Próxima refatoração!)
                {
                    Console.WriteLine(" CADASTRO DE CLIENTE ");
                    // ... (Mantive sua lógica original de Cliente aqui para não quebrar tudo de vez)
                    // Sugestão: Crie um ClienteService depois!
                    
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

                    int idCliente = (clientes.Count == 0) ? 1 : clientes.Max(c => c.Id) + 1;

                    Cliente novoCliente = new Cliente(idCliente, nome, sobrenome, cpf, email, sexo, endereco, bairro, cidade, telefone, senha);
                    clientes.Add(novoCliente);
                    bancoClientes.SalvarArquivo("./clientes.xml", clientes);
                    
                    Console.WriteLine("Cliente cadastrado!");
                    break;
                }

                case 4: // Cadastrar Prestador (AGORA USANDO O SERVICE! 🍌)
                {
                    Console.WriteLine(" CADASTRAR PRESTADOR ");

                    
                    int i = 1;
                    foreach (var cat in categorias) {
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

                    Prestador novoPrestador = new Prestador(novoId, nome, sobrenome, valor, cpf, email, sexo, endereco, bairro, cidade, telefone, categorias[catIndex], senha);
                    
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