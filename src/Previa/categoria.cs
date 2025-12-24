using System; // IComparable


[Serializable]
public class Categoria
{
    public int id;
    public string nome;
    public Categoria () {}
    public Categoria(int id, string nome)
    {
        this.id = id;
        if (nome != "") this.nome = nome;
    }
    public override string ToString() { return $"{this.nome}"; }
}
