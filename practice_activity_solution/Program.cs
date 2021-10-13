using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_activity_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            easyList();
            Console.ReadKey();
        }

        public static void easyList()
        {
            List<string> favoriteColors = new List<string> { "Blue", "Green", "White", "Black", "Grey", "Yellow", "Orange", "Silver", "Teal" };

            string[] addIn = new string[] { "Red"};

            favoriteColors.InsertRange(1, addIn); 

            foreach (var i in favoriteColors)
            {
                Console.WriteLine(i);
            }
        }
    }
}