namespace CodingChallenge.Data.Classes.Figuras
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal _base { get; private set; }

        public Rectangulo(decimal lado, decimal otroLado) : base(lado)
        {
            _base = otroLado;
        }

        public override decimal Area()
        {
            return _lado * _base;
        }

        public override decimal Perimetro()
        {
            return (_lado * 2) + (_base * 2);
        }

        public override string Nombre()
        {
            return "Rectangulo";
        }

        public override string NombrePlural()
        {
            return "Rectangulos";
        }
    }
}
