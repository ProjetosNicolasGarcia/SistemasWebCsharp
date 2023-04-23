namespace Bancoemprestimo;

class Bancoemprestimo
{
    private double Saldo{get; set;}
    public double Limite{get; private set;}

   
    public void Depositar(double valor){
        this.Saldo += valor;
    }

    public void Sacar(double valor){
        if(valor > this.Saldo+this.Limite){
            Console.WriteLine("Você não possui esse valor para saque");}
            
        else{ 
            this.Saldo -= valor;
            Console.WriteLine("Saque feito com sucesso");
        }
    }

    public double MostraSaldo(){
        return this.Saldo+this.Limite;
    }

    public void AjustaLimite(double valor){
        this.Limite = valor;
    }

}

