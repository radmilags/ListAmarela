using System;

namespace ListAmarela.Models 
{
  public class Servico
  {
    private int id;
    private string nome;
    private double preco; 
    private string descricao;
    private Categoria categor;

    public Servico(int id, string nome, double preco, string descricao, Categoria categor){
      this.id = id;
      if(nome !="") this.nome = nome;
      if(preco > 0) this.preco = preco;
      this.descricao = descricao;
      this.categor = categor;
    }
  }
}