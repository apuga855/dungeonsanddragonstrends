using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatUtility
{
    interface IFeatProperties
    {
        /// <summary>
        /// Gets the ID of the feat
        /// </summary>
        public int ID { get; }
        /// <summary>
        /// Gets the StrengthMod
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
        /// <summary>
        /// Gets the Description
        /// </summary>
        public string Description { get; }

    }
}
