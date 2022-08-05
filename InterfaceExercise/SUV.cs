using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVechile, ICompany
    {
        public SUV()
        {

        }

        public string Make { get; set; } = "SUV";
        public string Model { get; set; } = "SUV1";
        public double EnSize { get; set; } = 4.3;
        public int NumofSeats { get; set; } = 4;
        public string CompanyName { get; set; } = "SUV2";
        public string Motto { get; set; } = "SUV is great";
        public bool HasChangedWindsh { get; set; }
        public bool ChangeWindsh { get; set; }

        public void ChangedWindsh(bool isChanged)
        {
            HasChangedWindsh = isChanged;
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} moves forward");
        }

        public void Park()
        {
            Console.WriteLine($"{GetType().Name} not moves forward");
        }

        public void Reverse()
        {
            if (HasChangedWindsh == true)
            {
                Console.WriteLine($"{GetType().Name} now moves forward");
                HasChangedWindsh = false;
            }
            else
            {
                Console.WriteLine("Can't reverse");
            }
        }

    }
}