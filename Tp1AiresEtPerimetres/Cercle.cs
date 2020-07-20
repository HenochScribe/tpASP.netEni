namespace Tp1AiresEtPerimetres
{
    public class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Perimetre => (Rayon * 2)* 3.14;

        public override double Aire => 3.14 * Rayon * Rayon;
    }
}