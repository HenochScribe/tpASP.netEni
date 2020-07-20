using System;

namespace Tp1AiresEtPerimetres
{
    internal class Rectangle : Forme
    {
        public double Largeur;

        public double Longueur;

        public override double Aire => Largeur * Longueur;

        public override double Perimetre => 2 * Longueur + 2 * Largeur;

        public override string ToString()
        {
            
            return $"Rectangle de longueur={Longueur} largeur={Largeur}" ;
        }
    }
}