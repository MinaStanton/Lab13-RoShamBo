using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RoschamboGame
{
   abstract class Player 
    {
        public string Name { get; set; }
        public string RochamboValue { get; set; }


        //abstract method
        public abstract string generateRoshambo();
    }
}
