using System;

namespace bank_oo
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioPIVAS = new Funcionario();
            funcionarioPIVAS.Nome = "PIVAS";
            funcionarioPIVAS.CPF = "123.123.143-73";
            funcionarioPIVAS.Cargo = "Vendedor";
            funcionarioPIVAS.Salario = 550;

            Funcionario funcionarioJOSEFINA = new Funcionario();
            funcionarioJOSEFINA.Nome = "JOSEFINA";
            funcionarioJOSEFINA.CPF = "346.236.4326-23";
            funcionarioJOSEFINA.Cargo = "Vendedora";
            funcionarioJOSEFINA.Salario = 550;

            ContaCorrente contaDoPIVAS = new ContaCorrente("PIVAS", 1234, 1230, funcionarioPIVAS); 
            ContaCorrente contaDoSOUZA = new ContaCorrente("SOUZA", 1234, 1050, funcionarioJOSEFINA); 
            ContaCorrente contaDoGABRIEL = new ContaCorrente("GABRIEL", 1234, 1500, funcionarioJOSEFINA); 

            Console.WriteLine("O titular da conta é: "+contaDoPIVAS.Titular);
            Console.WriteLine("O saldo da conta da "+ contaDoPIVAS +" é: " + contaDoPIVAS.Saldo);
            Console.WriteLine("O vendedor responsável foi o: " + funcionarioPIVAS.Nome);

            Console.WriteLine("O titular da conta é: "+contaDoSOUZA.Titular);
            Console.WriteLine("O saldo da conta da "+contaDoSOUZA+" é: " + contaDoSOUZA.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + funcionarioJOSEFINA.Nome);

            Console.WriteLine("O titular da conta é: "+contaDoGABRIEL.Titular);
            Console.WriteLine("O saldo da conta do GABRIEL é: " + contaDoGABRIEL.Saldo);
            Console.WriteLine("O vendedor responsável foi a: " + funcionarioJOSEFINA.Nome);

            Console.WriteLine("---------------------------------------------------");

            //Saque
            contaDoPIVAS.Sacar(30);
            Console.WriteLine("Operação de saque, num valor de R$ 30,00");
            Console.WriteLine("O saldo atual da conta da "+contaDoPIVAS+" é: " + contaDoPIVAS.Saldo);

            Console.WriteLine("---------------------------------------------------");
            
            //Trasferencia
            contaDoPIVAS.Transferir(100, contaDoGABRIEL);
            Console.WriteLine("Operação de tranferência, num valor de R$ 100,00 do PIVAS para o GABRIEL.");
            Console.WriteLine("O saldo da conta da "+contaDoPIVAS+" é: " + contaDoPIVAS.Saldo);
            Console.WriteLine("O saldo da conta da GABRIEL é: " + contaDoGABRIEL.Saldo);

            Console.WriteLine("---------------------------------------------------");

            //Deposito
            contaDoSOUZA.Depositar(75);
            Console.WriteLine("Operação de Despósito, num valor de R$ 75,00");
            Console.WriteLine("O saldo da conta da "+contaDoSOUZA+"é: " + contaDoSOUZA.Saldo);

            Console.WriteLine("---------------------------------------------------");
            
            
            Console.WriteLine("A comissao do Vendedor PIVAS é: " + funcionarioPIVAS.Comissao);
            Console.WriteLine("A comissao da Vendedora JOSEFINA é: " + funcionarioJOSEFINA.Comissao);

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Total de contas criadas: " + ContaCorrente.TotalDeContasCriadas);
            Console.WriteLine("Total de comissão a ser pago: " + ContaCorrente.TotalDeComissao);
        }
    }

}