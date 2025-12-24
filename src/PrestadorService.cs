using System;
using System.Collections.Generic;
using System.Linq;

public class PrestadorService {
    private List<Prestador> prestadores;
    private Persistencia<Prestador> banco;
    private string caminhoArquivo = "./prestadores.xml";

    public PrestadorService() {
        this.banco = new Persistencia<Prestador>();
        this.prestadores = banco.AbrirArquivo(caminhoArquivo);
    }

    public void Cadastrar(Prestador novo) {
        this.prestadores.Add(novo);
        this.Salvar();
    }

    public List<Prestador> Listar() {
        return this.prestadores;
    }

    public void Atualizar(int id, Prestador atualizado) {
        // Lógica de update aqui futuramente
        this.Salvar();
    }

    public void Deletar(int index) {
        if(index >= 0 && index < prestadores.Count) {
            this.prestadores.RemoveAt(index);
            this.Salvar();
        }
    }

    private void Salvar() {
        this.banco.SalvarArquivo(caminhoArquivo, this.prestadores);
    }

    public int GerarId() {
        if (prestadores.Count == 0) return 1;
        return prestadores.Max(p => p.Id) + 1;
    }
}