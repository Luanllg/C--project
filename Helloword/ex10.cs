using System;
using Biblioteca;


class ex10
{
    static void Main()
    {
      
        Console.WriteLine("Quantas vezes o dado foi lançado?");
        int numerodelancamentos = int.Parse(Console.ReadLine());
        int[] resultados = new int[numerodelancamentos];



        Console.WriteLine("Entre com os resultados dos lançamentos (valores entre 1 e 6):");
        for (int i = 0; i < numerodelancamentos; i++)
        {
            Console.Write($"Lançamento {i + 1}: ");
            resultados[i] = int.Parse(Console.ReadLine());
            while (resultados[i] < 1 || resultados[i] > 6)
            {
                Console.WriteLine("Valor inválido apenas entre 1 e 6.");
                Console.Write($"Lançamento {i + 1}: ");
                resultados[i] = int.Parse(Console.ReadLine());
            }
        }

        int[] contaresultado = new int[6];

        for (int i = 0; i < numerodelancamentos; i++)
        {
            contaresultado[resultados[i] - 1]++;
        }

        Console.WriteLine("Contagem de ocorrências de cada face:");
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Face {i + 1}: {contaresultado[i]} ocorrência(s)");
        }
    }
}