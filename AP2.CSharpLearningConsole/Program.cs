namespace AP2.CSharpLearningConsole
{
    internal class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Clear();

            Console.WriteLine("CSharpLearning");
            Console.WriteLine();

            // Integer Array werte anlegen mit 8,34,-2,3,21,0,15,3,45,-11
            int[] werte = new int[] { 8, 34, -2, 3, 21, 0, 15, 3, 45, -11 };

            // Double Array values anlegen mit 2.4,56.1,-5.6,74.2,12.7,33.8,-4.5
            double[] werteD = [2.4, 56.1, -5.6, 74.2, 12.7, 33.8, -4.5];

            // class SensorData(Id : int, Value : double, Timestamp : DateTime) anlegen (public attributes)
            // Konstruktor mit 3 Parameter anlegen
            // SensorData Array anlegen mit 
            // (1,34.2,new DateTime(2025,4,8)), (2,23.4,new DateTime(2025,4,8)), 
            // (1,56.1, new DateTime(2025,4,9)), (1,-3.5, new DateTime(2025,4,10))
            SensorData[] sensorData = new SensorData[] {
                new SensorData(1, 34.2, new DateTime(2025, 4, 8)),
                new SensorData(2,23.4,new DateTime(2025,4,8)),
                new SensorData(1,56.1, new DateTime(2025,4,9)),
                new SensorData(1,-3.5, new DateTime(2025,4,10))
            };

            Tests tests = new Tests();

            Console.WriteLine("ArrayAnzeigen:");
            tests.ArrayAnzeigen(werte);

            int anzahl = tests.BestimmeAnzahlUnter0(werte);
            Console.WriteLine("\nBestimmeAnzahlUnter0: " + anzahl);

            double anteil = tests.BestimmeAnteilUnter0(werte);
            Console.WriteLine($"\nBestimmeAnteilUnter0:     {anteil:N1} %");
            Console.WriteLine($"BestimmeAnteilUnter0Linq: {tests.BestimmeAnteilUnter0Linq(werte):N1} %");

            int min = tests.BestimmeMinimum(werte);
            Console.WriteLine($"\nBestimmeMinimum:      {min}");

            int max = tests.BestimmeMaximum(werte);
            Console.WriteLine($"\nBestimmeMaximum:      {max}");

            double median = tests.BestimmeMittelwert(werte);
            Console.WriteLine($"\nBestimmeMittelwert:      {median:N1}");
            Console.WriteLine($"BestimmeMittelwertLinq:  {tests.BestimmeMittelwertLinq(werte):N1}");

            int anzahlWert = tests.BestimmeAnzahl(werte, 3);
            Console.WriteLine($"\nBestimmeAnzahl(3):     {anzahlWert}");
            Console.WriteLine($"BestimmeAnzahlLinq(3): {tests.BestimmeAnzahlLinq(werte, 3)}");

            int[] negatives = tests.FindNegatives(werte);
            Console.WriteLine("\nFindNegatives:");
            tests.ArrayAnzeigen(negatives);
            Console.WriteLine($"FindNegativesLinq:");
            tests.ArrayAnzeigen(tests.FindNegativesLinq(werte));

            string negativesStr = tests.FindNegativesAsString(werte);
            Console.WriteLine($"\nFindNegativesAsString:    {negativesStr}");
            Console.WriteLine($"FindNegativesAsString2:   {tests.FindNegativesAsString2(werte)}");
            Console.WriteLine($"FindNegativesAsStingLinq: {tests.FindNegativesAsStringLinq(werte)}");

            int[] evens = tests.FindEven(werte);
            Console.WriteLine($"\nFindEven:");
            tests.ArrayAnzeigen(evens);
            Console.WriteLine($"FindEvenLinq:");
            tests.ArrayAnzeigen(tests.FindEvenLinq(werte));

            double[] medians = tests.BerechneMittelUeber2(werte);
            Console.WriteLine("\nBerechneMittelÜber2: ");
            tests.ArrayAnzeigen(medians);

            List<int> foundMinMax = tests.Find(werte, 0, 25);
            Console.WriteLine("\nFind: ");
            tests.ArrayAnzeigen(foundMinMax.ToArray());
            Console.WriteLine("FindLinq: ");
            tests.ArrayAnzeigen(tests.FindLinq(werte, 0, 25).ToArray());

            List<int> foundNegatives = tests.FindNegativesAsList(werte);
            Console.WriteLine($"\nFindNegativesAsList: ");
            tests.ArrayAnzeigen(foundNegatives.ToArray());
            Console.WriteLine($"FindNegativesAsListLinq: ");
            tests.ArrayAnzeigen(tests.FindNegativesAsListLinq(werte).ToArray());

            Console.ReadLine();
        }
    }
}
