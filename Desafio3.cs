using System;
using System.Text;

public class Desafio3
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Digite o nome:");
        
        string nome = Console.ReadLine();
        string primeiro = "";
        string meio = " "; 
        string ultimo = "";

        string[] nomes = nome.Split(' ');  espaço.

        primeiro = nomes[0]; 

        for (int i = 1; i < nomes.Length - 1; i++) 
        {
            if (!nomes[i].ToLower().Equals("de") && !nomes[i].ToLower().Equals("da") && !nomes[i].ToLower().Equals("do") && !nomes[i].ToLower().Equals("das") && !nomes[i].ToLower().Equals("dos"))
            {
                meio += nomes[i].Substring(0, 1); 
                meio += ". "; 
            }
        }
        primeiro = primeiro.Substring(0,1);
        ultimo = nomes[nomes.Length-1]; 
        ultimo = ultimo.ToUpper();
        Console.WriteLine($"{ultimo}, {primeiro}.{meio}");
    }
}