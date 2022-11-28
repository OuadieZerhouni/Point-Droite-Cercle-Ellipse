namespace Point
{
    public class Droite
    {
        // Utiliser la classe "Point" de l'exercice 3 pour définir d'autres concepts
        // -Droite (constructeurs, setters et getters, égalité, parallélisme, intersection, perpendicularité)

        private Point p1, p2;
        public Droite(Point p1, Point p2)
        {
            this.p1 = p1;
            this.p2 = p2;
        }
        public void SetP1(Point p1)
        {
            this.p1 = p1;
        }
        public void SetP2(Point p2)
        {
            this.p2 = p2;
        }
        public Point GetP1()
        {
            return this.p1;
        }
        public Point GetP2()
        {
            return this.p2;
        }
        public bool Egal(Droite d)
        {
            if (this.p1.Egal(d.p1) && this.p2.Egal(d.p2))
                return true;
            return false;
        }
        public bool Parallel(Droite d)
        {
            float slope1 = (this.p2.y - this.p1.y) / (this.p2.x - this.p1.x);
            float slope2 = (d.p2.y - d.p1.y) / (d.p2.x - d.p1.x);
            if (slope1 == slope2)
                return true;
            return false;
        }
        public bool Perpendicular(Droite d)
        {
            float slope1 = (this.p2.y - this.p1.y) / (this.p2.x - this.p1.x);
            float slope2 = (d.p2.y - d.p1.y) / (d.p2.x - d.p1.x);
            if (slope1 * slope2 == -1)
                return true;
            return false;
        }
        public Point Intersection(Droite d)
        {
            if(this.Parallel(d))
            {
                Console.WriteLine("Les droites sont parallèles");
                return null;
            }
            float slope1 = (this.p2.y - this.p1.y) / (this.p2.x - this.p1.x);
            float slope2 = (d.p2.y - d.p1.y) / (d.p2.x - d.p1.x);
            float b1 = this.p1.y - slope1 * this.p1.x;
            float b2 = d.p1.y - slope2 * d.p1.x;
            float x = (b2 - b1) / (slope1 - slope2);
            float y = slope1 * x + b1;
            Point p = new Point(x, y);
            return p;
        }

        
    }
}