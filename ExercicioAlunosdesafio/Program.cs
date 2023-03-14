namespace ExercicioAlunos;
class Program
{
    static void Main(string[] args)
    {

      Alunos aluno1 = new Alunos();

      Console.WriteLine("Digite seu nome: ");
       aluno1.nome = Console.ReadLine();
      Console.WriteLine("O nome digitado foi: "+aluno1.nome);

      // recebendo um número do tipo double

      Console.WriteLine("Digite um número double: ");
       aluno1.numero1 = Double.Parse(Console.ReadLine());
      Console.WriteLine("O número digitado foi: "+aluno1.numero1);

      Console.WriteLine("Digite um número double: ");
       aluno1.numero2 = Double.Parse(Console.ReadLine());
      Console.WriteLine("O número digitado foi: "+aluno1.numero2);

    aluno1.mensagem();

    }
}
