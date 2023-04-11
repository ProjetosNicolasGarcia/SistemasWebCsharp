namespace agregacao;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Trabalhando com Agregação");

        Cartao cdc = new Cartao();
        Cliente cli = new Cliente();

        cli.Nome = "Nicolas Garcia";

        cdc.Numero= "509875017410712";

        cdc.DataValidade = "08/2026";

        cdc.Cliente = cli;

        Console.WriteLine("O nome do cliente é: " + cli.Nome );
        Console.WriteLine("O número do cartão é: " + cdc.Numero);
         Console.WriteLine("A data de validade é: " + cdc.DataValidade);
        Console.WriteLine("O nome do cliente AGREGADO é: " + cdc.Cliente.Nome);
    }
}
