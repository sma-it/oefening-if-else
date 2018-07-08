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
			Assert.That(First.Program.bepaalGrootste(1, 3), Is.EqualTo(3), "Dit wordt door de webinterface getoond wanneer de test faalt.");
			Assert.That(First.Program.bepaalGrootste(3, 1), Is.EqualTo(3), "Dit wordt door de webinterface getoond wanneer de test faalt.");
            Assert.That(First.Program.isGelijk(5, 7), Is.EqualTo(false), "Dit wordt door de webinterface getoond wanneer de test faalt.");
            Assert.That(First.Program.isGelijk(5, 5), Is.EqualTo(true), "Dit wordt door de webinterface getoond wanneer de test faalt.");
        }
	}
}
