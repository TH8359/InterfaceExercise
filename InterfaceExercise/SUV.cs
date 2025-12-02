using System;

namespace InterfaceExercise;

public class SUV : IVehicle, ICompany
{
    public string SUVFeatureOne { get; set; }
    public string SUVFeatureTwo { get; set; }
    
    public int NumberOfWheels { get; set; }
    public string Brand { get; set; }
    public double Length { get; set; }
    public double Price { get; set; }
    
    public string Logo { get; set; }
    public string Ratings { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"SUV Feature #1: {SUVFeatureOne}");
        Console.WriteLine($"SUV Feature #2: {SUVFeatureTwo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Length: {Length} Feet");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Ratings: {Ratings}");
    }
}