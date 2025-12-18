using System;
using System.Runtime.CompilerServices;
using InheritanceClasses;

class Program
{
    static void Main(string[] args)
    {
        // Using the base class
        Pool newPool = new Pool(3.0, 5.5);
        newPool.DisplayStatus();

        // Using the inherited class
        Spa newSpa = new Spa(2.5, 3.0, 38.5);
        newSpa.DisplayStatus();

        // Reduce chloride, increase temperature
        newSpa.SetChloride(1.5);    // Method from base class
        newSpa.SetTemp(41);         // Method from new class
        newSpa.DisplayStatus();     // Overidden method from base class
    }
}
