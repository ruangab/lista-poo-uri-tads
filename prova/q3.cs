using System;

class Prova{
  public static void Main(string[] args){
    int x = int.Parse(Console.ReadLine());
    int d = 2;
    while(x > 1){
      if(x % d == 0){
        Console.WriteLine(d);
        x /= d;
      }
      else{
        d++;
      }
    }
  } 
}