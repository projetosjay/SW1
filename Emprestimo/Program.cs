﻿namespace Emprestimo;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Atividade Avaliativa");
        Emprestimo agencia = new Emprestimo();

        agencia.meses = 12;

        agencia.dinheiro = 1000;

        agencia.depositar(0);

        agencia.saque(0);
        

        double saldo = (agencia.juros() + agencia.emprestimo())* agencia.meses;
        Console.WriteLine("Total é R$" + saldo);

        
    }
}    