// See https://aka.ms/new-console-template for more information


using molk;
using System;
/**
 * Skapa en klass Grundämne (Element på engelska) för länder med de publika attributen
namn, Z (atomnummer), typ, smältpunkt, kokpunkt (bägge i Kelvin). Skapa ett publikt
github-repo IDP_assg_3 för programmet.
2. Instansiera tre grundämnen syre, järn och guld och deras data med:
syre 8 ickemetall 54.36 90.188
järn 26 metall 1811 3134
guld 79 metall 1337.33 3243
Stagea, committa och pusha!
3. Skapa en (vanlig) publik metod Print i Grundämne som skriver ut grundämnet, ungefär så
här:
Grundämne: syre
 typ: ickemetall
 smältpunkt: 54,6 K
 kokpunkt: 90,188 K
Skriv ut syre, järn och guld! Stagea, committa och pusha!
4. Skapa en array av 6 grundämnen, och tilldela 0 till 2 av arrayen värdena i syre, järn och
guld! Direkt-tilldela de tre övriga indexen i arrayen värdena:
väte 1 ickemetall 13.99 20.271
brom 35 ickemetall 265.8 332.0
kvicksilver 80 metall 234.3210 629.88
Stagea, committa och pusha!
5. Skapa en foreach-loop som går igenom alla element i arrayen och skriver ut länderna en
efter en. Stagea, committa och pusha!

 */



public class Program
{
    static void Main(string[] args)
    {
        Assignment3();
        Assignment4();
    }
    private static void Assignment3()
    {
        PrintGrundamne();
        PrintSolution4();
        PrintSolution5();
    }

    private static void PrintGrundamne() 
    {
        Grundamne syre = new("Syre", 8, "Icke-metall", 54.36, 90.188);
        Grundamne järn = new("Järn", 26, "Metall", 1811, 3134);
        Grundamne guld = new("Guld", 79, "Metall", 1337.33, 3243);

        Grundamne[] grundamnen = { syre, järn, guld };

        foreach (Grundamne grundämne in grundamnen)
        {
            grundämne.Print();
            Console.WriteLine();
        }

        Console.ReadKey();
    }

    private static void PrintSolution4() 
    {
        Grundamne[] grundämnen = new Grundamne[6];

        grundämnen[0] = new("syre", 8, "ickemetall", 54.6, 90.188);
        grundämnen[1] = new("järn", 26, "metall", 1811, 3134);
        grundämnen[2] = new("guld", 79, "metall", 1337.33, 3129);
        grundämnen[3] = new("väte", 1, "ickemetall", 13.99, 20.271);
        grundämnen[4] = new("brom", 35, "ickemetall", 265.8, 332.0);
        grundämnen[5] = new("kvicksilver", 80, "metall", 234.3210, 629.88);

        foreach (Grundamne grundämne in grundämnen)
        {
            grundämne.Print();
            Console.WriteLine();
        }
    }

    private static void PrintSolution5() 
    {
        Grundamne[] grundämnen = new Grundamne[6];

        grundämnen[0] = new("syre", 8, "ickemetall", 54.6, 90.188);
        grundämnen[1] = new("järn", 26, "metall", 1811, 3134);
        grundämnen[2] = new("guld", 79, "metall", 1337.33, 3129);
        grundämnen[3] = new("väte", 1, "ickemetall", 13.99, 20.271);
        grundämnen[4] = new("brom", 35, "ickemetall", 265.8, 332.0);
        grundämnen[5] = new("kvicksilver", 80, "metall", 234.3210, 629.88);
        Console.WriteLine("Metaller:");
        foreach (Grundamne grundämne in grundämnen)
        {
            if (grundämne.typ == "metall")
            {
                Console.WriteLine(grundämne.namn);
            }
        }

        Console.WriteLine("Grundämnen med smältpunkt under 273.16 K och kokpunkt över 273.16 K:");
        foreach (Grundamne grundämne in grundämnen)
        {
            if (grundämne.smaltpunkt < 273.16 && grundämne.kokpunkt > 273.16)
            {
                grundämne.Print();
                Console.WriteLine();
            }
        }
    }
    private static void Assignment4()
    {
        PrintTimeForLightToReachEarth();
        PrintInverseSqure();
        PrintSumAllEvenNumbersBetweenTwoNumbers();
        PrintShiftArray();
        PrintInverseSum();
        PrintSpecies();

    }
    private static void PrintTimeForLightToReachEarth()
    {
        const double lightSpeed = 299792.458; // speed of light in km/s
        const double sunDistance = 149598023; // distance of the sun in km
        Assignment.CalculateTimeForLightToReachEarth(lightSpeed, sunDistance);
    }

    private static void PrintInverseSqure()
    {
        double[] values = { 2, 3, 4, 5 };
        foreach (double value in values)
        {
            Console.WriteLine($"{value} {Assignment.InverseSqr(value)}");
        }

    }

    private static void PrintSumAllEvenNumbersBetweenTwoNumbers()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = Assignment.SumAllEvenNumbersBetweenTwoNumbers(num1, num2);
        Console.WriteLine($"The sum of all even numbers between {num1} and {num2} is {sum}.");

        sum = Assignment.SumAllEvenNumbersBetweenTwoNumbersUsingLinq(num1, num2);
        Console.WriteLine($"The sum of all even numbers between {num1} and {num2} is {sum}.");

    }

    private static void PrintShiftArray()
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        arr = Assignment.ShiftArray(arr);
        Console.Write(" shifted array ");
        foreach (int value in arr)
        {
            Console.Write($"{value} ");
        }
    }

    public static void PrintInverseSum()
    {
        try
        {
            Console.WriteLine("Enter number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            double result = Assignment.InverseSum(num1, num2);
   
            Console.WriteLine($"The Inverse sum of {num1} and {num2} is {result}");
        }
        catch (FormatException e)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
        catch (OverflowException e)
        {
            Console.WriteLine("The entered number is too large or too small.");
        }

    }

    public static void PrintSpecies()
    {
        
        Species wildHorse = new()
        {
            Name = "Wild horse",
            Genus = "Equus",
            SpeciesName = "ferus",
            Range = "Mongolia"
        };

        wildHorse.Print();

        Species mountainZebra = new()
        {
            Name = "Mountain zebra",
            Genus = "Equus",
            SpeciesName = "zebra",
            Range = "Namibia and South Africa"
        };
        mountainZebra.Print();

        Species plainsZebra = new()
        {
            Name = "Plains zebra",
            Genus = "Equus",
            SpeciesName = "quagga",
            Range = "Africa"
        };
        plainsZebra.Print();

        Species africanWildDonkey = new()
        {
            Name = "African wild donkey",
            Genus = "Equus",
            SpeciesName = "africanus",
            Range = "Egypt, Sudan, Eritrea and Ethiopia"
        };
        africanWildDonkey.Print();


        Species[] speciesArray = new Species[]
        {
        wildHorse,
        mountainZebra,
        plainsZebra,
        africanWildDonkey
        };
        foreach (Species species in speciesArray)
        {
            species.Print();
        }
    }
    
}