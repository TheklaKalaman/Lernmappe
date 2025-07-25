using System;
using FizzBuzz;

class Program
{
    static void Main(string[] args)
    {
        FizzBuzzy game = new(Console.In, Console.Out);
        game.FizzBuzzInput();
        
    }
}
