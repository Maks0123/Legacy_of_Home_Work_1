using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage_plus_Intefases
{

    interface ICar
    {
        int HorsePower { get; set; }
        int Speed { get; set; }
        string Color { get; set; }
    }

    class Car : ICar
    {
    Car() { }

        public int HorsePower {
            get; set;
        }
        public int Speed {
            get; set;
        }
        public string Color {
            get; set;
        }
    }
}



