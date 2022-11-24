using System;

public class Desafio1
{
    public static void Main(string[] args)
    {
        
      int[] notas = new int[4]; 
      int i, soma = 0;
      
      Console.WriteLine("Escreva seu nome:");
      string nome = Console.ReadLine();
      
      for(i=0;i<4;i++)
      {
        Console.WriteLine("Digite a {0} nota:", i + 1);
        string nota = Console.ReadLine();
        notas[i] = Convert.ToInt32(nota);
      };
      
      foreach(int nota in notas)
      {
          soma = soma + nota;
      };
      float media = (float)soma/4;
      Console.WriteLine($"Aluno = {nome} // Media = {media}");
    }
}