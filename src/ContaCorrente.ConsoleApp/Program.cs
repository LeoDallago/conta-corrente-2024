﻿namespace ContaCorrente.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Random valorAleatorio = new Random();

        ContaCorrente novaConta = new ContaCorrente();
        ContaCorrente conta2 = new ContaCorrente();

        #region Atribuicao de valores
        novaConta.titular.nomeCliente = "Fulano";
        novaConta.titular.sobreNomeCliente = "Beltrano";
        novaConta.titular.cpfCliente = "112.112.112-00";

        novaConta.numeroConta = valorAleatorio.Next(0, 250);
        novaConta.tipoConta = "Gold";

        novaConta.saldo = 3000;
        novaConta.limiteConta = 5000;
        #endregion

        #region Atribuicao de valores
        conta2.titular.nomeCliente = "ciclano";
        conta2.titular.sobreNomeCliente = "tal";
        conta2.titular.cpfCliente = "212.212.212-11";

        conta2.numeroConta = valorAleatorio.Next(0, 250);
        conta2.tipoConta = "Silver";

        conta2.saldo = 1000;
        conta2.limiteConta = 2500;
        #endregion

        #region Realizando Saque
        Console.WriteLine($"valor do saldo original {novaConta.saldo}");
        novaConta.Saque(300);
        Console.WriteLine($"Valor apos o saque {novaConta.saldo}");

        Console.ReadLine();
        #endregion

        #region Realizando Deposito
        Console.WriteLine("\nAgora vamos para o deposito!");
        Console.WriteLine($"Valor antes do deposito {novaConta.saldo}");
        novaConta.Deposito(1000);
        Console.WriteLine($"o valor depois do deposito {novaConta.saldo}");
        #endregion

        #region Realiza Tranferencia
        Console.ReadLine();

        Console.WriteLine("\nIniciando transferencia de 200");
        novaConta.Transferencia(200, conta2);
        Console.WriteLine($"valor da conta 1 {novaConta.saldo}");
        Console.WriteLine($"valor da conta 2 {conta2.saldo}");
        #endregion

        #region Realiza Extrato
        Console.ReadLine();

        Console.WriteLine("\nAgora vamos para as informações da conta");
        novaConta.VisualizarExtrato();
        #endregion

        Console.ReadLine();
    }

}
