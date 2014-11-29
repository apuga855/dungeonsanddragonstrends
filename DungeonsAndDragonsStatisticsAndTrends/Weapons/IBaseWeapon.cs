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
        /// The Weight of the weapon
        /// </summary>
        double Weight{ get;}
        /// <summary>
        /// The Damage of the weapons
        /// </summary>
        IList<Dice> Damage{ get; }
        /// <summary>
        /// Type of wielding for Weapon
        /// </summary>
        WieldType Style { get;}
        /// <summary>
        /// Type of weapon damage
        /// </summary>
        DamageType TypeOfDamage{ get;}
        /// <summary>
        /// Contains Weapon Properties
        /// </summary>
        WeaponProperties Properties { get; }

        #endregion
    }
}
