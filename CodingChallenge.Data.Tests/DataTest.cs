using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Figuras;
using CodingChallenge.Data.Classes.Idiomas;
using NUnit.Framework;
using System.Collections.Generic;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVaciaEnCastellano()
        {
            Idioma idioma = new IdiomaCastellano();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
               GeneradorDeInformes.Imprimir(new List<FormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Idioma idioma = new IdiomaIngles();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
               GeneradorDeInformes.Imprimir(new List<FormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnRuso()
        {
            Idioma idioma = new IdiomaRuso();

            Assert.AreEqual("<h1>Пустой список фигур!</h1>",
               GeneradorDeInformes.Imprimir(new List<FormaGeometrica>(), idioma));
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnCastellano()
        {
            Idioma idioma = new IdiomaCastellano();
            List<FormaGeometrica> cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };
            var resumen = GeneradorDeInformes.Imprimir(cuadrados, idioma);
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnIngles()
        {
            List<FormaGeometrica> cuadrados = new List<FormaGeometrica> {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            Idioma idioma = new IdiomaIngles();
            var resumen = GeneradorDeInformes.Imprimir(cuadrados, idioma);
            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            List<FormaGeometrica> formas = new List<FormaGeometrica> {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero( 4.2m),
            };
            Idioma idioma = new IdiomaIngles();

            var resumen = GeneradorDeInformes.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            List<FormaGeometrica> formas = new List<FormaGeometrica> {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero( 4.2m),
            };
            Idioma idioma = new IdiomaCastellano();

            var resumen = GeneradorDeInformes.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnRuso()
        {
            List<FormaGeometrica> formas = new List<FormaGeometrica> {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero( 4.2m),
            };
            Idioma idioma = new IdiomaRuso();

            var resumen = GeneradorDeInformes.Imprimir(formas, idioma);

            Assert.AreEqual(
                "<h1>Форма отчета</h1>2 квадраты | область 29 | периметр 28 <br/>2 круги | область 13,01 | периметр 18,06 <br/>3 треугольники | область 49,64 | периметр 51,6 <br/>ИТОГО:<br/>7 формы периметр 97,66 область 91,65",
                resumen);
        }


        [TestCase]
        public void TestTraduccionTextoAIngles()
        {
            Idioma idioma = new IdiomaIngles();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", idioma.Traducir("<h1>Lista vacía de formas!</h1>"));
        }


        [TestCase]
        public void TestTraduccionTextoARuso()
        {
            Idioma idioma = new IdiomaRuso();
            Assert.AreEqual("<h1>Пустой список фигур!</h1>", idioma.Traducir("<h1>Lista vacía de formas!</h1>"));
        }

        [TestCase]
        public void TestTCalcularAreaDelCirculo()
        {
            Circulo figura = new Circulo(3);
            Assert.AreEqual(7.0685834705770275, figura.Area());
        }

        [TestCase]
        public void TestTCalcularPerimetroDelCirculo()
        {
            Circulo figura = new Circulo(3);
            Assert.AreEqual(9.42477796076937, figura.Perimetro());
        }

        [TestCase]
        public void TestTCalcularAreaDelCuadrado()
        {
            Cuadrado figura = new Cuadrado(3);
            Assert.AreEqual(9, figura.Area());
        }

        [TestCase]
        public void TestTCalcularPerimetroDelCuadrado()
        {
            Cuadrado figura = new Cuadrado(3);
            Assert.AreEqual(12, figura.Perimetro());
        }

        [TestCase]
        public void TestTCalcularAreaDelTrianguloEquilatero()
        {
            TrianguloEquilatero figura = new TrianguloEquilatero(3);
            Assert.AreEqual(3.89711431702998m, figura.Area());
        }

        [TestCase]
        public void TestTCalcularPerimetroDelTrianguloEquilatero()
        {
            TrianguloEquilatero figura = new TrianguloEquilatero(3);
            Assert.AreEqual(9, figura.Perimetro());
        }

        [TestCase]
        public void TestTCalcularAreaDelTrapecio()
        {
            Trapecio figura = new Trapecio(3, 2, 4, 1);
            Assert.AreEqual(3, figura.Area());
        }

        [TestCase]
        public void TestTCalcularPerimetroDelTrapecio()
        {
            Trapecio figura = new Trapecio(3,2,4,1);
            Assert.AreEqual(8, figura.Perimetro());
        }
        [TestCase]
        public void TestTCalcularAreaDelRectangulo()
        {
            Rectangulo figura = new Rectangulo(8,3);
            Assert.AreEqual(24, figura.Area());
        }

        [TestCase]
        public void TestTCalcularPerimetroDeRectangulo()
        {
            Rectangulo figura = new Rectangulo(3,2);
            Assert.AreEqual(10, figura.Perimetro());
        }

    }
}
