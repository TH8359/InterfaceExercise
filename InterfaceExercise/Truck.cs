using System;

namespace InterfaceExercise;

public class Truck : IVehicle, ICompany
{
    public string TruckFeatureOne { get; set; }
    public string TruckFeatureTwo { get; set; }
    
    public int NumberOfWheels { get; set; }
    public string Brand { get; set; }
    public double Length { get; set; }
    public double Price { get; set; }
    
    public string Logo { get; set; }
    public string Ratings { get; set; }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Truck Feature #1: {TruckFeatureOne}");
        Console.WriteLine($"Truck Feature #2: {TruckFeatureTwo}");
        Console.WriteLine($"Number of Wheels: {NumberOfWheels}");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Length: {Length} Feet");
        Console.WriteLine($"Price: ${Price}");
        Console.WriteLine($"Logo: {Logo}");
        Console.WriteLine($"Ratings: {Ratings}");
    }
}