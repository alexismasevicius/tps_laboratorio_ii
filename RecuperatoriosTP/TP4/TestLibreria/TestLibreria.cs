using BibliotecaDeClases;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestLibreria
{
    [TestClass]
    public class TestLibreria
    {
        [TestMethod]
        public void Liberia_ValidaQueSeAgreguenLosElementos()
        {

            //Arrange

            Libreria miLibreria = new Libreria();
            Libro libro1 = new Libro("En busca del tiempo perdido", "Proust, Marcel", 1922, 2, 0, 2000, "novela");
            Libro libro2 = new Libro("La metamorfosis", "Kafka, Franz", 1915, 5, 0, 800, "novela");

            //Act
            miLibreria.AgregarProducto(libro1);
            miLibreria.AgregarProducto(libro2);

            //Assert
            

        }


        [TestMethod]
        public void Libros_ValidaQueLosElementosSeanIgualesSiElCodigoEsIgual()
        {

            //Arrange

            Libro libro1 = new Libro("En busca del tiempo perdido", "Proust, Marcel", 1922, 2, 0, 2000, "novela");
            Libro libro2 = new Libro("La metamorfosis", "Kafka, Franz", 1915, 5, 0, 800, "novela");
            libro1.Codigo = 1;
            libro2.Codigo = 1;
            //Act

            //Assert
            Assert.AreEqual(libro1, libro2);
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
