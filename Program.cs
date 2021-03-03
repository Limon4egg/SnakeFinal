using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)

		{
			int scorex = 0;

			Console.SetWindowSize(80, 27);


			menu.runmenu();

			Console.SetBufferSize(80, 27);


			Walls walls = new Walls(80, 25);
			walls.Draw();

			Point p = new Point(4, 5, 'o');
			Snake snake = new Snake(p, 4, Direction.right);
			snake.Draw();

			
				FoodCreator foodCreator = new FoodCreator(79, 24,'X','O','@');
				Point food = foodCreator.CreateFood();

				food.Draw();


			while (true)
			{
				Console.SetCursorPosition(1, 25);
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.Write(string.Format("Счет - {0} ", scorex));
				score.time();
				if (walls.IsHit(snake) || snake.IsHitTail())
				{
					break;
				}
				if (snake.Eat(food))
				{

					food = foodCreator.CreateFood();
					food.Draw();
					scorex++;
				}

				else
				{
					snake.Move();
				}

				Thread.Sleep(100);
				if (Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandleKey(key.Key);
				}
			}
			WriteGameOver();
			Console.ReadLine();
		}


		public static void WriteGameOver()
		{
			int xOffset = 25;
			int yOffset = 8;
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(xOffset, yOffset++);
			WriteText("■■■■■■■■■■■■■■■■■■■■", xOffset, yOffset++);
			WriteText("Конец игры", xOffset + 7, yOffset++);
			yOffset++;
			WriteText("Оу, ты проиграл :( ", xOffset + 7, yOffset++);
			WriteText("Твой счет ", xOffset + 1, yOffset++);
			WriteText("■■■■■■■■■■■■■■■■■■■■", xOffset, yOffset++);
		}



		static void WriteText(String text, int xOffset, int yOffset)
		{
			Console.SetCursorPosition(xOffset, yOffset);
			Console.WriteLine(text);
		}

	}
}
