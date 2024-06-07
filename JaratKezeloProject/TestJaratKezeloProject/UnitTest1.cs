using JaratKezeloProject;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestJaratKezeloProject
{
    public class JaratKezeloTest
    {
        [Fact]
        public void UjJarat()
        {
            var jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("DC334", "DAD", "BDE", new DateTime(2012, 3, 3, 10, 0, 0));
            var indulas = jaratKezelo.MikorIndul("DC334");
            Assert.Equal(new DateTime(2024, 6, 1, 12, 0, 0), indulas);

        }
        [Fact]
        public void HozzaadKeses()
        {
            var jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("DC334", "DAD", "BDE", new DateTime(2012, 3, 3, 10, 0, 0));
            jaratKezelo.Keses("DC334", 40);
            var indulas = jaratKezelo.MikorIndul("DC334");
            Assert.Equal(new DateTime(2012, 3, 3, 10, 0, 0), indulas);

        }
        [Fact]
        public void Keses_NegativKeses()
        {
            var jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("DC334", "DAD", "BDE", new DateTime(2012, 3, 3, 10, 0, 0));
            var exception = Assert.Throws<ArgumentException>(() => jaratKezelo.Keses("DC334", -40));
            Assert.Equal("Nem lehet negatív a késés!", exception.Message);

        }
        [Fact]
        public void JaratokRepuloter()
        {
            var jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("DC334", "DAD", "BDE", new DateTime(2012, 3, 3, 10, 0, 0));
            jaratKezelo.UjJarat("DC344", "BUE", "BDX", new DateTime(2012, 3, 3, 12, 0, 0));
            var jaratok = jaratKezelo.JaratokRepuloterrol("BUE");
            Assert.Contains("DC334", jaratok);
            Assert.Contains("DC344", jaratok);

        }
        [Fact]

        public void DuplikaltJaratSzam()
        {
            var jaratKezelo = new JaratKezelo();
            jaratKezelo.UjJarat("DC334", "DAD", "BDE", new DateTime(2012, 3, 3, 12, 0, 0));
            var exception = Assert.Throws<ArgumentException>(() => jaratKezelo.UjJarat("DC334", "DAD", "BDE", new DateTime(2012, 3, 3, 12, 0, 0)));
            Assert.Equal("Ilyen számú járat már létezik!", exception.Message);

        }
    }
}
