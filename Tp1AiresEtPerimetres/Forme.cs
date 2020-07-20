namespace Tp1AiresEtPerimetres
{
    public abstract class Forme
    {
        public abstract double Perimetre { get; }
        public abstract double Aire { get; }

        public override string ToString()
        {
            return $"Aire = {Aire} Périmètre = {Perimetre}";
        }

    }
}