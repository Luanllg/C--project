using System;
using Biblioteca;
class ex7
{
    static int[] multiplicaoevetores(int[] arrayA, int[] arrayB)
    {
        int[] arrayC = new int[arrayA.Length];
        for (int i = 0; i < arrayA.Length; i++)
        {
            arrayC[i] = arrayA[i] * arrayB[i];
            //anotaçõa: Como os dois tem o mesmo tamanho posso usar qualquer um deles para usar como referencia
        }
        return arrayC;
    }
    static void Main()
    {
        Console.WriteLine("informe o tamnanho do vetor:");
        int tamnanhon = int.Parse(Console.ReadLine());
        int[] vwtorA = new int[tamnanhon];
        int[] vwtorB = new int[tamnanhon];

        BibliotecaVetor.gerarVetor(vwtorA);
        BibliotecaVetor.mostrarVetor(vwtorA);

        BibliotecaVetor.gerarVetor(vwtorB);
        BibliotecaVetor.mostrarVetor(vwtorB);

        int[] vetorC =new int[tamnanhon];
        vetorC = multiplicaoevetores(vwtorA, vwtorB);
        BibliotecaVetor.mostrarVetor(vetorC);
       
       

    }
}