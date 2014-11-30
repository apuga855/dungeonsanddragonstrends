using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Actor
{
    /// <summary>
    /// Enum with all possible hero levels
    /// </summary>
    public enum ActorLevel
    {
        Level_LessThanOne,
        Level_1,
        Level_2,
        Level_3,
        Level_4,
        Level_5,
        Level_6,
        Level_7,
        Level_8,
        Level_9,
        Level_10,
        Level_11,
        Level_12,
        Level_13,
        Level_14,
        Level_15,
        Level_16,
        Level_17,
        Level_18,
        Level_19,
        Level_20,
        Level_21,
        Level_22,
        Level_23,
        Level_24,
        Level_25,
        Level_26,
        Level_27,
        Level_28,
        Level_29,
        Level_30,
        Unknown
    }

    class ActorBackBone : IBaseActor
    {
        #region Constructors

        #endregion

        #region Private Methods
        /// <summary>
        /// Calculate modifiers for each major attribute
        /// </summary>
        protected void CalculateMods()
        {
            StrengthMod = ConvertToMod(Strength);
            DexterityMod = ConvertToMod(Dexterity);
            ConstitutionMod = ConvertToMod(Constitution);
            IntelligenceMod = ConvertToMod(Intelligence);
            WisdomMod = ConvertToMod(Wisdom);
            CharismaMod = ConvertToMod(Charisma);
        }
        /// <summary>
        /// Converts the major attribute to a modifier
        /// </summary>
        /// <param name="baseStat"></param>
        /// <returns>The mod based on the major attribute</returns>
        private int ConvertToMod(int baseStat)
        {
            int mod = 0;
            switch(baseStat)
            {
                case 1:
                    mod = -5;
                    break;
                case 2:
                case 3:
                    mod = -4;
                    break;
                case 4:
                case 5:
                    mod = -3;
                    break;
                case 6:
                case 7:
                    mod = 2;
                    break;
                case 8:
                case 9:
                    mod = -1;
                    break;
                case 10:
                case 11:
                    mod = 0;
                    break;
                case 12:
                case 13:
                    mod = 1;
                    break;
                case 14:
                case 15:
                    mod = 2;
                    break;
                case 16:
                case 17:
                    mod = 3;
                    break;
                case 18:
                case 19:
                    mod = 4;
                    break;
                case 20:
                case 21:
                    mod = 5;
                    break;
                case 22:
                case 23:
                    mod = 6;
                    break;
                case 24:
                case 25:
                    mod = 7;
                    break;
                case 26:
                case 27:
                    mod = 8;
                    break;
                case 28:
                case 29:
                    mod = 9;
                    break;
                case 30:
                    mod = 10;
                    break;
            }
            return mod;
        }

        /// <summary>
        /// Calculates proficiency based on ActorLevel
        /// </summary>
        /// <param name="level"></param>
        protected void CalculateProficiency()
        {
            switch (Level)
            {
                case ActorLevel.Level_LessThanOne:
                case ActorLevel.Level_1:
                case ActorLevel.Level_2:
                case ActorLevel.Level_3:
                case ActorLevel.Level_4:
                    Proficiency = 2;
                    break;
                case ActorLevel.Level_5:
                case ActorLevel.Level_6:
                case ActorLevel.Level_7:
                case ActorLevel.Level_8:
                    Proficiency = 3;
                    break;
                case ActorLevel.Level_9:
                case ActorLevel.Level_10:
                case ActorLevel.Level_11:
                case ActorLevel.Level_12:
                    Proficiency = 4;
                    break;
                case ActorLevel.Level_13:
                case ActorLevel.Level_14:
                case ActorLevel.Level_15:
                case ActorLevel.Level_16:
                    Proficiency = 5;
                    break;
                case ActorLevel.Level_17:
                case ActorLevel.Level_18:
                case ActorLevel.Level_19:
                case ActorLevel.Level_20:
                    Proficiency = 6;
                    break;
                case ActorLevel.Level_21:
                case ActorLevel.Level_22:
                case ActorLevel.Level_23:
                case ActorLevel.Level_24:
                    Proficiency = 7;
                    break;
                case ActorLevel.Level_25:
                case ActorLevel.Level_26:
                case ActorLevel.Level_27:
                case ActorLevel.Level_28:
                    Proficiency = 8;
                    break;
                case ActorLevel.Level_29:
                case ActorLevel.Level_30:
                    Proficiency = 9;
                    break;
                case ActorLevel.Unknown:
                    Proficiency = 0;
                    break;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        protected bool Attack(ActorBackBone target)
        {
            int attackMod = GetAttackMod();
            Random roll = new Random();
            int attackAttempt = roll.Next(1, 21) + attackMod + Proficiency;
            if(attackAttempt >= target.AC)
            {
                return true;
            }
            return false;
        }

        protected int GetAttackMod()
        {
            switch(Weapon.AttackStat)
            {
                case AttributeAttack.Dexterity:
                    return DexterityMod;
                case AttributeAttack.Strength:
                    return StrengthMod;
                case AttributeAttack.StrengthOrDexterity:
                    return (StrengthMod > DexterityMod) ? StrengthMod : DexterityMod;
                case AttributeAttack.Unknown:
                    return 0;
            }
            return 0;
        }
        #endregion

        #region Public Methods
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets the Name
        /// </summary>
        public string Name{ get; protected set;}
        /// <summary>
        /// Gets or Sets the AC
        /// </summary>
        public int AC { get; protected set; }
        /// <summary>
        /// Gets or Sets the Strength
        /// </summary>
        public int Strength { get; protected set; }
        /// <summary>
        /// Gets or Sets Dexterity
        /// </summary>
        public int Dexterity { get; protected set; }
        /// <summary>
        /// Gets or Sets Constitution
        /// </summary>
        public int Constitution { get; protected set; }
        /// <summary>
        /// Gets or Sets Intelligence
        /// </summary>
        public int Intelligence { get; protected set; }
        /// <summary>
        /// Gets or Sets Wisdom
        /// </summary>
        public int Wisdom { get; protected set; }
        /// <summary>
        /// Gets or Sets Charisma
        /// </summary>
        public int Charisma { get; protected set; }
        /// <summary>
        /// Gets or Sets StrengthMod
        /// </summary>
        public int StrengthMod { get; protected set; }
        /// <summary>
        /// Gets or Sets DexterityMod
        /// </summary>
        public int DexterityMod { get; protected set; }
        /// <summary>
        /// Gets or Sets Constitution Mod
        /// </summary>
        public int ConstitutionMod { get; protected set; }
        /// <summary>
        /// Gets or Sets IntelligenceMod
        /// </summary>
        public int IntelligenceMod { get; protected set; }
        /// <summary>
        /// Gets or Sets WisdomMod
        /// </summary>
        public int WisdomMod { get; protected set; }
        /// <summary>
        /// Gets or Sets CharismaMod
        /// </summary>
        public int CharismaMod { get; protected set; }
        /// <summary>
        /// Gets or Sets the Characters Proficiency 
        /// </summary>
        public int Proficiency { get; protected set; }
        /// <summary>
        /// Gets or Sets HitPoints
        /// </summary>
        public int HitPoints { get; protected set; }
        /// <summary>
        /// Gets or Sets the PassivePerceptions
        /// </summary>
        public int PassivePerception { get; protected set; }
        /// <summary>
        /// Gets or Sets the Character Level
        /// </summary>
        public ActorLevel Level { get; protected set; }
        /// <summary>
        /// Gets the Weapon for the Actor
        /// </summary>
        public IBaseWeapon Weapon { get; protected set; }
        #endregion
    }
}
