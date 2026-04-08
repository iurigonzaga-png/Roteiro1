using System;

public class ContaBancaria
{
    public string Titular;
    public string NumeroConta;

    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
            Console.WriteLine($"Depósito de {valor:C} realizado na conta de {Titular}.");
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > Saldo)
        {
            Console.WriteLine($"Saque negado. Saldo insuficiente na conta de {Titular}.");
        }
        else if (valor > 0)
        {
            Saldo -= valor;
            Console.WriteLine($"Saque de {valor:C} realizado na conta de {Titular}.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Saldo atual da conta {NumeroConta} ({Titular}): {Saldo:C}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Titular = "João";
        conta1.NumeroConta = "12345-6";

        ContaBancaria conta2 = new ContaBancaria();
        conta2.Titular = "Maria";
        conta2.NumeroConta = "98765-4";

        conta1.Depositar(500.00m);
        conta1.Sacar(200.00m);
        conta1.Sacar(400.00m);
        conta1.ExibirSaldo();

        Console.WriteLine();

        conta2.Depositar(1000.00m);
        conta2.Sacar(150.00m);
        conta2.ExibirSaldo();
    }
}
