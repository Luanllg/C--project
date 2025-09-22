using System;
using Biblioteca;
class ex9
{
    static void Main()
    {
        int tamanhovetor;
        Console.WriteLine("Entre com o tamanho do vetor:");
        tamanhovetor = int.Parse(Console.ReadLine());
        char[] vetor = new char[tamanhovetor];


        Console.WriteLine("Entre com os elementos do vetor:");
        for (int i = 0; i < tamanhovetor; i++)
        {
            Console.Write($"Vetor[{i}]: ");
            vetor[i] = char.Parse(Console.ReadLine());
        }



        Console.WriteLine("Vetor em posição ordem inversa:");
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");



        }
    }
}