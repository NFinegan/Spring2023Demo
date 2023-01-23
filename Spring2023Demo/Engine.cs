using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Spring2023Dem.Utility;

namespace Spring2023Demo
{
    internal class Engine
    {
        Player player = new Player() { Name = "Nicole" };
        CraftingTable craftingtable;
    }

    public void Play()
    {
        double price = 3.4567;

        Print("Hello World"); //setting up for a delegate later
        Print("Hello " + Player.Name); //concatenation
        Console.WriteLine("Hello {0} in {1}", Player.Name, "chicago"); //composite
        Print($"Hello {Player.Name}"); //interpolation

        Print($"I paid  {price.ToString("c")} for this coffee");
        Console.ReadKey();

    }
}
