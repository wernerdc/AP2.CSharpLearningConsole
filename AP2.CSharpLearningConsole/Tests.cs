namespace AP2.CSharpLearningConsole
{
    public class Tests
    {
        // Implementiere die Methode ArrayAnzeigen, die ein int Array ar übernimmt 
        // und die Werte des Array in einer Zeile mit Abstand auf die Konsole ausgibt	
        public void ArrayAnzeigen(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write(ar[i] + " ");
            }
            Console.WriteLine();
        }

        // Implementiere die Methode BestimmeAnzahlUnter0, die ein int Array ar übernimmt, 
        // die Anzahl der Werte unter 0 bestimmt und zurückgibt.
        public int BestimmeAnzahlUnter0(int[] ar)
        {
            int anzahl = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < 0)
                    anzahl++;
            }
            return anzahl;
        }

        // Implementiere die Methode BestimmeAnteilUnter0, die ein int Array ar übernimmt, 
        // den Anteil der Werte unter 0 bestimmt und zurückgibt.
        public double BestimmeAnteilUnter0(int[] ar)
        {
            int count = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < 0)
                    count++;
            }

            return count * 100 / (double) ar.Length;
        }

        public double BestimmeAnteilUnter0Linq(int[] ar)
        {
            return ar.Count(val => val < 0) * 100 / (double) ar.Length;
        }

        // Implementiere die Methode BestimmeMinimum, die ein int Array ar übernimmt 
        // und das Minimum der Werte zurückgibt
        public int BestimmeMinimum(int[] ar)
        {
            int min = ar[0];
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }
            }

            return min;
        }

        // Implementiere die Methode BestimmeMaximum, die ein int Array ar übernimmt 
        // und das Maximum der Werte zurückgibt
        public int BestimmeMaximum(int[] ar)
        {
            int max = ar[0];
            foreach (int val in ar)
            {
                if (val > max)
                {
                    max = val;
                }
            }

            return max;
        }

        // Implementiere die Methode BestimmeMittelwert, die ein int Array ar übernimmt 
        // und den Mittelwert berechnet und zurückgibt
        public double BestimmeMittelwert(int[] ar)
        {
            int sum = 0;
            foreach (int val in ar)
            {
                sum += val;
            }

            return sum / (double) ar.Length;
        }

        public double BestimmeMittelwertLinq(int[] ar)
        {
            return ar.Sum() / (double) ar.Length;
        }

        // Implementiere die Methode BestimmeAnzahl, die ein int Array ar und 
        // einen weiteren Parameter wert : int übernimmt und die Anzahl der Werte, 
        // die wert entsprechen zurückgibt
        public int BestimmeAnzahl(int[] ar, int wert)
        {
            int count = 0;
            foreach (int val in ar)
            {
                if (val == wert)
                {
                    count++;
                }
            }
            
            return count;
        }

        public int BestimmeAnzahlLinq(int[] ar, int wert)
        {
            return ar.Count(val => val == wert);
        }

        // Implementiere die Methode FindNegatives, die ein int Array ar übernimmt 
        // und ein neues Array mit den negativen Werten zurückgibt 
        public int[] FindNegatives(int[] ar)
        {
            List<int> list = new();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < 0)
                    list.Add(ar[i]);
            }

            return list.ToArray();
        }

        public int[] FindNegativesLinq(int[] ar)
        {
            return ar.Where(x => x < 0).ToArray();
        }

        // Implementiere die Methode FindNegativesAsString, die ein int Array ar übernimmt 
        // und einen String mit den negativen Werten, getrennt mit Komma zurückgibt
        public string FindNegativesAsString(int[] ar)
        {
            string results = "";
            foreach (int val in ar)
            {
                if (val < 0)
                {
                    if (results.Length > 0)
                    {
                        results += ", ";
                    }
                    results += val;
                }
            }
            
            return results;
        }

        public string FindNegativesAsString2(int[] ar)
        {
            List<int> list = new();
            foreach (int val in ar)
            {
                if (val < 0)
                {
                    list.Add(val);
                }
            }

            return String.Join(", ", list);
        }

        public string FindNegativesAsStringLinq(int[] ar)
        {
            return String.Join(", ", ar.Where(val => val < 0));
        }


        // Implementiere die Methode FindEven, die ein int Array ar übernimmt 
        // und ein neues Array nur mit den geraden Zahlen zurückgibt
        public int[] FindEven(int[] ar)
        {
            List<int> results = new();
            foreach (int val in ar)
            {
                if (val %2 == 0)
                {
                    results.Add(val);
                }
            }

            return results.ToArray();
        }

        public int[] FindEvenLinq(int[] ar)
        {
            return ar.Where(val => val % 2 == 0).ToArray();
        }


        // Implementiere die Methode BerechneMittelÜber2, die ein int Array ar übernimmt 
        // und ein neues Array halber Länge zurückgibt, deren Werte jeweils das Mittel 
        // zweier benachbarter Werte sind
        public double[] BerechneMittelUeber2(int[] ar)
        {
            List<double> results = new();
            for (int i = 0; i < ar.Length; i += 2)
            {
                if (i < ar.Length - 1)
                {
                    double median = (ar[i] + ar[i + 1]) / 2.0;
                    results.Add(median);
                }
            }
            return results.ToArray();
        }

        // Implementiere die Methode ArrayAnzeigen, die ein double Array ar übernimmt 
        // und die Werte des Array in einer Zeile mit Abstand auf die Konsole ausgibt	
        public void ArrayAnzeigen(double[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]:N1} ");
            }
            Console.WriteLine();
        }

        // Implementiere die generische Methode ArrayAnzeigen<T>, die ein Array ar von Typ T[] übernimmt 
        // und die Werte des Array in einer Zeile mit Abstand auf die Konsole ausgibt	
        public void ArrayAnzeigen<T>(T[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                Console.Write($"{ar[i]} ");
            }
            Console.WriteLine();
        }

        // Implementiere die Methode Find, die ein int Array ar und zwei weitere 
        // Parameter min : int und max : int übernimmt und eine generische Liste 
        // List<int> zurückgibt, die alle Werte zwischen min und max enthält
        public List<int> Find(int[] ar, int min, int max)
        {
            List<int> results = new();
            foreach (int val in ar)
            {
                if (val > min && val < max)
                {
                    results.Add(val);
                }
            }
            return results;
        }

        public List<int> FindLinq(int[] ar, int min, int max)
        {
            return ar.Where(val => val > min && val < max).ToList();
        }


        // Implementiere die Methode FindNegativesAsList, die ein int Array ar übernimmt 
        // und die negativen Werte in einer generischen Liste List<int> zurückgibt
        public List<int> FindNegativesAsList(int[] ar)
        {
            List<int> results = new();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < 0)
                    results.Add(ar[i]);
            }

            return results;
        }

        public List<int> FindNegativesAsListLinq(int[] ar)
        {
            return ar.Where(val => val < 0).ToList();
        }


        // Implementiere die Methode ListeAnzeigen, die eine Liste<int> übernimmt 
        // und die Werte in einer Zeile auf die Konsole ausgibt - mit for.


        // Implementiere die Methode ListeAnzeigenForeach, die eine Liste<int> übernimmt 
        // und die Werte in einer Zeile auf die Konsole ausgibt - mit foreach.


        // Implementiere die generische Methode ListeAnzeigen<T>, die eine generische Liste<T> übernimmt 
        // und die Werte in einer Zeile auf die Konsole ausgibt.


        // --- SensorData ---
        // Implementiere die Methode BestimmeAnzahlSensorDataUnter0, die ein SensorData Array sd übernimmt 
        // und die Anzahl SensorData Objekte mit Value unter 0 bestimmt und zurückgibt.



        // Implementiere die Methode BestimmeAnteilSensorDataUnter0, die ein SensorData Array sd übernimmt 
        // und den Anteil SensorData Objekte mit Value unter 0 bestimmt und zurückgibt.



        // Implementiere die Methode BestimmeSensorDataMinimum, die ein SensorData Array sd übernimmt 
        // und das Minimum der Values zurückgibt


        // Implementiere die Methode BestimmeSensorDataMaximum, die ein SensorData Array sd übernimmt 
        // und das Maximum der Values zurückgibt


        // Implementiere die Methode BestimmeSensorDataMittelwert, die ein SensorData Array sd übernimmt 
        // und den Mittelwert der Values berechnet und zurückgibt


        // Implementiere die Methode BestimmeSensorDataMittelwert, die ein SensorData Array sd
        // und einen Parameter datum : DateTime übernimmt und den Mittelwert der Values
        // am übergebenen datum berechnet und zurückgibt
        // datum.Date gibt das Datum ohne Uhrzeit zurück


        // Implementiere die Methode BestimmeAnzahlSensorData, die ein SensorData Array sd
        // und zwei Parameter von : DateTime und bis : Datum übernimmt und die Anzahl Objekte
        // zwischen diesen und an diesen Daten (einschließlich) bestimmt und zurückgibt
        // Hinweis: von.Date gibt das Datum ohne Uhrzeit zurück



        // Implementiere die Methode FindSensorDataMaximum, die ein SensorData Array sd übernimmt 
        // und das SensorData Objekt zurückgibt, das den maximalen Value besitzt - mit for


        // Implementiere die Methode FindSensorDataMaximumForEach, die ein SensorData Array sd übernimmt 
        // und das SensorData Objekt zurückgibt, das den maximalen Value besitzt - mit foreach


        // Implementiere die Methode FindSensorData, die ein SensorData Array sd
        // und zwei Parameter von : DateTime und bis : Datum übernimmt und die Objekte
        // zwischen diesen und an diesen Daten (einschließlich) in einer
        // neuen Liste zurückgibt.  Hinweis: von.Date gibt das Datum ohne Uhrzeit zurück


        // Implementiere die Methode FindSensorData, die ein SensorData Array sd
        // und einen Parameter sensorId : int übernimmt und die Objekte
        // dieses Sensors in einer neuen Liste zurückgibt.


        // Implementiere die Methode BestimmeAnzahlSensoren, die ein SensorData Array sd
        // übernimmt und die Anzahl unterschiedlicher Sensor-Ids zurückgibt.
        // Hinweis: Verwende eine HashSet<int> um die Anzahl der Sensoren zu bestimmen


        // Implementiere die Methode BestimmeAnzahlSensorenProTag, die ein SensorData Array sd
        // übernimmt und für jeden vorhandenen Tag die Anzahl existierender SensorData Objekte zurückgibt.
        // Hinweis: Verwende ein Dictionary<DateTime, int> um die Anzahl der Sensoren pro Tag zu bestimmen


        // Implementiere die Methode DictionaryAnzeigen, die ein Dictionary<DateTime, int> dict übernimmt 
        // und auf die Konsole ausgibt.

    }
}