using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes.Figuras
{
    public abstract class FormaGeometrica
    {
        public decimal _lado { get; private set; }

        public FormaGeometrica(decimal lado)
        {
            _lado = lado;
        }

        public abstract decimal Perimetro();

        public abstract decimal Area();

        public abstract string Nombre();

        public abstract string NombrePlural();




    }
}
