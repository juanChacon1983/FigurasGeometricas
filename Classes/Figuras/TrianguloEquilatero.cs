using System;

namespace CodingChallenge.Data.Classes.Figuras
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado) : base(lado)
        {

        }

        public override decimal Area()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal Perimetro()
        {
            return _lado * 3;
        }

        public override string Nombre()
        {
            return "Triángulo";
        }

        public override string NombrePlural()
        {
            return "Triángulos";
        }

    }
}
