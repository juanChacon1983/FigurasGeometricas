namespace CodingChallenge.Data.Classes.Figuras
{
    public class Trapecio : FormaGeometrica
    {
        public decimal _altura { get; private set; }
        public decimal _base { get; private set; }
        public decimal _otrolado { get; private set; }

        public Trapecio(decimal lado, decimal otrolado, decimal medidaBase, decimal altura) : base(lado)
        {
            _altura = altura;
            _otrolado = otrolado;
            _base = medidaBase;
        }
        public override decimal Area()
        {
            return _altura*((_lado*_otrolado)/2);
        }

        public override decimal Perimetro()
        {
            return _lado + _otrolado + _base + -_altura;
        }

        public override string Nombre()
        {
            return "Trapecio";
        }

        public override string NombrePlural()
        {
            return "Trapecios";
        }
    }
}
