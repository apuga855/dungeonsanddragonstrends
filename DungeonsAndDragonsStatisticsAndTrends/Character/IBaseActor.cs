using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{
    interface IBaseActor
    {
        /// <summary>
        /// Gets the Name of the Actor
        /// </summary>
        string Name { get;}
        /// <summary>
        /// Gets the AC of the Actor
        /// </summary>
        int AC { get; }
        /// <summary>
        /// Gets the Strength of the Actor
        /// </summary>
        int Strength { get; }
        /// <summary>
        /// Gets the Dexterity of the Actor
        /// </summary>
        int Dexterity { get; }
        /// <summary>
        /// Gets the Constitution of the Actor
        /// </summary>
        int Constitution { get; }
        /// <summary>
        /// Gets the Intelligence of the Actor
        /// </summary>
        int Intelligence { get; }
        /// <summary>
        /// Gets the Wisdom of the Actor
        /// </summary>
        int Wisdom { get; }
        /// <summary>
        /// Gets the Charisma of the Actor
        /// </summary>
        int Charisma { get; }
        /// <summary>
        /// Gets the StrengthMod of the Actor
        /// </summary>
        int StrengthMod { get; }
        /// <summary>
        /// Gets the DexterityMod of the Actor
        /// </summary>
        int DexterityMod { get; }
        /// <summary>
        /// Gets the ConstitutionMod of the Actor
        /// </summary>
        int ConstitutionMod { get; }
        /// <summary>
        /// Gets the IntelligenceMod of the Actor
        /// </summary>
        int IntelligenceMod { get; }
        /// <summary>
        /// Gets the WisdomMod of the Actor
        /// </summary>
        int WisdomMod { get; }
        /// <summary>
        /// Gets the CharismaMod of the Actor
        /// </summary>
        int CharismaMod { get; }

    }
}
