﻿namespace banco;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Banco Etec MCM");
        Conta c = new Conta();
       c.Depositar(1500);
        c.AjustaLimite(500);
        c.Sacar(5000); 
        Console.WriteLine("Seu saldo é de: " + c.MostrarSaldo());

        // emprestimo

        c.imprime(c.Emprestimo(1000, 12));


      
    }
}
