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
            double a = 0;
            double b = 10;
            bool risultato_aspettato = true;
            bool risultato_effettivo = Equazioni.IsInconsisted(a, b);
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

        [TestMethod]
        public void CalcoloEquazioneDiSecondoGrado1()
        {
            double a = 1;
            double b = 5;
            double c = 6;
            string risultato_aspettato = $"Ci sono due soluzioni {-2} e {-3}";
            string risultato_effettivo = Equazioni.CalcoloEquazioneDiSecondoGrado(a, b, c);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void CalcoloEquazioneDiSecondoGrado2()
        {
            double a = 1;
            double b = -2;
            double c = 1;
            string risultato_aspettato = $"C'è solo una soluzione {1}";
            string risultato_effettivo = Equazioni.CalcoloEquazioneDiSecondoGrado(a, b, c);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void CalcoloEquazioneDiSecondoGrado3()
        {
            double a = 1;
            double b = 1;
            double c = 1;
            string risultato_aspettato = "Non ci sono soluzioni, perchè l'equazione è IMPOSSIBILE";
            string risultato_effettivo = Equazioni.CalcoloEquazioneDiSecondoGrado(a, b, c);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
    }
}
