using System;

namespace CodingChallenge.Data.Classes.Figuras
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado) : base(lado)
        {

        }

        public override decimal Area()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override decimal Perimetro()
        {
            return (decimal)Math.PI * _lado;
        }

        public override string Nombre()
        {
            return "Círculo";
        }

        public override string NombrePlural()
        {
            return "Círculos";
        }
    }
}
