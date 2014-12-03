
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    class BaseDwarf : IBaseRace
    {
        public int StrengthMod { get; protected set; }

        public int DexterityMod { get; protected set; }

        public int ConstitutionMod { get; protected set; }

        public int IntelligenceMod { get; protected set; }

        public int WisdomMod { get; protected set; }

        public int CharismaMod { get; protected set; }

        public int Age { get; protected set; }

        public AlignmentDenomination Alignment { get; protected set; }

        public int Size { get; protected set; }

        public int Speed { get; protected set; }

        public IList<ProficientLanguage> Languages { get; protected set; }


    }
}
