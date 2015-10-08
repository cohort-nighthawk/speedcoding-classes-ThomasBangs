using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCodingClasses
{
    public class Boat : Vehicle
    {
        public int NumberOfWheels { get { return 0; } }
        private string hornSound = "HOOOOOONKK";

        public string Horn()
        {
            return hornSound;
        }
    }
}

