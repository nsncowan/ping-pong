using System;
using System.Collections.Generic;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("input a number to play Ping-Pong to");
    string inputNumber = Console.ReadLine();
    int inputInteger = int.Parse(inputNumber);

    for (int x = 1; x <= inputInteger; x++)
    {
      if ((x % 3 == 0) && (x % 5 == 0))
      {
        Console.WriteLine("ping-pong");
      }
      else if (x % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (x % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else 
      {
        Console.WriteLine(x);
      }
    }
  }
}