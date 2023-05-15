namespace exercicio03;
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
        cj.Prazo = 12;
        cf.Prazo = 12;
       

        Console.WriteLine("Tipo de contrato: " + cf.Tipo + "| Idade: " + cf.Idade + "| CPF: " +cf.Cpf + "| Valor do contrato: " + c.CalcularPrestacao() + "| Prazo de pagamento: "+ cf.Prazo + "| Valor das prestações: " + cf.CalcularPrestacao());
        Console.WriteLine("Tipo de contrato: " + cj.Tipo + "| CNPJ: " + cj.Cnpj + "| Inscrição estadual: " +cj.Inscricao + "| Valor do contrato: " + c.CalcularPrestacao() + "| Prazo de pagamento: " + cj.Prazo + "| Valor das prestações: " + cj.CalcularPrestacao());
        
    }
} 

