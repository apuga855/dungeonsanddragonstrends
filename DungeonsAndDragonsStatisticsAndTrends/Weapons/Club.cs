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


        public string Name
        {
            get;
            private set;
        }

        public IList<KeyValuePair<MoneyType, double>> Cost
        {
            get;
            private set;
        }

        public double Weight
        {
            get;
            private set;
        }

        public IList<Dice> Damage
        {
            get;
            private set;
        }

        public WieldType Style
        {
            get;
            private set;
        }

        public DamageType TypeOfDamage
        {
            get;
            private set;
        }

        public WeaponProperties Properties
        {
            get;
            private set;
        }

        public AttributeAttack AttackStat
        {
            get;
            private set;
        }
    }
}
