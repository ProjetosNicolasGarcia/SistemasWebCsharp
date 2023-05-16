namespace exercicio03;
class ContratoPessoaFisica:Contrato
{

 public long Cpf {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
          string Tudo = this.Nome + "-" + this.Email + "-" + this.Telefone + "-" + this.Idade + "-" + this.Cpf;
          return Tudo;
    }
public override double CalcularPrestacao(){
    if (Idade <= 30)
    {
        return ((base.CalcularPrestacao()/Prazo)+1);
    }
    else if (Idade <= 40) 
    {
        return ((base.CalcularPrestacao()/Prazo)+2);
    }
    else if (Idade <= 50) 
    {
        return ((base.CalcularPrestacao()/Prazo)+3);
    }
    else 
    {
        return ((base.CalcularPrestacao()/Prazo)+4);
    }
}
  
}