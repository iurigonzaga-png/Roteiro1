using System;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos e sou {Cargo}.");
    }
    public void InformarSalario()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine("Salário: R$ 10.000,00");
        }
        else if (Cargo == "Desenvolvedor")
        {
            Console.WriteLine("Salário: R$ 5.000,00");
        }
        else if (Cargo == "Estagiário")
        {
            Console.WriteLine("Salário: R$ 100,00");
        }
        else
        {
            Console.WriteLine("Cargo não existe");
        }
    }
}
public class Program
{
    public static void Main()
    {
        Pessoa gerente = new Pessoa();
        gerente.Nome = "Ana";
        gerente.Idade = 40;
        gerente.Cargo = "Gerente";

        Pessoa dev = new Pessoa();
        dev.Nome = "Carlos";
        dev.Idade = 28;
        dev.Cargo = "Desenvolvedor";

        Pessoa estagiario = new Pessoa();
        estagiario.Nome = "Lucas";
        estagiario.Idade = 20;
        estagiario.Cargo = "Estagiário";

        gerente.Apresentar();
        gerente.InformarSalario();

        dev.Apresentar();
        dev.InformarSalario();

        estagiario.Apresentar();
        estagiario.InformarSalario();
    }
}
