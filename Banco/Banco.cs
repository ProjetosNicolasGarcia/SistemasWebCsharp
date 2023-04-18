namespace Banco;
class Banco
{
    public double Valor;

    public double ObterJuros(){
        double Juros = ((Valor *0.06)*12) + Valor;
        return Juros;
    }

    public double Mensal(){
        double Mes = ((Valor *0.06) + Valor/12);
        return Mes;
    }





}
