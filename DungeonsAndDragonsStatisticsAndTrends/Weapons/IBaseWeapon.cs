using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money;
using DiceUtility;
using Properties;


namespace Weapons
{
    #region Enum
    /// <summary>
    /// Types of damage for weapons
    /// </summary>
    public enum DamageType
    {
        Slashing,
        Bludgeoning,
        Piercing
    }
    /// <summary>
    /// Styles of wielding for weapons
    /// </summary>
    public enum WieldType
    {
        OneHanded,
        DualWield,
        TwoHanded
    }
    /// <summary>
    /// Enum that determines what attribute
    /// </summary>
    public enum AttributeAttack
    {
        Strength,
        Dexterity,
        StrengthOrDexterity,
        Unknown
    }
    #endregion

    /// <summary>
    /// Base class for all wielded weapons
    /// </summary>
    interface IBaseWeapon
    {
        #region Public Properties

        /// <summary>
        /// Gets the Name of the Weapon
        /// </summary>
        string Name{ get;}
        /// <summary>
        /// Gets the Cost of the weapon
        /// </summary>
        IList<KeyValuePair<MoneyType, double>> Cost { get;}
        /// <summary>
        /// Gets Weight of the weapon
        /// </summary>
        double Weight{ get;}
        /// <summary>
        /// Gets Damage of the weapons
        /// </summary>
        IList<Dice> Damage{ get; }
        /// <summary>
        /// Gets the type of wielding for the  Weapon
        /// </summary>
        WieldType Style { get;}
        /// <summary>
        /// Gets the Type of damage
        /// </summary>
        DamageType TypeOfDamage{ get;}
        /// <summary>
        /// Contains Weapon Properties
        /// </summary>
        WeaponProperties Properties { get; }
        /// <summary>
        /// Gets the main attribute for the attack
        /// </summary>
        AttributeAttack AttackStat { get; }

        #endregion
    }
}
