using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    class Goblin : IBaseMonster
    {
        public string Name{ get; private set;}

        public int AC { get; private set; }

        public int Strength { get; private set; }

        public int Dexterity { get; private set; }

        public int Constitution { get; private set; }

        public int Intelligence{ get; private set;}

        public int Wisdom{ get; private set;}

        public int Charisma{ get; private set;}

        public int StrengthMod{ get; private set;}

        public int DexterityMod{ get; private set;}

        public int ConstitutionMod { get; private set; }

        public int IntelligenceMod { get; private set; }

        public int WisdomMod { get; private set; }

        public int CharismaMod { get; private set; }
    }
}
