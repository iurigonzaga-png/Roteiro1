using System;

public class Fantasma
{
    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"Fantasma gerado - Nick: {Nick}, Cor: {Cor}, Habilidade: {Habilidade}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}.");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasma blinky = new Fantasma();
        blinky.Nick = "Blinky";
        blinky.Cor = "Vermelho";
        blinky.Habilidade = "Perseguir";
        blinky.GerarFantasma();
        blinky.Mover("cima");
        blinky.Mover("esquerda");

        Console.WriteLine();
        Fantasma pinky = new Fantasma();
        pinky.Nick = "Pinky";
        pinky.Cor = "Rosa";
        pinky.Habilidade = "Emboscada";

        pinky.GerarFantasma();
        pinky.Mover("baixo");
    }
}
