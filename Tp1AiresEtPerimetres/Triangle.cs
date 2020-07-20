namespace Tp1AiresEtPerimetres
{
    internal class Triangle : Forme
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }


        private double p => (A + B + C) / 2d;
        public override double Perimetre => A + B + C;

        public override double Aire => System.Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        public override string ToString()
        {
            return $"Triangle côtés = {A} , {B} et {C} " + base.ToString();
        }
    }
}