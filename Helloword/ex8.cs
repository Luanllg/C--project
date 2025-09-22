using System;
using Biblioteca;
class ex8
{
    static int numerodeocorrencias(int[] arrayA, int numero)
    {
        int contador = 0;
        for (int i = 0; i < arrayA.Length; i++)
        {
            if (arrayA[i] == numero)
            {
                contador++;
            }
        }
        return contador;
    }// minha função para guaradar a quantidae de ocorrencias
    static void Main()
    {
        Console.WriteLine("Informe o tamanho do vetor:");
        int tamanhovetor = int.Parse(Console.ReadLine());
       
        int[] vetorA = new int[tamanhovetor];
       
       
        BibliotecaVetor.gerarVetor(vetorA);

        Console.WriteLine("Informe o numero que deseja saber a quantidade de ocorrencias:");
        int numero = int.Parse(Console.ReadLine());

       //chamado da função
        int quantidade = numerodeocorrencias(vetorA, numero);
       
        Console.WriteLine($"O número digitado foi {numero} e ele apareceu {quantidade} vezes no vetor");
       
        BibliotecaVetor.mostrarVetor(vetorA);
    }//meu metodo main para pedir e mostrar valores
} 