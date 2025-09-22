using System;
using Biblioteca; 
class ex6
{
    static void Main()
    {
        Console.WriteLine("Informe o tamanho do vetor:");
        int tamanho = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine("Digite um número para verificar se está no vetor:");
        int numero = int.Parse(Console.ReadLine() ?? "0");

        int[] vetor = new int[tamanho];

        Biblioteca.BibliotecaVetor.gerarVetor(vetor);
       
        Biblioteca.BibliotecaVetor.mostrarVetor(vetor);

         // usei para percorrer meu vetor e encontrar sua posição, retornando -1 caso não achar
        int posicao = Array.IndexOf(vetor, numero);

        if (posicao >= 0)
        {
            Console.WriteLine($"O número {numero} está no vetor na posição {posicao}.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não está no vetor.");
        }
    }
}

