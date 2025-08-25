using System;
using Biblioteca;


class ex2
{
    static void Main()
    {

        Console.WriteLine("Informe o tamanho do vetor:");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor = new int[n];

        Biblioteca.BibliotecaVetor.gerarVetor(vetor);
        Biblioteca.BibliotecaVetor.mostrarVetor(vetor);
        int impares = ContarImpares(vetor);
        Console.WriteLine($"Quantidade de valores ímpares: {impares}");
    }

    static int ContarImpares(int[] vetor)
    {
        int contador = 0;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] % 2 != 0)
                contador++;
        }
        return contador;
    }
    }