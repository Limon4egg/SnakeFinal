using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class menu
    {
        public static void runmenu()
        {
            start.Draw();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(32, 8);
            Console.Write("1-Начать новую игру");
            Console.SetCursorPosition(32, 10);

            Console.Write("2-Выйти");
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.White;
            var button = Console.ReadKey();
            switch (button.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    break;

                case ConsoleKey.D2:
                    Console.Clear();
                    Environment.Exit(0);
                    return;
                default:
                    Console.Clear();
                    runmenu();
                    break;
            }
        }
    }
}
