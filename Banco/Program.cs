namespace Banco;
class Program
{
    static void Main(string[] args){
        Banco banco = new Banco(); 
        Console.Write("Digite o valor do seu empréstimo: ");
        banco.Valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Seu empréstimo é" + banco.Valor);
        Console.WriteLine("Seus juros do emprestimo" + banco.ObterJuros());
        Console.WriteLine("Seus juros serão de " + banco.Mensal() + "por mês");
        
    }

}
