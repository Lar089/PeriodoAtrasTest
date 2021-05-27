using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PeriodoAtrasTest.Periodo;

namespace PeriodoAtrasTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void UmDiasAtras()
        {
            Assert.AreEqual("um dia", new Humunizar(DateTime.Parse("26/05/2021"), DateTime.Parse("25/05/2021")).valor_saida);
        }

        [TestMethod]
        public void DoisDiasAtras()
        {
            Assert.AreEqual("dois dias", new Humunizar(DateTime.Parse("26/05/2021"), DateTime.Parse("24/05/2021")).valor_saida);
        }

        [TestMethod]
        public void UmaSemanaAtras()
        {
            Assert.AreEqual("uma semana", new Humunizar(DateTime.Parse("26/05/2021"), DateTime.Parse("19/05/2021")).valor_saida);
        }

        [TestMethod]
        public void DoisMesesUmaSemanaAtras()
        {
            Assert.AreEqual("dois meses e uma semana", new Humunizar(DateTime.Parse("26/05/2021"), DateTime.Parse("19/03/2021")).valor_saida);
        }

        [TestMethod]
        public void DoisMesesDoisDiasAtras()
        {
            Assert.AreEqual("dois meses e dois dias", new Humunizar(DateTime.Parse("26/05/2021"), DateTime.Parse("24/03/2021")).valor_saida);
        }

        [TestMethod]
        public void DezAnosAtras()
        {
            Assert.AreEqual("dez anos", new Humunizar(DateTime.Parse("26/05/2021"), DateTime.Parse("26/05/2011")).valor_saida);
        }
    }
}
