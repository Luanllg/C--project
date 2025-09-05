using System;
class string11
{
    static void Main()
    {
        string frase;

        Console.WriteLine("Digite uma frase codificada em lingua do p:");
        frase = Console.ReadLine() ?? "";

        string resultado = Decodificar(frase);
        Console.WriteLine("Frase decodificada:" + resultado);


    }
    static string Decodificar(string codificado)
    {
        char[] frasecodificada = new char[codificado.Length];
        int s = codificado.Length;
        int pos = 0;
        for (int i = 0; i < s; i++)
        {
            if (codificado[i] != 'p')
            {
                frasecodificada[pos] = codificado[i];
                pos++;
            }
            else if (codificado[pos] == 'p' && i + 1 < s && codificado[i + 1] == 'p')
            {
                frasecodificada[pos] = 'p';
                pos++;

             
            }
        }
        return new string(frasecodificada, 0, pos);
    }
}

  