namespace Bancoemprestimo;
class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Conta bancaria");
        Bancoemprestimo bancoemprestimo = new Bancoemprestimo();

        bancoemprestimo.Depositar(500);
        bancoemprestimo.AjustaLimite(500);
        bancoemprestimo.Sacar(900);

        Console.WriteLine("Valor total na sua conta: "+ bancoemprestimo.MostraSaldo());
    }
}

