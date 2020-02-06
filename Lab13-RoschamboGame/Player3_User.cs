using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13_RoschamboGame
{
    class Player3_User : Player
    {
        public override string generateRoshambo()
        {
            Console.WriteLine("Please enter the number of the selection you would like to make: ");
            Console.WriteLine($"1. Rock \t2. Paper \t3. Scissors");
            try
            {
                int userPick = int.Parse(Console.ReadLine());
                RochamboValue = Enum.GetName(typeof(Roshambo), userPick);
                return RochamboValue;
            }
            catch
            {
                return generateRoshambo();
            }
        }
    }
}
