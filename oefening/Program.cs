using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Oef
    {
        /* Geef het grootste argument als resultaat van de functie. Ga ervan uit dat de argumenten verschillend zijn.
        */
        public static int BepaalGrootste(int a, int b)
        {
            // schrijf hier je code
            return 0;
        }

        /* Ga na of twee getallen gelijk zijn. Geef true (gelijk) of false (niet gelijk) als functieresultaat.
        */
        public static bool IsGelijk(int a, int b)
        {
            // schrijf hier je code
            return true;
        }

        /* Test of de drie doorgegeven hoeken de hoeken van een driehoek kunnen zijn. Geef als functieresultaat true (het zijn hoeken
         * van een driehoek) of false (het zijn niet de hoeken van een driehoek).
         */
        public static bool HoekenDriehoek(int a, int b, int c)
        {
            // schrijf hier je code
            return true;
        }

        /* Test of het argument een even getal bevat. Geef true (even getal) of false (oneven getal) als functieresultaat.
        */
        public static bool IsEven(int getal)
        {
            // schrijf hier je code
            return true;
        }

        /* Test of het eeste getal deelbaar is door het tweede. Geef 'Deelbaar' of 'Niet deelbaar' als functieresultaat.
         */
        public static string IsDeelbaar(int getal1, int getal2)
        {
            // schrijf hier je code
            return " ";
        }

        /* De x en y-coördinaat van een punt worden als argument doorgegeven aan de functie. Geef als functieresultaat het
         * kwadrant waarin het punt gelegen is.
         * Toon de volledige naam van het kwadrant, niet enkel het nummer: 'Kwadrant 1', 'Kwadrant 2', ...
         */
        public static string BepaalKwadrant(int x, int y)
        {
            // schrijf hier je code
            return " ";
        }

        /* De lengte van de drie zijden van een driehoek worden als argument doorgegeven aan de functie. De functie geeft het
         * type driehoek als resultaat ('Gelijkzijdig', 'Gelijkbenig', 'Ongelijkzijdig').
         */
        public static string BepaalType(float a, float b, float c)
        {
            // schrijf hier je code
            return " ";
        }

        /* Ga na of het karakter een kleine letter of een hoofdletter is. Als er geen letter als karakter doorgegeven wordt aan de
         * functie geef je een gepaste melding als functieresultaat.
         * Tip: baseer je op de ASCII-tabel.
         * Als functieresultaat geef je 'Hoofdletter', 'Kleine letter' of 'Geen letter'.
         */
        public static string TestLetter(char c)
        {
            // schrijf hier je code
            return " ";
        }

        /* Ga na of het opgegeven jaartal een schrikkeljaar is. Als functieresultaat voorzie je 'Schrikkeljaar' en 'Geen schrikkeljaar'.
         * Een jaar met jaartal deelbaar door 4 is een schrikkeljaar. Andere jaren zijn gewone jaren. 
         * Maar omwille van de kalenderhervorming zijn ook de jaren deelbaar door 100 gewone jaren (ook al zijn ze deelbaar door 4),
         * tenzij ze deelbaar zijn door 400. Dan zijn ze schrikkeljaren.
         * Opm.: Verder in de cursus zal je zien dat C# een handige functie heeft om te bepalen dat een jaar een 
         * schrikkeljaar is en dat je deze functie kan gebruiken i.p.v. zelf de nodige code hiervoor te schrijven. Het
         * uitwerken van deze code is dus louter als oefening bedoeld. Kijk steeds na of er in je programmeertaal
         * reeds een gepaste functie voorzien is voordat je zelf een functionaliteit uitwerkt.
         */
        public static string TestSchrikkel(int jaartal)
        {
            // schrijf hier je code
            return " ";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Naam oefening \t Verwacht resultaat \t Jouw resultaat");
            Console.WriteLine("BepaalGrootste \t 3 \t\t\t " + BepaalGrootste(1, 3));
            Console.WriteLine("BepaalGrootste \t 3 \t\t\t " + BepaalGrootste(3, 1));
            Console.WriteLine("IsGelijk \t False \t\t\t " + IsGelijk(5, 7));
            Console.WriteLine("IsGelijk \t True \t\t\t " + IsGelijk(5, 5));
            Console.WriteLine("HoekenDriehoek \t False \t\t\t " + HoekenDriehoek(50, 15, 20));
            Console.WriteLine("HoekenDriehoek \t True \t\t\t " + HoekenDriehoek(90, 45, 45));
            Console.WriteLine("IsEven \t\t False \t\t\t " + IsEven(5));
            Console.WriteLine("IsEven \t\t True \t\t\t " + IsEven(4));
            Console.WriteLine("IsDeelbaar \t Niet deelbaar \t\t " + IsDeelbaar(10, 4));
            Console.WriteLine("IsDeelbaar \t Deelbaar \t\t " + IsDeelbaar(10, 5));
            Console.WriteLine("BepaalKwadrant \t Kwadrant 1 \t\t " + BepaalKwadrant(2, 5));
            Console.WriteLine("BepaalKwadrant \t Kwadrant 2\t\t " + BepaalKwadrant(-2, 5));
            Console.WriteLine("BepaalKwadrant \t Kwadrant 3\t\t " + BepaalKwadrant(-3, -5));
            Console.WriteLine("BepaalKwadrant \t Kwadrant 4\t\t " + BepaalKwadrant(3, -5));
            Console.WriteLine("TestLetter \t Kleine letter\t\t " + TestLetter('d'));
            Console.WriteLine("TestLetter \t Hoofdleter\t\t " + TestLetter('C'));
            Console.WriteLine("TestLetter \t Geen letter\t\t " + TestLetter('%'));
            Console.WriteLine("TestSchrikkel \t Geen schrikkeljaar\t " + TestSchrikkel(1000));
            Console.WriteLine("TestSchrikkel \t Schrikkeljaar\t\t " + TestSchrikkel(1600));
            Console.WriteLine("TestSchrikkel \t Geen schrikkeljaar\t " + TestSchrikkel(1950));
            Console.WriteLine("TestSchrikkel \t Schrikkeljaar\t\t " + TestSchrikkel(2004));
            Console.WriteLine("BepaalType \t Gelijkzijdig\t\t " + BepaalType(2.5F, 2.5F, 2.5F));
            Console.WriteLine("BepaalType \t Gelijkbenig\t\t " + BepaalType(2.5F, 2.5F, 3.9F));
            Console.WriteLine("BepaalType \t Gelijkbenig\t\t " + BepaalType(2.5F, 3.9F, 2.5F));
            Console.WriteLine("BepaalType \t Gelijkbenig\t\t " + BepaalType(3.9F, 2.5F, 2.5F));
            Console.WriteLine("BepaalType \t Ongelijkzijdig\t\t " + BepaalType(1.2F, 3.8F, 2.7F));


            Console.ReadKey();
        }
    }
}


