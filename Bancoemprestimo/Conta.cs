  namespace banco;
class Conta
{
   public int Numero {get; set;}
   private double Saldo {get;  set;}

   public double Limite {get; private set;}

   public void Depositar(double valor){
    this.Saldo += valor;
   }

     public void Sacar(double valor){
        if(valor > this.Saldo + this.Limite) {
            Console.WriteLine("Você não pode realizar essa operação, o saldo é insuficiente");
        } else{
             this.Saldo -= valor;
        }
   
   }

   public double MostrarSaldo(){
    return this.Saldo + this.Limite;
   }

   public void AjustaLimite(double valor){
    this.Limite = valor;
   }

   // emprestimo

   public double ValEmprestimo {get; set;}
   public double Prazo {get; set;}

       public string Emprestimo(double emprestimo, int Prazo){
        this.ValEmprestimo = emprestimo;
        this.Prazo = Prazo;
        double parcelaSemJuros = this.ValEmprestimo / this.Prazo;
        double Juros = this.ValEmprestimo * 0.06;
        double ParcelaJuros = parcelaSemJuros + Juros;
        double Total = ParcelaJuros * this.Prazo;
        string resultado = "O valor do seu empréstimo total é de: " + Total;

        return resultado;
    }

    public void imprime(string texto){
        Console.WriteLine(texto);
    }
}





