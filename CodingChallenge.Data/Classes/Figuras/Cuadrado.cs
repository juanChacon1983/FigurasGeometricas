namespace CodingChallenge.Data.Classes.Figuras
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado): base(lado)
        {

        }

        public override decimal Area()
        {
            return _lado * _lado;
        }

        public override decimal Perimetro()
        {
            return _lado * 4;
        }
        public override string Nombre()
        {
            return "Cuadrado";
        }

        public override string NombrePlural()
        {
            return "Cuadrados";
        }
    }
}
