using System; // IComparable

class Categoria{
  private int id;
  private string nome;
  public Categoria(int id, string nome) {
    this.id = id;
    if(nome!="") this.nome = nome;
  }
  public override string ToString(){ return $"[{this.id}] {this.nome}"; }
}
