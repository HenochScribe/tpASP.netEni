namespace Tp1AiresEtPerimetres
{
    internal class Carre : Rectangle
    {
        public int Largeur { get; set; }

        public override string ToString()
        {
            return $"Carre de côté{Largeur}";
        }
    }
}