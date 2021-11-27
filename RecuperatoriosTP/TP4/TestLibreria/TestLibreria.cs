using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibreria
{
    [TestClass]
    public class TestLibreria
    {
        [TestMethod]
        public void Libro_ValidaLibroEsIgual()
        {

            //Arrange
            Libro miLibro = new Libro("Libro", "Autor", 2002, 1,1, 100, "novela");
            Libro otroLibro = new Libro("Libro2", "Autor2", 2002, 1, 1, 100, "novela2");

            //Act
            miLibro.Codigo = 1;
            otroLibro.Codigo = 1;

            //Assert
            Assert.AreEqual(miLibro, otroLibro);

        }


        [TestMethod]
        public void ClaseExtendida_ValidaQueFuncioneElPorcentaje()
        {
            //Arrange
            int numero = 10;
            int total = 100;
            string resultado;

            //Act
            resultado = numero.CalcularPorcentaje(total);

            //Assert
            Assert.AreEqual("10%", resultado);
        }

        [TestMethod]
        [ExpectedException(typeof(BibliotecaException))]
        public void Libreria_MetodoLeer_ArchivoInexistenteDeberiaDevolverBibliotecaExcepcion()
        {
            //Arrange
            Libreria miLibreria = new Libreria();
            miLibreria.RutaDeArchivo = "lalalalalala.txt";

            //Act
            miLibreria.Leer<Libreria>();

            //Assert

        }


    }
}
