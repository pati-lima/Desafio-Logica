using System;
using System.Text;

public class Desafio2
{
    public static void Main(string[] args)
    {
      Console.WriteLine("Digite a string:");
      string frase = Console.ReadLine();
      frase = frase.Trim();
      frase = frase.ToLower();
      byte maior = 0;
      byte[] ASCIIvalues = Encoding.ASCII.GetBytes(frase);
            foreach(var value in ASCIIvalues)
            {
                if(value > maior)
                    maior = value;
            }
            var maiorChar = Convert.ToChar(maior);
            Console.WriteLine($"Maior letra:{maiorChar}");
    }
}