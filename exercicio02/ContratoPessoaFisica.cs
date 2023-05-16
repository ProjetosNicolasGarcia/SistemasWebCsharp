namespace exercicio02;
class ContratoPessoaFisica:Contrato
{

   public long Cpf {get;set;}

   public int Idade {get;set;}

    public override string MostraDados(){
          string Tudo = this.Nome + "-" + this.Email + "-" + this.Telefone + "-" + this.Idade + "-" + this.Cpf;
          return Tudo;
    }

}

