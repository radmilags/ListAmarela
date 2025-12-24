using System;

public class Cliente{
  private int id;
    private string nome;
    private string sobrenome;
    private string cpf;
    private string email;
    private string sexo;
    private string endereco;
    private string bairro;
    private string cidade;
    private string telefone;
    private string senha;
    public Cliente(int id, string nome, string sobrenome, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, string senha)
    {
        this.id = id;
        if (nome != "") this.nome = nome;
        if (sobrenome != "") this.sobrenome = sobrenome;
        if (cpf != "") this.cpf = cpf;
        if (email != "") this.email = email;
        if (sexo != "") this.sexo = sexo;
        if (endereco != "") this.endereco = endereco;
        if (bairro != "") this.bairro = bairro;
        if (cidade != "") this.cidade = cidade;
        if (telefone != "") this.telefone = telefone;
        if (senha != "") this.senha = senha;
    }
    public string GetNome() { return this.nome; }
    public string GetSobrenome() { return this.sobrenome; }
    public string Getcpf() { return this.cpf; }
    public string Getemail() { return this.email; }
    public string Getsexo() { return this.sexo; }
    public string Getendereco() { return this.endereco; }
    public string Getbairro() { return this.bairro; }
    public string Getcidade() { return this.cidade; }
    public string Gettelefone() { return this.telefone; }
    public string Getsenha() { return this.senha; }

    //ToString

    public override string ToString() { return $"Nome: {this.nome} {this.sobrenome} - Telefone: {this.telefone}"; }
}