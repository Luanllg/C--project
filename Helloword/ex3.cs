using System;
using Biblioteca;
using Microsoft.VisualBasic;
class ex3
{
    static void Main()
    {
            Console.WriteLine("Informe o tamanho do vetor:");
            int n = int.Parse(Console.ReadLine() ?? "0");

            float[] vetor = new float[n];
           
            for (int i = 0; i < n; i++)
            {  //tive que usar "System.Globalization.CultureInfo.InvariantCulture" pois não estava funcionadno, adicionei o sistema global e resolveu o problema!
                Console.Write($"Digite o valor {i + 1}: ");
                vetor[i] = float.Parse(Console.ReadLine() ?? "0", System.Globalization.CultureInfo.InvariantCulture);
            }

                Console.WriteLine("Vetor gerado:");
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write(vetor[i] + " ");
                }
                Console.WriteLine();

            float menor = MenorElemento(vetor);
            Console.WriteLine($"Menor elemento do vetor: {menor}");
    }

        static float MenorElemento(float[] vetor)
        {
            float menor = vetor[0];
            for (int i = 1; i < vetor.Length; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];
            }
            return menor;
        }
}