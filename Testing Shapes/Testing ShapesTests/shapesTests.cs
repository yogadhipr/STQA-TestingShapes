using NUnit.Framework;
using Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Tests
{
    [TestFixture()]
    public class shapesTests
    {
        shapes sh = new shapes();

        [Test()]
        public void kubusTest()
        {
            double hasilKb = sh.kubus(5);
            Assert.AreEqual(125, hasilKb);
        }

        [Test()]
        public void balokTest()
        {
            double hasilBl = sh.balok(5, 6, 7);
            Assert.AreEqual(210, hasilBl);
        }

        [Test()]
        public void tabungTest()
        {
            double hasilTb = sh.tabung(5, 6);
            Assert.AreEqual(450, hasilTb);
        }

        [Test()]
        public void kubusTest1()
        {

        }
    }
}