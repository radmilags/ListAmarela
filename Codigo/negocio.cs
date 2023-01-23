class Servico{
  private int id;
  private string nome;
  private double preco; // o valor por hora do serviço
  private string descricao;
  private Categoria categor;
}
class Categoria{ //Icomparable
  private int id;
  private string nome;
}
class Solicitacoes{ //Icomparable
  private int id;
  private int idPrestador;
  private int idCliente;
  private int idServico;
  private Servico service;
  //get set ?
  public void InserirS(Servico s){ //inserir servico na solicitacao
    
  }
}