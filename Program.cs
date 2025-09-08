using System;

class Program
{
    static void Main(string[] args)
    {
        // Spørger brugeren hvor mange motorer der bærer pakkerne
        Console.Write("How many motors are carrying the packages? ");
        int motors = Convert.ToInt32(Console.ReadLine()); // konverterer input til et heltal

        // Spørger brugeren hvor mange kilo pakker der forventes
        Console.Write("How many kg of packages do we expect? ");
        double weight = Convert.ToDouble(Console.ReadLine()); // konverterer input til et decimaltal

        // Beregner vægten pr. motor
        double weightPerMotor = weight / motors;

        // Tjekker om vægten pr. motor er mindre end eller lig med 5.6 kg
        if (weightPerMotor <= 5.6)
        {
            Console.WriteLine("Yes! The conveyor belt can carry the packages.");
        }
        else
        {
            Console.WriteLine("No. The conveyor belt cannot carry the packages.");
        }
    }
}