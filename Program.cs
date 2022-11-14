using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point
{
    class Point
    {
        private float x, y;
        public Point(float x = 0, float y = 0)//constructeur qui deux params par defaut qui serent surchager en cas de passage des params 
        {
            this.x = x;
            this.y = y;
            Console.WriteLine("(" + this.x + "," + this.y + ")");
        }
        public void SetX(float x)
        {
            this.x = x;
        }
        public void SetY(float y)
        {
            this.y = y;
        }
        public float GetX()
        {
            return this.x;
        }
        public float GetY()
        {
            return this.y;
        }
        public float Distance(Point p)
        {
            return (float)Math.Sqrt(Math.Pow((p.x - this.x), 2) + Math.Pow((p.y - this.y), 2));
            //calcule de distance entre deux points geométrique 
        }
        public bool Egal(Point p)//egalité de deux points
        {
            if (this.x == p.x && this.y == p.y)
                return true;
            return false;
        }
        public void Translate(float t)
        {
            this.x += t;
            this.y += t;
        }
        public bool Aligned(Point p1, Point p2)
        {//equation lineaire s'ecrit sous la forme y = m*x + b


            float slope = (p2.y - p1.y) / (p2.x - p1.x);//calculant m = y2-y1/x2-x1
            float b = p1.y - slope * p1.x;//calculant b qui est une constante b = y - m*x

            float result = this.y - slope * this.x;//remplaçant les coords de notre point dans y - m*x
            if (result == b)// on teste l'égalité b == y - m*x
                return true;//les 3 points sont aligné
            return false;//les points ne sont pas aligné




        }
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
}
