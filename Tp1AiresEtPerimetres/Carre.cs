namespace Tp1AiresEtPerimetres
{
    internal class Carre : Rectangle
    {
        private int largeur;

        public virtual int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public override double Perimetre => largeur * 4;

        public override double Aire => largeur * largeur;

        public override string ToString()
        {
            return $"Carre de côté {Largeur}" ;
        }
    }
}