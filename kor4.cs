using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step, x1, y1, x2, y2;
            Console.Write("x1 :");
            x1 = float.Parse(Console.ReadLine());
            Console.Write("y1 :");
            y1 = float.Parse(Console.ReadLine());
            Console.Write("x2 :");
            x2 = float.Parse(Console.ReadLine());
            Console.Write("y2 :");
            y2 = float.Parse(Console.ReadLine());

            dx = x2 - x1;
            dy = y2 - y1;
            Math.Abs(dx); Math.Abs(dy);

            if (dx >= dy)
            {
                step = dx;
            }
            else
            {
                step = dy;
            }

            dx /= step; dy /= step;
            x = x1; y = y1;
            int i = 1;
            if (i <= step)
            {
                Console.WriteLine("{0},{1}", x, y);
                x += dx;
                y += dy;
                i++;
            }
            else
            {
                Console.WriteLine("end");
            }
            
        }
    }
}
        

    

