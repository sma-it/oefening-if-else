using System;

namespace First
{
    class Program
    {
        /* Geef het grootste argument als resultaat van de functie. Ga ervan uit dat de argumenten verschillend zijn.
		*/
        public static int bepaalGrootste(int a, int b)
        {
            //schrijf hier je code
            int grootste;
            if (a > b)
            {
                grootste = a;
            }
            else
            {
                grootste = b;
            }
            return grootste;
        }

        /* Ga na of twee getallen gelijk zijn. Geef true (gelijk) of false (niet gelijk) als resultaat
        */
        public static bool isGelijk(int a, int b)
        {
            bool gelijk = false;
            if (a == b)
            {
                gelijk = true;
            }
            return gelijk;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Naam oefening \t Verwacht resultaat \t Jouw resultaat");
            Console.WriteLine("bepaalGrootste \t 3 \t\t\t " + bepaalGrootste(1, 3));
            Console.WriteLine("bepaalGrootste \t 3 \t\t\t " + bepaalGrootste(3, 1));
            Console.WriteLine("bepaalGrootste \t False \t\t\t " + isGelijk(5, 7));
            Console.WriteLine("bepaalGrootste \t True \t\t\t " + isGelijk(5, 5));
            Console.ReadKey();
        }
    }
}
