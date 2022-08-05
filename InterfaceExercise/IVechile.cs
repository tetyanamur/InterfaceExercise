using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVechile
    {

        public string Make { get; set; }
        public string Model { get; set; }   
        public double EnSize { get; set; }
        public int NumofSeats { get; set; }
        public bool ChangeWindsh { get; set; }

        public void Drive();
        public void Park();
        public void Reverse();
        public void ChangedWindsh(bool isChanged);
    }
}
