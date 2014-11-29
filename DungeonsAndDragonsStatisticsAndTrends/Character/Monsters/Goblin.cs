using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    class Goblin : IBaseMonster
    {

        new public string Name
        {
            get;
            private set;
        }

        new public int AC
        {
            get;
            private set;
        }

        public Goblin()
        {
            Name = String.Format("Goblin");
            AC = 15;

        }
    }
}
