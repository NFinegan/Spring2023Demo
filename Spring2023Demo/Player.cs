using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spring2023Demo
{
    public class Player
    {
        string name;

        public string Name { get => name; set => name = value; }
        public Player(string passedInName)
        {
            name = passedInName;
        }


        //overload name below example. No name required
        public Player(string passedInName)
        {
           
        }
    }
}