using NUnit.Framework;
using NUnitLite;

namespace Tests
{
    [TestFixture]
    public class TestClass
    {
        // deze functie is nodig om de testen achteraf via de webinterface uit te voeren
        public static int Run(string resultPath)
        {
            string[] args = { "--work=" + resultPath };
            return new AutoRun().Execute(args);
        }

        [Test]
        public void TestBepaalGrootste()
        {
            Assert.That(First.Oef.BepaalGrootste(2, 4), Is.EqualTo(4));
            Assert.That(First.Oef.BepaalGrootste(7, 9), Is.EqualTo(9));
        }

        [Test]
        public void TestIsGelijk()
        {
            Assert.That(First.Oef.IsGelijk(5, 15), Is.EqualTo(false));
            Assert.That(First.Oef.IsGelijk(25, 25), Is.EqualTo(true));
        }

        [Test]
        public void TestHoekenDriehoek()
        {
            Assert.That(First.Oef.HoekenDriehoek(100, 25, 25), Is.EqualTo(false));
            Assert.That(First.Oef.HoekenDriehoek(100, 40, 40), Is.EqualTo(true));
        }

        [Test]
        public void TestIsEven()
        {
            Assert.That(First.Oef.IsEven(25), Is.EqualTo(false));
            Assert.That(First.Oef.IsEven(24), Is.EqualTo(true));
        }

        [Test]
        public void TestIsDeelbaar()
        {
            Assert.That(First.Oef.IsDeelbaar(125, 10), Is.EqualTo("Niet deelbaar"));
            Assert.That(First.Oef.IsDeelbaar(12, 4), Is.EqualTo("Deelbaar"));
        }

        [Test]
        public void TestBepaalKwadrant()
        {
            Assert.That(First.Oef.BepaalKwadrant(12, 15), Is.EqualTo("Kwadrant 1"));
            Assert.That(First.Oef.BepaalKwadrant(-12, 15), Is.EqualTo("Kwadrant 2"));
            Assert.That(First.Oef.BepaalKwadrant(-13, -15), Is.EqualTo("Kwadrant 3"));
            Assert.That(First.Oef.BepaalKwadrant(13, -15), Is.EqualTo("Kwadrant 4"));
        }

        [Test]
        public void TestTestLetter()
        {
            Assert.That(First.Oef.TestLetter('y'), Is.EqualTo("Kleine letter"));
            Assert.That(First.Oef.TestLetter('Y'), Is.EqualTo("Hoofdletter"));
            Assert.That(First.Oef.TestLetter('!'), Is.EqualTo("Geen letter"));
        }

        [Test]
        public void TestTestSchrikkel()
        {
            Assert.That(First.Oef.TestSchrikkel(3000), Is.EqualTo("Geen schrikkeljaar"));
            Assert.That(First.Oef.TestSchrikkel(2400), Is.EqualTo("Schrikkeljaar"));
            Assert.That(First.Oef.TestSchrikkel(1850), Is.EqualTo("Geen schrikkeljaar"));
            Assert.That(First.Oef.TestSchrikkel(2008), Is.EqualTo("Schrikkeljaar"));
        }

        [Test]
        public void TestBepaalType()
        {
            Assert.That(First.Oef.BepaalType(12.5F, 12.5F, 12.5F), Is.EqualTo("Gelijkzijdig"));
            Assert.That(First.Oef.BepaalType(12.5F, 12.5F, 13.9F), Is.EqualTo("Gelijkbenig"));
            Assert.That(First.Oef.BepaalType(12.5F, 13.9F, 12.5F), Is.EqualTo("Gelijkbenig"));
            Assert.That(First.Oef.BepaalType(13.9F, 12.5F, 12.5F), Is.EqualTo("Gelijkbenig"));
            Assert.That(First.Oef.BepaalType(11.2F, 13.8F, 12.7F), Is.EqualTo("Ongelijkzijdig"));
        }

    }

}
