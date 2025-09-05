using System;
class string5
{

static string complemento(string dna)
{
    string complemento = "";
    string maiusculo = dna.ToUpper();
    for (int i = 0; i < maiusculo.Length; i++)
        {
            switch (maiusculo[i])
            {
                case 'A':
                    complemento += 'T';
                    break;
                case 'T':
                    complemento += 'A';
                    break;
                case 'C':
                    complemento += 'G';
                    break;
                case 'G':
                    complemento += 'C';
                    break;
                default:
                    complemento += '-';
                    break;
            }
        }
    return complemento;
}

    static void Main()
    {
        char[] vetor = new char[50];
        Console.WriteLine("Digite os elementos da fita de dna (A, T, C, G):");
        string dna = (Console.ReadLine() ?? "").ToUpper();
       
      
          if (dna.Length > 50)
        dna = dna.Substring(0, 50);
        
        for (int i = 0; i < dna.Length; i++)
        {
            vetor[i] = dna[i];
        }
       
        for (int i = dna.Length; i < 50; i++)
        {
            vetor[i] = 'N';
        }
        string complementoDna = complemento(new string(vetor));
        Console.WriteLine("O complemento da fita de dna é: " + complementoDna);
    }
}