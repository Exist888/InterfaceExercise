using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // - Create 2 Interfaces called IVehicle & ICompany
            // - Create 3 classes called Car , Truck , & SUV
            //In your IVehicle:
                /* - Create 4 members that Car, Truck, & SUV all have in common.
                 * - Example: public int NumberOfWheels { get; set; }
                 */
            //In ICompany: 
                /* - Create 2 members that are specific to each every company
                 * - regardless of vehicle type.
                 * - Example: public string Logo { get; set; }
                 */
            //In each of your Car, Truck, and SUV classes
                /* - Create 2 members that are specific to each class
                 * - Example for Car: public bool HasTrunk { get; set; }
                 * - Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * - Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */
            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car subaruLegacy24 = new Car()
            {
                ManualTrans = true,
                AllWheelDrive = true,
                NumberOfWheels = 4,
                GroundClearanceInches = 5.9,
                NumberOfSeats = 5,
                MilesPerGallonAvg = 26,
                Name = "2024 Subaru Legacy",
                Logo = "blue oval with stars that make up the Pleiades constellation",
            };
            //NOTE TO SELF: code below (Methods) called later in WriteLine
            //subaruLegacy24.DisplayTransmissionBool();
            //subaruLegacy24.Display4WDBoolOrNo();

            SUV subaruOutback24 = new SUV()
            {
                AutomaticRearGateAvailable = true,
                PowerSeatsAvailable = true,
                NumberOfWheels = 4,
                GroundClearanceInches = 8.7,
                NumberOfSeats = 5,
                MilesPerGallonAvg = 25,
                Name = "2024 Subaru Outback",
                Logo = "blue oval with stars that make up the Pleiades constellation",
            };
            //NOTE TO SELF: Code below (Methods) called later in WriteLine.
            //subaruOutback24.DisplayRearGateBool();
            //subaruOutback24.DisplayPowerSeatsBool();

            Truck chevySilverado5Point3Liter24 = new Truck()
            {
                TowingCapacityInPounds = 9500,
                EngineCylinders = 8,
                NumberOfWheels = 4,
                GroundClearanceInches = 11.2,
                NumberOfSeats = 6,
                MilesPerGallonAvg = 17,
                Name = "2024 Chevy Silverado 1500 with 5.3 Liter engine",
                Logo = "golden bowtie with sharp angles",
            };

            Console.WriteLine($"\n" +
                              $"Welcome to our dealership.\n" +
                              $"Here are three of our most popular vehicles:" +
                              $"\n" +
                              $"\n" +
                              $"First, we have a {subaruLegacy24.Name}.\n" +
                              $"It's transmission is {subaruLegacy24.DisplayTransmissionBool()}.\n" +
                              $"It has {subaruLegacy24.Display4WDBoolOrNo()}.\n" +
                              $"It has {subaruLegacy24.NumberOfWheels} wheels,\n" +
                              $"{subaruLegacy24.GroundClearanceInches} inches of ground clearance,\n" +
                              $"{subaruLegacy24.NumberOfSeats} seats,\n" +
                              $"and gets an average of {subaruLegacy24.MilesPerGallonAvg} miles per gallon.\n" +
                              $"Its logo is a {subaruLegacy24.Logo}.\n" +
                              $"\n" +
                              $"Next, we have a {subaruOutback24.Name}.\n" +
                              $"It has an {subaruOutback24.DisplayRearGateBool()}.\n" +
                              $"It has {subaruOutback24.DisplayPowerSeatsBool()}.\n" +
                              $"It has {subaruOutback24.NumberOfWheels} wheels,\n" +
                              $"{subaruOutback24.GroundClearanceInches} inches of ground clearance,\n" +
                              $"{subaruOutback24.NumberOfSeats} seats,\n" +
                              $"and gets an average of {subaruOutback24.MilesPerGallonAvg} miles per gallon.\n" +
                              $"Its logo is a {subaruOutback24.Logo}.\n" +
                              $"\n" +
                              $"Thirdly, we have a {chevySilverado5Point3Liter24.Name}.\n" +
                              $"Its towing capacity is {chevySilverado5Point3Liter24.TowingCapacityInPounds} pounds.\n" +
                              $"It has an {chevySilverado5Point3Liter24.EngineCylinders} cylinder engine.\n" +
                              $"It has {chevySilverado5Point3Liter24.NumberOfWheels} wheels,\n" +
                              $"{chevySilverado5Point3Liter24.GroundClearanceInches} inches of ground clearance,\n" +
                              $"{chevySilverado5Point3Liter24.NumberOfSeats} seats,\n" +
                              $"and gets an average of {chevySilverado5Point3Liter24.MilesPerGallonAvg} miles per gallon.\n" +
                              $"Its logo is a {chevySilverado5Point3Liter24.Logo}.\n");
            
            //_________________________________________________________________________
            //NOTE TO SELF: code below is how to use foreach to Interpolate through multiple classes. More concise,
            //but went with format above in order to account for changes in properties from one class to next. 
            //_________________________________________________________________________-
            
            /*var inventory = new List<IVehicle>() { subaruLegacy24, subaruOutback24, chevySilverado5Point3Liter24 };
            
            Console.WriteLine("Welcome to our dealership.\n" +
                              "Here are some of our most popular vehicles.\n" +
                              " ");

            foreach (var inventoryItem in inventory)
            {
                Console.WriteLine($"We have a {inventoryItem.Name}.\n" +       //NOTE TO SELF - Name belongs to ICompany, not IVehicle
                                  $"It has {inventoryItem.NumberOfWheels} wheels,\n" +
                                  $"{inventoryItem.GroundClearanceInches} inches of ground clearance,\n" +
                                  $"{inventoryItem.NumberOfSeats} seats,\n" +
                                  $"and gets an average of {inventoryItem.MilesPerGallonAvg} miles per gallon.\n" +
                                  $"Its logo is a {inventoryItem.Logo}.\n" +    //Same issue as above.
                                  $"\n");
            }*/
            //_____________________________________________________________

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
