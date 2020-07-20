namespace Tp1AiresEtPerimetres
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public override double Perimetre => A + B + C;

        public override double Aire => throw new System.NotImplementedException();
    }
}