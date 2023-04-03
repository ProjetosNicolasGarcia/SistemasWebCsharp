namespace Aeroporto;
class Aeroporto
{   

     public Aeroporto()
    {
        this.Codigo = 0;
        this.Nome = "Não informado";
        this.Entrada = "Não informado";
        this.Saida = "Não informado";
        
    }

    public Aeroporto(int codigo, string nome)
    {
        this.Codigo = 0;
        this.Nome = "Não informado";
        this.Entrada = "Não informado";
        this.Saida = "Não informado";
        
    }



     private int Codigo {get; set;}
     private string? Nome {get; set;}
     private string? Entrada {get; set;}
     private string? Saida {get; set;}

      public void AlteraCodigo(int codigo){
        this.Codigo = codigo;
    }

    public void AlteraNome(string nome){
        this.Nome = nome;
    }

    public void AlteraEntrada(string entrada){
        this.Entrada = entrada;
    }

    public void AlteraSaida(string saida){
        this.Saida = saida;
    }

  public void MostraDados(){
        Console.WriteLine("Código: " + this.Codigo);
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Entrada: " + this.Entrada);
        Console.WriteLine("Entrada: " + this.Saida);

    }

    internal void AlteraCodigo()
    {
        throw new NotImplementedException();
    }
}
