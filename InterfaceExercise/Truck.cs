using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVechile, ICompany
    {
        public Truck()
        {

        }

        public string Make { get; set; } = "Ford";
        public string Model { get; set; } = "F180";
        public double EnSize { get; set; } = 7;
        public int NumofSeats { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Ford is awesome";
        public bool HasChangedWindsh { get; set; }
        public bool ChangeWindsh { get; set; }
        public bool HasWheels  { get; set; } = true;

        public void ChangedWindsh(bool isChanged)
        {
            HasChangedWindsh = isChanged;
        }

        public void Drive()
        {
            if (HasChangedWindsh == true)
            {
                Console.WriteLine($"This truck {GetType().Name} driving back");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving back");
            }
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} not driving back");
        }

        public void Reverse()
        {
            if (HasChangedWindsh == true)
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


