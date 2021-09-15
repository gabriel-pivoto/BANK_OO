
using System;

namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDoPivas = new ContaCorrente("Pivas", 1234, 789, 100.50);

            ContaCorrente contaDoJoao = new ContaCorrente("Joao", 1234, 790, 120);

            ContaCorrente contaDaMaria = new ContaCorrente("Maria", 1234, 791, 150);

            Console.WriteLine("O titular da conta é: " + contaDoPivas.titular);
            Console.WriteLine("O titular da conta é: " + contaDoJoao.titular);
            Console.WriteLine("O titular da conta é: " + contaDaMaria.titular);

            contaDoPivas.Sacar(50);
            contaDaMaria.Sacar(20);

            Console.WriteLine("O saldo da conta do Pivas é: " + contaDoPivas.saldo);
            Console.WriteLine("O saldo da conta da Maria é: " + contaDaMaria.saldo);

            contaDoPivas.Depositar(150);
            Console.WriteLine("O saldo da conta do Pivas é:" + contaDoPivas.saldo);
        }
    }
}