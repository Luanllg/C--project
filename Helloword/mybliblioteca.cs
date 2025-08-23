using System;
namespace Biblioteca
{
	public class BibliotecaVetor
	{
		// Lê os valores do vetor a partir do usuário
		public static void lerVetor(int[] vetor)
		{
			Console.WriteLine("Entre com os dados do vetor:");
			for (int i = 0; i < vetor.Length; i++)
			{
				Console.Write($"Array[{i}]: ");
				vetor[i] = int.Parse(Console.ReadLine() ?? "0");
			}
		}

		// Gera valores aleatórios para o vetor
		public static void gerarVetor(int[] vetor)
		{
			Random aleatorio = new Random();
			for (int i = 0; i < vetor.Length; i++)
			{
				vetor[i] = aleatorio.Next(1, 100);
			}
		}

		// Mostra os valores do vetor
		public static void mostrarVetor(int[] vetor)
		{
			Console.WriteLine("Dados do Vetor:");
			for (int i = 0; i < vetor.Length; i++)
			{
				Console.Write($"|{vetor[i]}");
			}
			Console.WriteLine(); // Quebra de linha ao final
		}
	}
}