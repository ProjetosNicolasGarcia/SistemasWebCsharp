namespace ExercicioAlunos;

class Alunos
{
    public string nome="";

    public double numero1, numero2;

    //media - retorna double

    public double obterMedia(){
    double media = (numero1+numero2)/2;
    return media;
}

    //situação - retorna string (aprovado ou reprovado)

    public string obterSituacao(double media){
        string situacao="";
        if(media>=6){
            situacao="aprovado";
        }else{
            situacao="reprovado";
        }
        return situacao;
    }

    //mensagem - não retorna nada

    public void mensagem(){
        double mediaCalculada = obterMedia();
        string resultadoSituacao = obterSituacao(mediaCalculada);
        Console.WriteLine(nome+" está "+resultadoSituacao+" com média: "+mediaCalculada);
    }
}


