using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actor
{

    class ActorBackBone : IBaseActor 
    {
        /// <summary>
        /// Calculate modifiers for each major attribute
        /// </summary>
        public void CalculateMods( )
        {
            StrengthMod = ConvertToMod(Strength);
            DexterityMod = ConvertToMod(Dexterity);
            ConstitutionMod = ConvertToMod(Constitution);
            IntelligenceMod= ConvertToMod(Intelligence);
            WisdomMod= ConvertToMod(Wisdom);
            CharismaMod = ConvertToMod(Charisma);
        }
        /// <summary>
        /// Converts the major attribute to a modifier
        /// </summary>
        /// <param name="baseState"></param>
        /// <returns>The mod based on the major attribute</returns>
        private int ConvertToMod(int baseState)
        {
            int mod = 0;
            switch(baseState)
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


        public string Name{ get; protected set;}

        public int AC { get; protected set; }

        public int Strength { get; protected set; }

        public int Dexterity { get; protected set; }

        public int Constitution { get; protected set; }

        public int Intelligence { get; protected set; }

        public int Wisdom { get; protected set; }

        public int Charisma { get; protected set; }

        public int StrengthMod { get; protected set; }

        public int DexterityMod { get; protected set; }

        public int ConstitutionMod { get; protected set; }

        public int IntelligenceMod { get; protected set; }

        public int WisdomMod { get; protected set; }

        public int CharismaMod { get; protected set; }

        public int HitPoints { get; protected set; }
    }


}
