using System;
using System.Collections.Generic;
using System.Linq;
using ListAmarela.Models;

namespace ListAmarela.Services 
{
    public class ClienteService 
    {
        private List<Cliente> clientes;
        private Persistencia<Cliente> banco;
        private string caminhoArquivo = "./clientes.xml";

        public ClienteService() 
        {
            this.banco = new Persistencia<Cliente>();
            this.clientes = banco.AbrirArquivo(caminhoArquivo);
        }

        public void Cadastrar(Cliente novo) 
        {
            this.clientes.Add(novo);
            this.banco.SalvarArquivo(caminhoArquivo, this.clientes);
        }

        public List<Cliente> Listar() 
        {
            return this.clientes;
        }

        public int GerarId() 
        {
            if (clientes.Count == 0) return 1;
            return clientes.Max(c => c.Id) + 1;
        }
    }
}