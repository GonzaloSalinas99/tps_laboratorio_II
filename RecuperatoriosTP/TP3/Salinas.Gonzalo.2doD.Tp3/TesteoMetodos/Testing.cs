using Controlador;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteoMetodos
{
    [TestClass]
    public class Testing
    {
        [TestMethod]
        public void TestPuntoJson_RecibeLaExtensionDelArchivo_DeberiaRetornarTrueSiLaExtensionCoincideConJson()
        {
            //Arrange 
            PuntoJson<string> puntoJson = new PuntoJson<string>();

            //Act
            bool retorno = puntoJson.ValidarExtension("archivo.json");

            //Assert
            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(Excepciones.Excepciones))]
        public void ValidarExtension_LanzaArchivoInvalidoException_CuandoLaExtensionNoEsJson()
        {
            // Arrange
            PuntoJson<string> puntoJson = new PuntoJson<string>();

            // Act
            bool retorno = puntoJson.ValidarExtension("archivo.bin");

            Assert.IsTrue(retorno);
        }

        [TestMethod]
        [ExpectedException(typeof(Excepciones.Excepciones))]
        public void Guardar_RecibeRutaInvalida_DeberiaRetornarExcepcion()
        {
            PuntoXml<Procesador<Persona>> puntoXml = new PuntoXml<Procesador<Persona>>();

            puntoXml.Leer("");
        }
    }
}
