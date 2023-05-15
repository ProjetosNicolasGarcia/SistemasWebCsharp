namespace exercicio02;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPessoaFisica cf = new ContratoPessoaFisica();
        ContratoPessoaJuridica cj = new ContratoPessoaJuridica();

        cf.Tipo = "Pessoa física";
        cf.Idade = 69;
        cf.Cpf = 44149248800;
        cj.Tipo = "Pessoa Jurídica";
        cj.Cnpj = 42520353000162;
        cj.Inscricao = 037689759148;

        Console.WriteLine("Tipo de contrato: " + cf.Tipo + " -- Idade: " + cf.Idade + " -- CPF: " +cf.Cpf);
        Console.WriteLine("Tipo de contrato: " + cj.Tipo + " -- CNPJ: " + cj.Cnpj + " -- Inscrição estadual: " +cj.Inscricao);
    }
} 

