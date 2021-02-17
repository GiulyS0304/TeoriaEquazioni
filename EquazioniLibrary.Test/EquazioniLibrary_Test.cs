using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniLibrary_Test
    {
        [TestMethod]
        public void EquazioneDeterminata()
        {
            double a = 5;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsDetermined(a);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void EquazioneImpossibile()
        {
            double b = 10;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsInconsisted(b);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void EquazioneDiSecondoGrado()
        {
            double a = 0;
            bool risultato_aspettato = false;
            bool risultato_effettivo = Equazioni.IsDegree2(a);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void Delta()
        {
            double a = 2;
            double b = 6;
            double c = 2;
            double risultato_aspettato = 20;
            double risultato_effettivo = Equazioni.Delta(a, b, c);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
    }
}
