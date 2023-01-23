using System;

class Servico
    {
    private int id;
    private string nome;
    private double preco;
    private string descricao;
    private string categoria;

    // Construtor
    public Servico(int id, string nome, double preco, string descricao, string categoria)
    {
        this.id = id;
        this.nome = nome;
        this.preco = preco;
        this.descricao = descricao;
        this.categoria = categoria;
    }

    // Métodos de acesso get e set para cada atributo
    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public double Preco { get => preco; set => preco = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public string Categoria { get => categoria; set => categoria = value; }
  }
