using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class IdiomaIngles : Idioma
    {
        private Dictionary<String, String> traducciones;
        public IdiomaIngles() : base()
        {
            traducciones = new Dictionary<string, string>() {
                                            {"<h1>Lista vacía de formas!</h1>", "<h1>Empty list of shapes!</h1>"},
                                            {"<h1>Reporte de Formas</h1>", "<h1>Shapes report</h1>"},
                                            {"TOTAL:<br/>", "TOTAL:<br/>"},
                                            {"formas", "shapes"},
                                            {"Perimetro", "Perimeter"},
                                            {"Area", "Area"},
                                            {"Cuadrado", "Square"},
                                            {"Cuadrados", "Squares"},
                                            {"Círculo", "Circle"},
                                            {"Círculos", "Circles"},
                                            {"Trapecio", "Trapeze"},
                                            {"Trapecios","Trapezoids"},
                                            {"Rectangulo", "Rectangle"},
                                            {"Rectangulos", "Rectangles"},
                                            {"Triángulo", "Triangle"},
                                            {"Triángulos", "Triangles"}
            };
        }

        public override string Traducir(string texto)
        {
            return traducciones[texto];
        }
    }
}
