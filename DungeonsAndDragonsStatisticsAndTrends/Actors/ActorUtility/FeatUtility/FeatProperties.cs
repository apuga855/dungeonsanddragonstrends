using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeatUtility
{
    class FeatProperties : IFeatProperties
    {
        /// <summary>
        /// Gets or Sets the ID
        /// </summary>
        public int ID { get; private set; }
        /// <summary>
        /// Gets or Sets the StrengthMod
        /// </summary>
        public int StrengthMod { get; private set; }
        /// <summary>
        /// Gets or Sets the DexterityMod
        /// </summary>
        public int DexterityMod { get; private set; }
        /// <summary>
        /// Gets or Sets the ConstitutionMod
        /// </summary>
        public int ConstitutionMod { get; private set; }
        /// <summary>
        /// Gets or Sets the IntelligenceMod
        /// </summary>
        public int IntelligenceMod { get; private set; }
        /// <summary>
        /// Gets or Sets the WisdomMod
        /// </summary>
        public int WisdomMod { get; private set; }
        /// <summary>
        /// Gets or Sets the CharismaMod
        /// </summary>
        public int CharismaMod { get; private set; }
        /// <summary>
        /// Gets or Sets the Description
        /// </summary>
        public string Description { get; private set; }

    }
}
