using System;

class Prova{
  public static void Main(string[] args){ 
    string texto = Console.ReadLine();
    senha(texto);
  }

  public static void senha (string texto){
    string[] t = texto.Split(" ");
    for(int i = 0; i < t.Length; i++){
      Console.Write(t[i].Length + "");
    } 
  }
}