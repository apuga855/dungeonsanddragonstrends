using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Races
{
    /// <summary>
    /// Enumeration with all possible alignments
    /// </summary>
    public enum AlignmentDenomination
    {
        Lawful_Good,
        Lawful_Neutral,
        Lawful_Evil,
        Neutral_Good,
        True_Neutral,
        Neutral_Evil,
        Chaotic_Good,
        Chaotic_Neutral,
        Chaotic_Evil
    }

    public enum ProficientLanguage
    {

    }

    public enum DefinedRaces
    {
        Elf,
        Dwarf,
        Halfling,
        Human,
        Dragonborn,
        Gnome,
        Half_Elf,
        Half_Orc,
        Tiefling,
    }

    public enum DefinedExoticRaces
    {
        Gnome,
        Half_Elf,
        Half_Orc,
        Dragonborn,
        Tiefling,
        Dark_Elf
    }

    public enum DefinedSubRaces
    {
        High_Elf,
        Wood_Elf,
        Dark_Elf,
        Hill_Dwarf,
        Mountain_Dwarf,
        Halfling_Stout,
        Halfling_Lightfoot,
        Default_Fault,
        Variant_Human,
        Forest_Gnome,
        Rock_Gnome
    }

    interface IBaseRace
    {        
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
        int Age { get; }
        AlignmentDenomination Alignment { get;}
        int Size { get; }
        int Speed { get; }
        IList<ProficientLanguage> Languages { get; }
 

    }
}
