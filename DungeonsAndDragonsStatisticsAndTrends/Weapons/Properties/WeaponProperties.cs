using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{  
    class WeaponProperties
    {
        public bool Light
        {
            get; set;
        }

        public bool Finesse
        {
            get; set;
        }

        public bool Thrown
        {
            get; set;
        }

        public bool Versatile
        {
            get; set;
        }

        public WeaponProperties()
        {
            Light = false;
            Finesse = false;
            Thrown = false;
            Versatile = false;
        }
    }
}
