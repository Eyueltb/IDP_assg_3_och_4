using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * 1. 10 poäng: Låt C# räkna ut hur många minuter det tar för oss att upptäcka det, om solen
omedelbart slocknar och blir svart. Använd följande konstanter:
ljushastigheten i km/s 299792.458
solens medelavstånd i km 149598023
sekunder per minut 60
Deklarera och initiera variabler för dessa tre konstanter, och deklarera en variabel för
slutresultatet, t.ex. tidIMinuterFörLjusetAttGåFrånSolenTillJorden (bara ett
exempel!)! Skriv ut slutresultatet!
(Slutresultatet ska visserligen bli cirka 8.317 minuter, men skriv korrekta och läsliga
deklarationer)
Static-metoder (funktioner):
2. 10 poäng: Gör en funktion (static-metod) InvSqr som returnerar 1/(X*X)! Testa den med
några värden, såsom
2 0.25
3 0.111111111111111 (cirka)
4 0.0625
5 0.04
(det spelar ingen roll om du vid utskrift får decimalkomma eller decimalpunkt)
Loopar (och kanske en if-sats?):
3. 10 poäng: Gör ett program som frågar efter två tal och räknar ut summan av alla jämna tal
mellan dem. Om vi exempelvis anger 4 och 10 så räknas summan av 4+6+8+10 ut, medan 5,
7 och 9 ignoreras. Testa programmet med 2 och 10, 6 och 11, 7 och 9:
mata in tal 1: 2
mata in tal 2: 10
summa = 30
mata in tal 1: 6
mata in tal 2: 11
summa = 24
mata in tal 1: 7
mata in tal 2: 9
summa = 8
Arrayer (och några loopar):
4. 10 poäng: Skapa en array som innehåller {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}! Gör en loop (t.ex. en
for-loop), som förflyttar innehållet så att det ser ut så här efteråt: {2, 3, 4, 5, 6, 7, 8, 9, 10,
1}, d.v.s. alla element utom det första flyttas ned ett steg i arrayen, medan det första läggs
sist. Gör en loop som skriver ut arrayen!
Static-metod:
5. 10 poäng: Gör en funktion (static-metod) som tar två heltal m och n som argument och
returnerar summan av alla inverser (inversen av m är 1/m) på alla heltal m, m+1, m+2 o.s.v. till
och med n! Summan skall förstås vara av typen double. Testa programmet med 2 och 10, 6
och 11, 7 och 9:
mata in tal 1: 2
mata in tal 2: 10
summa = 1.92896825396825
mata in tal 1: 6
mata in tal 2: 11
summa = 0.736544011544012
mata in tal 1: 7
mata in tal 2: 9
summa = 0.378968253968254
Objekt:
6. 15 poäng: Djurarter har förutom sitt allmänna namn ett vetenskapligt binomialt namn
(kallas ofta "latin" men är en ogrammatisk blanding av grekiska, latin och alla möjliga språk
och namn på platser och personer). Exempelvis har häst (horse) det binomiala namnet
Equus ferus – där det första ordet Equus är namn på släkte (genus) – släktesnamnet börjar
alltid på stor bokstav – och det andra ordet ferus är namn på art (species) – artnamnet börjar
alltid på liten bokstav.
a. Gör en klass Species som innehåller attributen namn (eller om du föredrar engelska:
name), släkte (genus) och art (species), samt en sträng utbredning (range) som beskriver
en djurart.
b. Skapa en Print-metod som skrivet ut instanser av klassen (alltså objekt)!
c. Skapa objekt för följande arter (det behöver bara vara fyra attribut, du får välja mellan
svenskt och engelskt namn):
1. Vildhäst/Wild horse Equus ferus Mongoliet/Mongolia
2. Bergszebra/Mountain zebra Equus zebra Namibia och Sydafrika/
Namibia and South Africa
3. Stäppzebra/Plains zebra Equus quagga Afrika/Africa
4. Afrikansk vildåsna/
African wild donkey
Equus africanus Egypten, Sudan, Eritrea och
Etiopien/
Egypt, Sudan, Eritrea and
Etiopia
Skriv ut de fyra arterna. Det är en bonus om du gör en array av arter och skriver ut denna
genom att loopa genom arrayen.
 */

using System.Linq;
namespace molk
{
    internal class Assignment
    {

        public static void CalculateTimeForLightToReachEarth(double lightSpeed, double sunDistance)
        {
            const int secondsPerMinute = 60; // second per minute

            double timeInSeconds = sunDistance / lightSpeed; // time in seconds for the light to reach the earth
            double timeInMinutes = timeInSeconds / secondsPerMinute; // convert to minutes

            Console.WriteLine($"It takes {timeInMinutes} minutes for the light to travel from the sun to the earth.");
        }
        
        public static double InverseSqr(double x)
        {
            return 1 / (x * x);
        }
               
        public static int SumAllEvenNumbersBetweenTwoNumbers(int num1, int num2)
        {
            int sum = 0;
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }

        public static int SumAllEvenNumbersBetweenTwoNumbersUsingLinq(int num1, int num2) 
        {
            return Enumerable.Range(num1, num2 - num1 + 1)
                     .Where(x => x % 2 == 0)
                     .Sum();
        }
       

        public static int[] ShiftArray(int [] arr) 
        {
            int first = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[arr.Length - 1] = first;

           return arr;
        }
    
        public static double InverseSum(int m, int n)
        {
            double sum = 0;
            for (int i = m; i <= n; i++)
            {
                sum += 1.0 / i;
            }
            return sum;
        }
       
    }

    class Species
    {
        public string? Name { get; set; }
        public string? Genus { get; set; }
        public string? SpeciesName { get; set; }
        public string? Range { get; set; }

        public void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Genus: " + Genus);
            Console.WriteLine("Species: " + SpeciesName);
            Console.WriteLine("Range: " + Range);
        }
    }

}




