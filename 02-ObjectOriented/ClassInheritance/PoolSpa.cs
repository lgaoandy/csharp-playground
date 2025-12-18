using System.Drawing;
using Pastel;

namespace InheritanceClasses;

public class Pool
{
    public double ChlorideLevel;    // e.g., in ppm
    public double WaterLevel;       // e.g., in feet
    private readonly string ColoredWater = "Water".Pastel(Color.DeepSkyBlue);
    private readonly string ColoredChloride = "Chloride".Pastel(Color.PaleGreen);

    // Constructor
    public Pool(double chloride, double water)
    {
        ChlorideLevel = chloride;
        WaterLevel = water;
    }

    // Setters
    public void SetWater(double water)
    {
        Console.WriteLine($"\nChanged {ColoredWater}: {WaterLevel} >> {water} ft.");
        WaterLevel = water;
    }

    public void SetChloride(double chloride)
    {
        Console.WriteLine($"\nChanged {ColoredChloride}: {ChlorideLevel} >> {chloride} ppm");
        ChlorideLevel = chloride;
    }

    // Methods
    // Protected methods can be inherited but cannot be accessed outside the class
    protected virtual void PrintHeader()
    {
        Console.WriteLine("\n--- Pool Status ---".Pastel(Color.White));
    }

    public virtual void DisplayStatus()
    {
        PrintHeader();
        Console.WriteLine($"{ColoredWater}: {WaterLevel}ft");
        Console.WriteLine($"{ColoredChloride}: {ChlorideLevel}ppm");
    }
}

public class Spa : Pool
{
    public double HeatTemperature;
    private readonly string ColoredTemperature = "Temperature".Pastel(Color.OrangeRed);

    public Spa(double chloride, double water, double temp) : base(chloride, water)
    {
        HeatTemperature = temp;
    }

    public void SetTemp(double temp)
    {
        Console.WriteLine($"\nChanged {ColoredTemperature}: {HeatTemperature} >> {temp} °C");
        HeatTemperature = temp;
    }

    protected override void PrintHeader()
    {
        Console.WriteLine("\n--- Spa Status ---".Pastel(Color.White));
    }

    public override void DisplayStatus()
    {
        // Calls the original Pool logic
        base.DisplayStatus();

        // Adds new param to display
        Console.WriteLine($"{ColoredTemperature}: {HeatTemperature}°C");

        if (HeatTemperature > 40)
        {
            Console.WriteLine("WARNING: Temperature is very high!".PastelBg(Color.Red));
        }
    }
}


