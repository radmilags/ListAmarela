using System;
using System.Collections.Generic;
using System.Linq;

public class CategoriaService {
    private List<Categoria> categorias;
    private Persistencia<Categoria> banco;
    private string caminhoArquivo = "./categorias.xml";

    public CategoriaService() {
        this.banco = new Persistencia<Categoria>();
        this.categorias = banco.AbrirArquivo(caminhoArquivo);
    }

    public void Cadastrar(Categoria nova) {
        this.categorias.Add(nova);
        this.banco.SalvarArquivo(caminhoArquivo, this.categorias);
    }

    public List<Categoria> Listar() {
        return this.categorias;
    }

    public int GerarId() {
        if (categorias.Count == 0) return 1;
        return categorias.Max(c => c.Id) + 1;
    }
}