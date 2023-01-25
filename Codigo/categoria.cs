using System;
class Categoria{
  private int id;
  private string nome;
  
  public Categoria(int id, string nome){
    if(nome != "") this.nome = nome;
    if(id != "") this.id = id;
  }
  public string GetDados(){return $"{this.id} - {this.nome}"};
}
