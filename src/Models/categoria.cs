public class Categoria {
  public int Id { get; set; }
  public string Nome { get; set; }

  public Categoria() { }

  public Categoria(int id, string nome) {
    this.Id = id;
    this.Nome = nome;
  }
  public override string ToString(){ return $"[{this.Id}] {this.Nome}"; }
}