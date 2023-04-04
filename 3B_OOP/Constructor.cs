using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3B_OOP
{
    // UC1- Constructor
    internal class Constructor
    {
        // fields or members.
        public int ID;
        public string Name;

        //1. Empty constructor
        public Constructor()
        {
            
        }
        public Constructor(string x)
        {
            Name = x;

        }
        public Constructor(int x, string y)
        {
            ID = x;
            Name = y;
        }
    }
}
