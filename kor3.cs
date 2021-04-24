using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double fbw = double.Parse(Console.ReadLine());
            double fL, fov;

            if (fbw > 0)
            {            
                if (mode == "flenght")
                {
                    fL = double.Parse(Console.ReadLine());
                    if (fL > 0)
                    {
                        fov = 2 * Math.Atan(fbw / (2 * fL));
                        Console.WriteLine("flenght={0}", fL);
                        Console.WriteLine("fov={1}", fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid flenght Please input again ");

                    }
                }
                else if (mode == "fov")
                {
                    fov = double.Parse(Console.ReadLine());
                    if (fov > 0.1 && fov < 6.28)
                    {
                        fL = fbw / (2 * Math.Tan(fov / 2));
                        Console.WriteLine("flenght={0}", fL);
                        Console.WriteLine("fov={1}", fov);
                    }
                    else
                    {
                        Console.WriteLine("Invalid fov Please input again ");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid blackflim width please try again");
            }
        }
    }
}
        

    

