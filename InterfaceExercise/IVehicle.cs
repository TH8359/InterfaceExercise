namespace InterfaceExercise;

public interface IVehicle
{
    public int NumberOfWheels { get; set; }
    
    public string Brand { get; set; }
    
    public double Length { get; set; }
    
    public double Price { get; set; }

    public void DisplayDetails();
}