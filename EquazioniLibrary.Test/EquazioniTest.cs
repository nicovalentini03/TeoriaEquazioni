using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class EquazioniTest
    {
        [TestMethod]
        
            public void IsDeterminedTest()
        {
            double a = 3;
            double b = 4;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotDeterminedTest()
        {
            double a = 0;
            double b = 4;
            bool risposta = Equazioni.IsDetermined(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsInconsistedTest()
        {
            double a = 3;
            double b = 0;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void IsNotInconsistedTest()
        {
            double a = 3;
            double b = 1;
            bool risposta = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(false, risposta);
        }
        [TestMethod]
        public void IsDegree2Test()
        {
            double a = 2;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(true, risposta);
        }
        [TestMethod]
        public void DeltaTest()
        {
            double a = 4;
            double b = 3;
            double c = 2;
            double delta = Equazioni.Delta(a, b, c);
            Assert.AreEqual(-23, delta);
        }

    }
}
