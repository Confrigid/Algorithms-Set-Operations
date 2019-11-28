using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAssignment1
{
    class Menu
    {
        public int DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine("******************************");
            Console.WriteLine("*Set Operations              *");
            Console.WriteLine("*                            *");
            Console.WriteLine("*1. Union                    *");
            Console.WriteLine("*2: Intersection             *");
            Console.WriteLine("*3: Difference               *");
            Console.WriteLine("*4: Cartesian Product        *");
            Console.WriteLine("*5: Check if Subset          *");
            Console.WriteLine("*6: Powerset                 *");
            Console.WriteLine("*7: Check if Empty           *");
            Console.WriteLine("*8: Check if an Element      *");
            Console.WriteLine("*9: Check if Equal           *");
            Console.WriteLine("*10: Get Cardinality         *");
            Console.WriteLine("*11: Add Element             *");
            Console.WriteLine("*12: Remove Element          *");
            Console.WriteLine("*13: Clear Set               *");
            Console.WriteLine("*14: Convert Set to Array    *");
            Console.WriteLine("*15: Print Set               *");
            Console.WriteLine("*16: Exit                    *");
            Console.WriteLine("******************************");
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int r))
            {
                return r;
            }
            else
            {
                Console.WriteLine("Non-integer value entered.");
                return 17;
            }
        }
    }
}
