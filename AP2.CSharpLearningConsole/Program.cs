namespace AP2.CSharpLearningConsole
{
    internal class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
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

            Console.WriteLine("ArrayAnzeigen: (werte)");
            tests.ArrayAnzeigen(werte);
            Console.ForegroundColor = ConsoleColor.Gray;

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
            Console.Write($"\nFindNegatives:     ");
            tests.ArrayAnzeigen(negatives);
            Console.Write($"FindNegativesLinq: ");
            tests.ArrayAnzeigen(tests.FindNegativesLinq(werte));

            string negativesStr = tests.FindNegativesAsString(werte);
            Console.WriteLine($"\nFindNegativesAsString:    {negativesStr}");
            Console.WriteLine($"FindNegativesAsString2:   {tests.FindNegativesAsString2(werte)}");
            Console.WriteLine($"FindNegativesAsStingLinq: {tests.FindNegativesAsStringLinq(werte)}");

            int[] evens = tests.FindEven(werte);
            Console.Write($"\nFindEven:     ");
            tests.ArrayAnzeigen(evens);
            Console.Write($"FindEvenLinq: ");
            tests.ArrayAnzeigen(tests.FindEvenLinq(werte));

            double[] medians = tests.BerechneMittelUeber2(werte);
            Console.Write("\nBerechneMittelÜber2:     ");
            tests.ArrayAnzeigen(medians);
            Console.Write("BerechneMittelÜber2List: ");
            tests.ArrayAnzeigen(tests.BerechneMittelUeber2List(werte));

            List<int> foundMinMax = tests.Find(werte, 0, 25);
            Console.Write("\nFind:     ");
            tests.ArrayAnzeigen(foundMinMax.ToArray());
            Console.Write("FindLinq: ");
            tests.ArrayAnzeigen(tests.FindLinq(werte, 0, 25).ToArray());

            List<int> foundNegatives = tests.FindNegativesAsList(werte);
            Console.Write($"\nFindNegativesAsList:     ");
            tests.ArrayAnzeigen(foundNegatives.ToArray());
            Console.Write($"FindNegativesAsListLinq: ");
            tests.ArrayAnzeigen(tests.FindNegativesAsListLinq(werte).ToArray());

            Console.Write($"\nListeAnzeigen:        ");
            tests.ListeAnzeigen(foundNegatives);
            Console.Write($"ListeAnzeigenForeach: ");
            tests.ListeAnzeigenForeach(foundNegatives);

            Console.Write($"\nListeAnzeigenGeneric<>: ");
            tests.ListeAnzeigen<double>(tests.BerechneMittelUeber2List(werte).ToList());

            // -------------------------------------------------------------------------
            // SensorData
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\n[SensorData]\n-----------------------------------------------------------------------\n");

            Console.WriteLine("SensorArrayAnzeigen: ");
            tests.SensorArryAnzeigen(sensorData);
            Console.ForegroundColor = ConsoleColor.Gray;

            int sensorU0 = tests.BestimmeAnzahlSensoDataUnter0(sensorData);
            Console.WriteLine($"\nBestimmeAnzahlSensorDataUnter0:     {sensorU0}");
            Console.WriteLine($"BestimmeAnzahlSensorDataUnter0Linq: {tests.BestimmeAnzahlSensoDataUnter0Linq(sensorData)}");

            double anteilU0 = tests.BestimmeAnteilSensorDataUnter0(sensorData);
            Console.WriteLine($"\nBestimmeAnteilSensorDataUnter0:     {anteilU0:N1} %");
            Console.WriteLine($"BestimmeAnteilSensorDataUnter0Linq: {tests.BestimmeAnteilSensorDataUnter0Linq(sensorData):N1} %");

            double sensorMin = tests.BestimmeSensorDataMinimum(sensorData);
            Console.WriteLine($"\nBestimmeSensorDataMinimum:     {sensorMin}");
            Console.WriteLine($"BestimmeSensorDataMinimumLinq: {tests.BestimmeSensorDataMinimumLinq(sensorData)}");
            
            double sensorMax = tests.BestimmeSensorDataMaximum(sensorData);
            Console.WriteLine($"\nBestimmeSensorDataMaximum:     {sensorMax}");
            Console.WriteLine($"BestimmeSensorDataMaximumLinq: {tests.BestimmeSensorDataMaximumLinq(sensorData)}");
            
            double sensorMedian = tests.BestimmeSensorDataMittelwert(sensorData);
            Console.WriteLine($"\nBestimmeSensorDataMittelwert:     {sensorMedian}");
            Console.WriteLine($"BestimmeSensorDataMittelwertLinq: {tests.BestimmeSensorDataMittelwertLinq(sensorData)}");

            double sensorMedianDate = tests.BestimmeSensorDataMittelwert(sensorData, new DateTime(2025, 4, 8));
            Console.WriteLine($"\nBestimmeSensorDataMittelwert(datum):     {sensorMedianDate}");
            sensorMedianDate = tests.BestimmeSensorDataMittelwertLinq(sensorData, new DateTime(2025, 4, 8));
            Console.WriteLine($"BestimmeSensorDataMittelwertLinq(datum): {sensorMedianDate}");

            double sensorCountTimespan = tests.BestimmeAnzahlSensorData(
                sensorData, new DateTime(2025, 4, 8), new DateTime(2025, 4, 9));
            Console.WriteLine($"\nBestimmeAnzahlSensorData(timespan):     {sensorCountTimespan}");
            sensorCountTimespan = tests.BestimmeAnzahlSensorDataLinq(
                sensorData, new DateTime(2025, 4, 8), new DateTime(2025, 4, 9));
            Console.WriteLine($"BestimmeAnzahlSensorDataLinq(timespan): {sensorCountTimespan}");

            SensorData sdMax = tests.FindSensorDataMaximum(sensorData);
            Console.WriteLine($"\nFindSensorDataMaximum:        {sdMax}");
            Console.WriteLine($"FindSensorDataMaximumLinq:    {tests.FindSensorDataMaximumLinq(sensorData)}");
            Console.WriteLine($"FindSensorDataMaximumForeach: {tests.FindSensorDataMaximumForeach(sensorData)}");

            List<SensorData> sdTimespan = tests.FindSensorData(
                sensorData, new DateTime(2025, 4, 8), new DateTime(2025, 4, 9));
            Console.WriteLine($"\nFindSensorData(timespan):");
            tests.SensorArryAnzeigen(sdTimespan.ToArray());
            sdTimespan = tests.FindSensorDataLinq(
                sensorData, new DateTime(2025, 4, 8), new DateTime(2025, 4, 9));
            Console.WriteLine($"FindSensorDataLinq(timespan):");
            tests.SensorArryAnzeigen(sdTimespan.ToArray());

            List<SensorData> sdId = tests.FindSensorData(sensorData, 1);
            Console.WriteLine($"\nFindSensorData(id):");
            tests.SensorArryAnzeigen(sdId.ToArray());
            Console.WriteLine($"FindSensorDataLinq(id):");
            tests.SensorArryAnzeigen(tests.FindSensorDataLinq(sensorData, 1).ToArray());

            int countId = tests.BestimmeAnzahlSensoren(sensorData);
            Console.WriteLine($"\nBestimmeAnzahlSensoren: {countId}");

            Dictionary<DateTime, int> sensorCountByDate = tests.BestimmeAnzalSensorenProTag(sensorData);
            Console.WriteLine("\nBestimmeAnzahlSensorenProTag:");
            Console.WriteLine("+ DictionaryAnzeigen:");
            tests.DictionaryAnzeigen(sensorCountByDate);

            Console.ReadLine();
        }
    }
}
