using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actor;

namespace Monster
{
    class IBaseMonster : IBaseActor
    {
        /// <summary>
        /// Gets the Name of the Monster
        /// </summary>
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the AC of the Monster
        /// </summary>
        public int AC
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the Strength of the Monster
        /// </summary>
        public int Strength
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the Dexterity of the Monster
        /// </summary>
        public int Dexterity
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the Constitution of the Monster
        /// </summary>
        public int Constitution
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the Intelligence of the Monster
        /// </summary>
        public int Intelligence
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the Wisdom of the Monster
        /// </summary>
        public int Wisdom
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the Charisma of the Monster
        /// </summary>
        public int Charisma
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets the StrengthMod of the Actor
        /// </summary>
        public int StrengthMod { get; private set; }
        /// <summary>
        /// Gets the DexterityMod of the Actor
        /// </summary>
        public int DexterityMod { get; private set; }
        /// <summary>
        /// Gets the ConstitutionMod of the Actor
        /// </summary>
        public int ConstitutionMod { get; private set; }
        /// <summary>
        /// Gets the IntelligenceMod of the Actor
        /// </summary>
        public int IntelligenceMod { get; private set; }
        /// <summary>
        /// Gets the WisdomMod of the Actor
        /// </summary>
        public int WisdomMod { get; private set; }
        /// <summary>
        /// Gets the CharismaMod of the Actor
        /// </summary>
        public int CharismaMod { get; private set; }
    }
}
