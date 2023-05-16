namespace exercicio02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Nome = "Nicolas";
        cf.Email = "nicolas@gmail.com";
        cf.Telefone = "40028922";
        cf.Idade = 69;
        cf.Cpf = 44149248800;
        cj.Nome = "ETEC";
        cj.Email = "etec@gmail.com";
        cj.Telefone = "77776666";
        cj.Cnpj = 42520353000162;
        cj.Inscricao = 037689759148;

        Console.WriteLine(cf.MostraDados());
        Console.WriteLine(cj.MostraDados());
    }
} 

