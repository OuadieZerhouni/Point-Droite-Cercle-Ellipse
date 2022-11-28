using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    
        internal class Program
        {
            static void Main(string[] args)
            {

                Point p1 = new Point(-6, 8);
                Point p2 = new Point(-6, 3);
                Point p3 = new Point(-6, 9);
                if (p1.Aligned(p2, p3))
                {
                    Console.WriteLine("3 points sont aligné");
                }
                else
                {
                    Console.WriteLine("3 points  ne sont pas aligné");

                }


            }
        }
    }
