using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany ok

            //Create 3 classes called Car , Truck , & SUV ok

            //In your IVehicle
            var car = new Car();
            var truck = new Truck();
            var suv = new SUV();
            var vechicle = new List<IVechile> {car, truck, suv};
            foreach(var vech in vechicle)
            {
                vech.Drive();
                vech.ChangedWindsh(true);
                vech.Reverse();
                vech.Park();

            }
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now.. ok
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }ok
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
