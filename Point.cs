using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Point
	{
		public int x;
		public int y;
		public char sym;
		public Point()
		{
		}

		public Point(int x, int y, char sym)
		{
			this.x = x;
			this.y = y;
			this.sym = sym;
		}

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			sym = p.sym;
		}

		public void Move(int offset, Direction direction)
		{
			if(direction == Direction.right)
			{
				x = x + offset;
			}
			else if(direction == Direction.left)
			{
				x = x - offset;
			}
			else if(direction == Direction.up)
			{
				y = y - offset;
			}
			else if(direction == Direction.down)
			{
				y = y + offset;
			}
		}

		public bool IsHit(Point p)
		{
			return p.x == this.x && p.y == this.y;
		}

		public void Draw()
		{
            if (sym == '*')
            {
                ///keys.code();

                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (sym == 'x')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (sym == '■')
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }

            Console.SetCursorPosition( x, y );
			Console.Write( sym );
            Console.ForegroundColor = ConsoleColor.White;
        }

		public void Clear()
		{
			sym = ' ';
			Draw();
		}

		public override string ToString()
		{
			return x + ", " + y + ", " + sym;
		}
	}
}
