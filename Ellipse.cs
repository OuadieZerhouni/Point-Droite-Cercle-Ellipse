namespace Point
{
    public class Ellipse
    {
        // Ellipse (constructeurs, setters et getters, égalité, intersection, calcul de circonférence, calcul de l'aire)
        private Point centre;
        private float rayon1, rayon2;
        public Ellipse(Point centre, float rayon1, float rayon2)
        {
            this.centre = centre;
            this.rayon1 = rayon1;
            this.rayon2 = rayon2;
        }
        public void SetCentre(Point centre)
        {
            this.centre = centre;
        }
        public void SetRayon1(float rayon1)
        {
            this.rayon1 = rayon1;
        }
        public void SetRayon2(float rayon2)
        {
            this.rayon2 = rayon2;
        }
        public Point GetCentre()
        {
            return this.centre;
        }
        public float GetRayon1()
        {
            return this.rayon1;
        }
        public float GetRayon2()
        {
            return this.rayon2;
        }
        public bool Egal(Ellipse e)
        {
            if (this.centre.Egal(e.centre) && this.rayon1 == e.rayon1 && this.rayon2 == e.rayon2)
                return true;
            return false;
        }
        public bool Intersection(Ellipse e)
        {
            float distance = (float)Math.Sqrt(Math.Pow(this.centre.x - e.centre.x, 2) + Math.Pow(this.centre.y - e.centre.y, 2));
            if (distance <= this.rayon1 + e.rayon1 && distance <= this.rayon2 + e.rayon2)
                return true;
            return false;
        }
        public float Circonference()
        {
            return (float)Math.PI * (3 * (this.rayon1 + this.rayon2) - (float)Math.Sqrt((3 * this.rayon1 + this.rayon2) * (this.rayon1 + 3 * this.rayon2)));
        }
        public float Aire()
        {
            return (float)Math.PI * this.rayon1 * this.rayon2;
        }
    }
}