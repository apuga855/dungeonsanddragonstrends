using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{
    public class AttackResults
    {
        public int TotalDamage
        {
            get;
            set;
        }

        public int? OverHit
        {
            get;
            set;
        }

        public bool Hit
        {
            get;
            set;
        }

        public bool Crit
        {
            get;
            set;
        }


        public AttackResults()
        {
            TotalDamage = 0;
            OverHit = null;
            Hit = false;
            Crit = false;
        }
    }
}
