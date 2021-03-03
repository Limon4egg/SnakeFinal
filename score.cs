using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Snake
{
    class score
    {
        public int Score;

        public score(int Score)
        {
            this.Score = Score;
        }

        public void Draw()
        {
            Console.SetCursorPosition(1, 25);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(string.Format("Счет - {0} ", Score));
        }

        public static void time()
        {
            Console.SetCursorPosition(36, 25);
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "et-EE" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("   Текущая дата и время: {0}", localDate.ToString(culture));
                              



                /*Console.SetCursorPosition(52, 25);
                DateTime localDate = DateTime.Now;
                String[] cultureNames = {"ru-RU" };

                foreach (var cultureName in cultureNames)
                {
                    var culture = new CultureInfo(cultureName);
                    Console.WriteLine("{0}: {1}", cultureName,
                                      localDate.ToString(culture));*/
            }
        }

            public void plus()
        {
            Score++;
        }
    }
}




