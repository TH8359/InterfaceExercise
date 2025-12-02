using System;

namespace InterfaceExercise;

public class Car : IVehicle, ICompany
{
    public string CarFeatureOne { get; set; }
    public string CarFeatureTwo { get; set; }
    
    public int NumberOfWheels { get; set; }
    public string Brand { get; set; }
    public double Length { get; set; }
    public double Price { get; set; }
    
    public string Logo { get; set; }
    public string Ratings { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Car Feature #1: {CarFeatureOne}");
        Console.WriteLine($"Car Feature #2: {CarFeatureTwo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Length: {Length} Feet");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Ratings: {Ratings}");
    }
}