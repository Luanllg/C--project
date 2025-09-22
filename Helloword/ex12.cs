using System;
using Biblioteca;
class ex12
{


    
    static void Main()
    {
        Console.WriteLine("Boa sorte nas suas notas!");
        float[] notas = new float[5];
        for(int i=0;i<=4;i++)
        {
         Console.WriteLine($"Digite o valor da {i+1} nota:(5 a 10)");
         notas[i]=float.Parse(Console.ReadLine());
         
        }
        for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int j = 0; j < notas.Length - i - 1; j++)
                {
                    if (notas[j] > notas[j + 1])
                    {
                        float troca = notas[j];
                    notas[j] = notas[j + 1];
                        notas[j + 1] = troca;
                    }
                }
            }
           

        double notafinal= notas[1]+notas[2]+notas[3];
        Console.WriteLine($"{notafinal:F2}");

   }
}