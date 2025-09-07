namespace AP2.CSharpLearningConsole;

class SensorData
{
    public int Id;
    public double Value;
    public DateTime Timestamp;

    // Implementiere Konstruktor mit 3 Parametern
    public SensorData(int id, double value, DateTime timestamp)
    {
        Id = id;
        Value = value;
        Timestamp = timestamp;
    }

    // Implementiere ToString()-Methode
    public override string ToString()
    {
        return $"(Id: {Id} Value: {Value} Timestamp: {Timestamp.ToShortDateString()}) ";
    }

}