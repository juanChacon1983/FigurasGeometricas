using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public static class GeneradorDeInformes
    {
        public static String Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(idioma.Traducir("<h1>Lista vacía de formas!</h1>"));
            }
            else
            {
                sb.Append(idioma.Traducir("<h1>Reporte de Formas</h1>"));

                var gruposDeFormas = formas.GroupBy(x => x.GetType().Name);

                decimal totalPerimetros = 0;
                decimal totalAreas = 0;

                foreach (IEnumerable<FormaGeometrica> grupo in gruposDeFormas)
                {
                    decimal area = ObtenerAreas(grupo);
                    decimal perimetro = ObtenerPerimetros(grupo);
                    sb.Append(ObtenerLinea(idioma, grupo, perimetro, area));
                    totalAreas = totalAreas + area;
                    totalPerimetros = totalPerimetros + perimetro;

                }

                sb.Append(idioma.Traducir("TOTAL:<br/>"));

                sb.Append($"{formas.Count} {idioma.Traducir("formas")} ");

                sb.Append($"{idioma.Traducir("Perimetro")} {totalPerimetros.ToString("#.##")} ");

                sb.Append($"{idioma.Traducir("Area")} {totalAreas.ToString("#.##")}");
            }



            return sb.ToString();
        }


        private static string ObtenerLinea(Idioma idioma, IEnumerable<FormaGeometrica> listaDeFormas, decimal perimetro, decimal area)
        {
           string nombreDeLaFigura = listaDeFormas.Count() == 1 ? idioma.Traducir(listaDeFormas.First().Nombre()): idioma.Traducir(listaDeFormas.First().NombrePlural());

           return   $"{listaDeFormas.Count()} {nombreDeLaFigura} | {idioma.Traducir("Area")} {area:#.##} | {idioma.Traducir("Perimetro")} {perimetro:#.##} <br/>";

        }

        private static decimal ObtenerAreas(IEnumerable<FormaGeometrica> listaDeFormas)
        {
            decimal area = 0;
            foreach (FormaGeometrica forma in listaDeFormas)
            {
                area = area + forma.Area();
            }
            return area;
        }

        private static decimal ObtenerPerimetros(IEnumerable<FormaGeometrica> listaDeFormas)
        {
            decimal perimetro = 0;
            foreach (FormaGeometrica forma in listaDeFormas)
            {
                perimetro = perimetro + forma.Perimetro();
            }
            return perimetro;
        }


    }

}
