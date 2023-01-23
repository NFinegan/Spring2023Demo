using System;
using static System.Console; 

namespace Spring2023Demo
{
    internal class Program
    {
        static void Main()
        {
            Title = "Crafting Demo!";
            WriteLine("Hello, World!");
            Engine engine = new Engine();
            engine.Play();
        }
    }
}