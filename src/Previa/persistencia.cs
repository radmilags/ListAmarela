using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Persistencia<T>
{
  public List<T> AbrirArquivo(string arquivo)
  {
    List<T> obj;
    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
    StreamReader dados = null;
    try {
      dados = new StreamReader(arquivo);
      obj = (List<T>) xml.Deserialize(dados);
    } catch (Exception){
      obj = new List<T>();
    }
    if (dados != null) dados.Close();
    return obj;
  }


  
  public void SalvarArquivo(string arquivo, List<T> obj) {
    XmlSerializer xml = new XmlSerializer(typeof(List<T>));
    StreamWriter dados = new StreamWriter(arquivo, false);
    xml.Serialize(dados, obj);
    dados.Close();
  }
}
