using System;

class somavetor
{
    static void Main()
    {
        Console.WriteLine("Informe o tamanho do vetor:");
        int myvetor = int.Parse(Console.ReadLine());
        int[] vetor = new int[myvetor];

        for (int i = 0; i < myvetor; i++)
        {
            Console.WriteLine($"Digite o valor para a posição {i}:");
            vetor[i] = int.Parse(Console.ReadLine() ?? "0");
        }

        int soma = SomaVetor(vetor);
        Console.WriteLine($"A soma dos elementos é: {soma}");
    }

    static int SomaVetor(int[] vetor)
    {
        int soma = 0;
        foreach (int valor in vetor)
        {
            soma += valor;
        }
        return soma;
    }
}