using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Romanos.Tests
{
    
    public class DecimalesARomanos
    {
        [Test]
        public void Convertir1paraI()
        {
            Convert(1, "I");
        }

        [Test]
        public void Convertir2paraII()
        {
            Convert(2, "II");
        }

        [Test]
        public void Convertir3paraIII()
        {
            Convert(3, "III");
        }

        [Test]
        public void Convertir4paraIV()
        {
            Convert(4, "IV");
        }

        [Test]
        public void Convertir5paraV()
        {
            Convert(5, "V");
        }

        [Test]
        public void Convertir8paraVIII()
        {
            Convert(8, "VIII");
        }
        [Test]
        public void Convertir9paraIX()
        {
            Convert(9, "IX");
        }

        [Test]
        public void Convertir10paraX()
        {
            Convert(10, "X");
        }

        [Test]
        public void Convertir11paraXI()
        {
            Convert(11, "XI");
        }

        [Test]
        public void Convertir50paraL()
        {
            Convert(50, "L");
        }

        [Test]
        public void Convertir100paraC()
        {
            Convert(100, "C");
        }

        [Test]
        public void Convertir500paraD()
        {
            Convert(500, "D");
        }

        [Test]
        public void Convertir1000paraM()
        {
            Convert(1000, "M");
        }

        [Test]
        public void Convertir20paraXX()
        {
            Convert(20, "XX");
        }

        [Test]
        public void Convertir39paraXXXIX()
        {
            Convert(39, "XXXIX");
        }

        [Test]
        public void Convertir45paraXLV()
        {
            Convert(45, "XLV");
        }

        [Test]
        public void Convertir95paraXCV()
        {
            Convert(95, "XCV");
        }

        [Test]
        public void Convertir144paraCXLIV()
        {
            Convert(144, "CXLIV");
        }

        private static void Convert(int nro, string nroRomano)
        {
            var converter = new RomanoConverter();
            Assert.AreEqual(nroRomano, converter.Parse(nro));
        }
    }
}
