namespace Tp1AiresEtPerimetres
{
    public class Cercle : Forme
    {
       
        private int rayon;

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public override double Perimetre => (Rayon * 2)* 3.14;

        public override double Aire => System.Math.PI * System.Math.Pow(Rayon,2);

        public override string ToString()
        {
            return $"Cerle de rayon {Rayon} "+base.ToString();
        }
    }
}