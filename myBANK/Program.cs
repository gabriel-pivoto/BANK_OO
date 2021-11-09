using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

             Gerente gerenteJose = new Gerente (){

                Nome = "José",
                CPF = "427.427.427-98",
                Salario = 5000 ,
                NumeroDeAgencias = 4
            };
             gerenteJose.Bonificacao = gerenteJose.Salario;

            Vendedor vendedorPedro = new Vendedor()
            {
                Nome = "Pedro",
                CPF = "223.223.983-52",
                Salario = 3000 ,
                NumeroClientesAtendidos = 4
            };
            vendedorPedro.Bonificacao = vendedorPedro.Salario;

            Vendedor vendedorJorge = new Vendedor()
            {
                Nome = "Jorge",
                CPF = "531.423.234-51",
                Salario = 5000 ,
                NumeroClientesAtendidos = 5
            };
            vendedorJorge.Bonificacao = vendedorJorge.Salario;

            Vendedor vendedorJoao = new Vendedor()
            {
                Nome = "João",
                CPF = "333.333.333-33" ,
                Salario = 3333 ,
                NumeroClientesAtendidos = 3
            };
            vendedorJoao.Bonificacao = vendedorJoao.Salario;

            ContaCorrente contaGabriel = new ContaCorrente ("Gabriel de Souza Pivoto","231.123.324-13",111,10000,vendedorJorge);
            contaGabriel.Conta = 1111;

            ContaCorrente contaLaura = new ContaCorrente ("Laura","234.253.642-67",111,4500,vendedorJorge);
            contaGabriel.Conta = 2222;

            ContaCorrente contaAna = new ContaCorrente ("Ana Julia","234.536.764-11",111,4500,vendedorJoao);
            contaGabriel.Conta = 3333;
           
            
            Console.WriteLine("----- Contas Correntes -----");
            Console.WriteLine("Conta 1: \nNome: " + contaGabriel.Titular + ";" + "\nCPF: " + contaGabriel.CPF + ";" + "\nAgência: " + contaGabriel.Agencia + ";" + "\nConta: " + contaGabriel.Conta + ";" + "\nSaldo: R$" + contaGabriel.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 2: \nNome: " + contaLaura.Titular + ";" + "\nCPF: " + contaLaura.CPF + ";" + "\nAgência: " + contaLaura.Agencia + ";" + "\nConta: " + contaLaura.Conta + ";" + "\nSaldo: R$" + contaLaura.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 3: \nNome: " + contaAna.Titular + ";" + "\nCPF: " + contaAna.CPF + ";" + "\nAgência: " + contaAna.Agencia + ";" + "\nConta: " + contaAna.Conta + ";" + "\nSaldo: R$" + contaAna.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----- Funcinários -----");
            Console.WriteLine("Vendedor 1: \nNome: " + vendedorPedro.Nome + ";" + "\nCPF: " + vendedorPedro.CPF + ";" + "\nSalário: R$" + vendedorPedro.Salario + ";" + "\nBonificação Anual R$: " + vendedorPedro.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorPedro.RemuneracaoTotal(vendedorPedro.Salario,vendedorPedro.Bonificacao) + ";" + "\nDias de Férias: " + vendedorPedro.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 2: \nNome: " + vendedorJorge.Nome + ";" + "\nCPF: " + vendedorJorge.CPF + ";" + "\nSalário: R$" + vendedorJorge.Salario + ";" + "\nBonificação Anual R$: " + vendedorJorge.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorJorge.RemuneracaoTotal(vendedorJorge.Salario,vendedorJorge.Bonificacao) + ";" + "\nDias de Férias: " + vendedorJorge.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 3: \nNome: " + vendedorJoao.Nome + ";" + "\nCPF: " + vendedorJoao.CPF + ";" + "\nSalário: R$" + vendedorJoao.Salario + ";" + "\nBonificação Anual R$: " + vendedorJoao.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + vendedorJoao.RemuneracaoTotal(vendedorJoao.Salario,vendedorJoao.Bonificacao) + ";" + "\nDias de Férias: " + vendedorJoao.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Gerente : \nNome: " + gerenteJose.Nome + ";" + "\nCPF: " + gerenteJose.CPF + ";" + "\nSalário: R$" + gerenteJose.Salario + ";" + "\nBonificação Anual R$: " + gerenteJose.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + gerenteJose.RemuneracaoTotal(gerenteJose.Salario,gerenteJose.Bonificacao) + ";" + "\nDias de Férias: " + gerenteJose.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Total de contas criadas:" + ContaCorrente.TotalContaCriadas + ".");
        }}}