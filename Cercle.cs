namespace Point
{
    public class Cercle
    {
        // Cercle (constructeurs setters et getters, égalité, intersection, calcul de circonférence, calcul de l'aire)
        private Point centre;
        private float rayon;
        public Cercle(Point centre, float rayon)
        {
            this.centre = centre;
            this.rayon = rayon;
        }
        public void SetCentre(Point centre)
        {
            this.centre = centre;
        }
        public void SetRayon(float rayon)
        {
            this.rayon = rayon;
        }
        public Point GetCentre()
        {
            return this.centre;
        }
        public float GetRayon()
        {
            return this.rayon;
        }
        public bool Egal(Cercle c)
        {
            if (this.centre.Egal(c.centre) && this.rayon == c.rayon)
                return true;
            return false;
        }
        public bool Intersection(Cercle c)
        {
            float distance = (float)Math.Sqrt(Math.Pow(this.centre.x - c.centre.x, 2) + Math.Pow(this.centre.y - c.centre.y, 2));
            if (distance <= this.rayon + c.rayon)
                return true;
            return false;
        }
        public float Circonference()
        {
            return 2 * (float)Math.PI * this.rayon;
        }
        public float Aire()
        {
            return (float)Math.PI * this.rayon * this.rayon;
        }
        
    }
}