using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle &  [COMPLETE]

            //Create 3 classes called Car , Truck , & SUV [COMPLETE]

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common. [COMPLETE]
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company 
                 * regardless of vehicle type. [COMPLETE]
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class [COMPLETE]
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. [COMPLETE]
                 */

            //Now, create objects of your 3 classes and give their members values. [COMPLETE]
            
            Car carObject = new Car() {CarFeatureOne = "MORE COMPACT", CarFeatureTwo = "FAST", NumberOfWheels = 4, Brand = "DODGE", Length = 14.7, Price = 48841.00, Logo = "PICTURE OF A GOAT", Ratings = "GOOD"};
            Truck truckObject = new Truck() { TruckFeatureOne = "BIG", TruckFeatureTwo = "PLENTY OF SPACE", NumberOfWheels = 18, Brand = "KENWORTH", Length = 80, Price = 250000.00, Logo = "RESEMBLES A LOLLIPOP", Ratings = "GOOD" };
            SUV suvObject = new SUV() { SUVFeatureOne = "OFF-ROAD CAPABILITIES", SUVFeatureTwo = "POWERFUL ENGINE", NumberOfWheels = 4, Brand = "TOYOTA", Length = 14.63, Price = 25485.00, Logo = "THREE CIRCLES CONNECTED TO EACH OTHER", Ratings = "GOOD" };

            //Creatively display and organize their values [COMPLETE]
            
            carObject.DisplayDetails();
            Console.WriteLine();
            truckObject.DisplayDetails();
            Console.WriteLine();
            suvObject.DisplayDetails();

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
