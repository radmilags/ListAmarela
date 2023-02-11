using System.Xml.Serialization;


[XmlInclude(typeof(Categoria))]
public class Prestador{
    public int id;
    public string nome;
    public string sobrenome;
    public double valor;
    public string cpf;
    public string email;
    public string sexo;
    public string endereco;
    public string bairro;
    public string cidade;
    public string telefone;
    public string senha;
    public Categoria cat;



    //adicionar atributo categoria

    
    public Prestador() {}
    public Prestador(int id, string nome, string sobrenome, double valor, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, Categoria cat, string senha)
    {
        this.id = id;
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.valor = valor;
        this.cpf = cpf;
        this.email = email;
        this.sexo = sexo;
        this.endereco = endereco;
        this.bairro = bairro;
        this.cidade = cidade;
        this.telefone = telefone;
        this.senha = senha;
        this.cat = cat;
    }

   public void SetPrestador(string nome, string sobrenome, double valor, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, Categoria cat, string senha)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
        this.valor = valor;
        this.cpf = cpf;
        this.email = email;
        this.sexo = sexo;
        this.endereco = endereco;
        this.bairro = bairro;
        this.cidade = cidade;
        this.telefone = telefone;
        this.senha = senha;
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


    public override string ToString() { 
        return $"Nome: {this.nome} {this.sobrenome} \nTelefone para contato: {this.telefone} \nValor da hora de trabalho: R$ {this.valor},00 \nEspecialidade: {this.cat} \nBairro: {this.bairro} "; 
    }
}

