
class Prestador{
  private int id;
    private string nome;
    private string sobrenome;
    private double valor;
    private string cpf;
    private string email;
    private string sexo;
    private string endereco;
    private string bairro;
    private string cidade;
    private string telefone;
    private string senha;
    private Categoria cat;

    //adicionar atributo categoria

  
    public Prestador(int id, string nome, string sobrenome, double valor, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, Categoria cat, string senha)
    {
        this.id = id;
        if (nome != "") this.nome = nome;
        if (sobrenome != "") this.sobrenome = sobrenome;
        if (valor != 0.0) this.valor = valor;
        if (cpf != "") this.cpf = cpf;
        if (email != "") this.email = email;
        if (sexo != "") this.sexo = sexo;
        if (endereco != "") this.endereco = endereco;
        if (bairro != "") this.bairro = bairro;
        if (cidade != "") this.cidade = cidade;
        if (telefone != "") this.telefone = telefone;
        if (senha != "") this.senha = senha;
        this.cat = cat;
    }
    public string GetNome() { return this.nome; }
    public string GetSobrenome() { return this.sobrenome; }
    public double GetValor() { return this.valor; }
    public string Getcpf() { return this.cpf; }
    public string Getemail() { return this.email; }
    public string Getsexo() { return this.sexo; }
    public string Getendereco() { return this.endereco; }
    public string Getbairro() { return this.bairro; }
    public string Getcidade() { return this.cidade; }
    public string Gettelefone() { return this.telefone; }
    public string Getsenha() { return this.senha; }
    public Categoria GetCategoria() { return this.cat; }

    //ToString

    public override string ToString() { return $"Nome: {this.nome} {this.sobrenome} \nTelefone para contato: {this.telefone} \nValor da hora de trabalho: R$ {this.valor},00 \nEspecialidade: {this.cat} \nBairro: {this.bairro} "; }
}
