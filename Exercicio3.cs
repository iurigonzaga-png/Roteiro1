using System;
public class Produto
{
    public string Nome;
    public decimal Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Produto: {Nome} Preço: {Preco:C} Quantidade em estoque: {Quantidade}");
    }

    public decimal CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}
public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.Nome = "Monitor";
        p1.Preco = 850.00m;
        p1.Quantidade = 2;

        Produto p2 = new Produto();
        p2.Nome = "Teclado";
        p2.Preco = 150.00m;
        p2.Quantidade = 5;

        Produto p3 = new Produto();
        p3.Nome = "Mouse";
        p3.Preco = 80.00m;
        p3.Quantidade = 10;

        p1.ExibirDados();
        Console.WriteLine($"Valor total: {p1.CalcularValorTotal():C}\n");

        p2.ExibirDados();
        Console.WriteLine($"Valor total: {p2.CalcularValorTotal():C}\n");

        p3.ExibirDados();
        Console.WriteLine($"Valor total: {p3.CalcularValorTotal():C}\n");
    }
}
