using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actor;

namespace Monster
{
    /// <summary>
    /// Goblin Monster
    /// </summary>
    class Goblin : MonsterBackBone
    {
        #region Constructor
        /// <summary>
        /// Default constructor initializes a goblin with the maximum possible health
        /// </summary>
        Goblin()
        {
            HitPoints = 7;
            CommonProperties();
        }
        /// <summary>
        /// Constructor that randomizes a goblin's health up to its maximum health
        /// </summary>
        /// <param name="Lowerbound"></param>
        Goblin(int Lowerbound)
        {
            Random rnd = new Random();
            HitPoints = rnd.Next(Lowerbound, 8);
            CommonProperties();
        }
        #endregion

        #region Private Fields
        /// <summary>
        /// Sets the common properties that are always truw in a goblin
        /// </summary>
        private void CommonProperties()
        {
            Name = string.Format("Goblin");
            AC = 15;
            Strength = 8;
            Dexterity = 14;
            Constitution = 10;
            Intelligence = 10;
            Wisdom = 8;
            Charisma = 8;
            Level = ActorLevel.Level_LessThanOne;
            PassivePerception = 9;
            CalculateMods();
            CalculateProficiency();
        }
        #endregion
    }
}
