using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Snake
{
    class keys
    {
        public static void code()
        {


            ConsoleKeyInfo keyinfo;
            do
            {
                keyinfo = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            while (keyinfo.Key != ConsoleKey.D);

        }
    }
}