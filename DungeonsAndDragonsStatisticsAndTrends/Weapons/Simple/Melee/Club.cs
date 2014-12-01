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
    class Club : IBaseWeapon
    {
        #region Constructors
        /// <summary>
        /// Constructs a club with all its relevant properties
        /// </summary>
        public Club()
        {
            Name = string.Format("Club");
            Cost = new List<KeyValuePair<MoneyType, double>>();
            Cost.Add(new KeyValuePair<MoneyType, double>(MoneyType.SilverPieces, 1));
            Weight = 2.0;
            Damage = new List<Dice>();
            Damage.Add(Dice.D4);
            TypeOfDamage = DamageType.Bludgeoning;
            Properties = new WeaponProperties();
            Properties.LightWeight = true;
            AttackStat = AttributeAttack.Strength;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets or Sets the weapon Name
        /// </summary>
        public string Name
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets the Cost of the weapon
        /// </summary>
        public IList<KeyValuePair<MoneyType, double>> Cost
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets the Weight of the weapon
        /// </summary>
        public double Weight
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets List of Dice representing Damage
        /// </summary>
        public IList<Dice> Damage
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets the Style of Wielding
        /// </summary>
        public WieldType Style
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets the TypeOfDamage
        /// </summary>
        public DamageType TypeOfDamage
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets the WeaponProperties
        /// </summary>
        public WeaponProperties Properties
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets the AttackStat
        /// </summary>
        public AttributeAttack AttackStat
        {
            get;
            private set;
        }
        #endregion
    }
}
