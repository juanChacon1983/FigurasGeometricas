using System;
using System.Collections.Generic;

namespace CodingChallenge.Data.Classes.Idiomas
{
    public class IdiomaRuso : Idioma
    {
        private Dictionary<String, String> traducciones;
        public IdiomaRuso() : base()
        {
            traducciones = new Dictionary<string, string>() {
                                            {"<h1>Lista vacía de formas!</h1>", "<h1>Пустой список фигур!</h1>"},
                                            {"<h1>Reporte de Formas</h1>", "<h1>Форма отчета</h1>"},
                                            {"TOTAL:<br/>", "ИТОГО:<br/>"},
                                            {"formas", "формы"},
                                            {"Perimetro", "периметр"},
                                            {"Area", "область"},
                                            {"Cuadrado", "квадрат"},
                                            {"Cuadrados", "квадраты"},
                                            {"Círculo", "круг"},
                                            {"Círculos", "круги"},
                                            {"Triángulo", "треугольник"},
                                            {"Triángulos", "треугольники"}
            };
        }

        public override string Traducir(string texto)
        {
            return traducciones[texto];
        }
    }
}