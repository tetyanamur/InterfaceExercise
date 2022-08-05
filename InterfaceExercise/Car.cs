using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVechile, ICompany
    {
        public Car()
        {

        }

        public string Make { get; set; } = "Toyota";
        public string Model { get; set; } = "Canri";
        public double EnSize { get; set; } = 4.3;
        public int NumofSeats { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "We can do it";
        public bool HasChangedWindsh { get ; set ;} = true;
        public bool ChangeWindsh { get ; set ; }

        public void ChangedWindsh(bool isChanged)
        {
            HasChangedWindsh = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} not driving back");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} not driving back");
        }

        public void Reverse()
        { if (HasChangedWindsh == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing");
                HasChangedWindsh = false;
            }
        else
            {
                Console.WriteLine("Can't reverse");
            }
        }

    }
}
