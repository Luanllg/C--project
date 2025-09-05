using System;

class string11
{
    static void Main()
    {
        Console.WriteLine("Digite a mensagem codificada:");
        string codificada = Console.ReadLine() ?? "";
        string decodificada = DecodificarLinguaDoP(codificada);
        Console.WriteLine("Mensagem decodificada: " + decodificada);
    }

    static string DecodificarLinguaDoP(string texto)
    {
        string resultado = "";
        int i = 0;
        while (i < texto.Length)
        {
            char c = texto[i];
            resultado += c;
            if ("AEIOUaeiou".Contains(c) && i + 2 < texto.Length && texto[i + 1] == 'p' && texto[i + 2] == c)
            {
                i += 3; 
            }
            else
            {
                i++;
            }
        }
        return resultado;
    }
}