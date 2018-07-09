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
        public void TestOefening1()
        {
            Assert.That(If_else.Oef.BepaalGrootste(2, 4), Is.EqualTo(4));
            Assert.That(If_else.Oef.BepaalGrootste(7, 9), Is.EqualTo(9));
            Assert.That(If_else.Oef.IsGelijk(5, 15), Is.EqualTo(false));
            Assert.That(If_else.Oef.IsGelijk(25, 25), Is.EqualTo(true));
            Assert.That(If_else.Oef.HoekenDriehoek(100, 25, 25), Is.EqualTo(false));
            Assert.That(If_else.Oef.HoekenDriehoek(100, 40, 40), Is.EqualTo(true));
            Assert.That(If_else.Oef.IsEven(25), Is.EqualTo(false));
            Assert.That(If_else.Oef.IsEven(24), Is.EqualTo(true));
            Assert.That(If_else.Oef.IsDeelbaar(125, 10), Is.EqualTo("Niet deelbaar"));
            Assert.That(If_else.Oef.IsDeelbaar(12, 4), Is.EqualTo("Deelbaar"));
            Assert.That(If_else.Oef.BepaalKwadrant(12, 15), Is.EqualTo("Kwadrant 1"));
            Assert.That(If_else.Oef.BepaalKwadrant(-12, 15), Is.EqualTo("Kwadrant 2"));
            Assert.That(If_else.Oef.BepaalKwadrant(-13, -15), Is.EqualTo("Kwadrant 3"));
            Assert.That(If_else.Oef.BepaalKwadrant(13, -15), Is.EqualTo("Kwadrant 4"));
            Assert.That(If_else.Oef.TestLetter('y'), Is.EqualTo("Kleine letter"));
            Assert.That(If_else.Oef.TestLetter('Y'), Is.EqualTo("Hoofdletter"));
            Assert.That(If_else.Oef.TestLetter('!'), Is.EqualTo("Geen letter"));
            Assert.That(If_else.Oef.TestSchrikkel(3000), Is.EqualTo("Geen schrikkeljaar"));
            Assert.That(If_else.Oef.TestSchrikkel(2400), Is.EqualTo("Schrikkeljaar"));
            Assert.That(If_else.Oef.TestSchrikkel(1850), Is.EqualTo("Geen schrikkeljaar"));
            Assert.That(If_else.Oef.TestSchrikkel(2008), Is.EqualTo("Schrikkeljaar"));
            Assert.That(If_else.Oef.BepaalType(12.5F, 12.5F, 12.5F), Is.EqualTo("Gelijkzijdig"));
            Assert.That(If_else.Oef.BepaalType(12.5F, 12.5F, 13.9F), Is.EqualTo("Gelijkbenig"));
            Assert.That(If_else.Oef.BepaalType(12.5F, 13.9F, 12.5F), Is.EqualTo("Gelijkbenig"));
            Assert.That(If_else.Oef.BepaalType(13.9F, 12.5F, 12.5F), Is.EqualTo("Gelijkbenig"));
            Assert.That(If_else.Oef.BepaalType(11.2F, 13.8F, 12.7F), Is.EqualTo("Ongelijkzijdig"));
        }
    }

}
