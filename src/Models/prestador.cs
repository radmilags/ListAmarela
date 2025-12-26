namespace ListAmarela.Models
{
    public class Prestador 
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Valor { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public Categoria Categoria { get; set; }

        public Prestador() { } 

        public Prestador(int id, string nome, string sobrenome, double valor, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, Categoria cat, string senha) 
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Valor = valor;
            this.Cpf = cpf;
            this.Email = email;
            this.Sexo = sexo;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Telefone = telefone;
            this.Categoria = cat;
            this.Senha = senha;
        }

        public void SetPrestador(string nome, string sobrenome, double valor, string cpf, string email, string sexo, string endereco, string bairro, string cidade, string telefone, Categoria cat, string senha) 
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Valor = valor;
            this.Cpf = cpf;
            this.Email = email;
            this.Sexo = sexo;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Telefone = telefone;
            this.Categoria = cat;
            this.Senha = senha;
        }

        public override string ToString() 
        {
            return $"Nome: {this.Nome} {this.Sobrenome} - Tel: {this.Telefone} \nValor/h: R$ {this.Valor:F2} \nEsp.: {this.Categoria} \nBairro: {this.Bairro}";
        }
    }
}