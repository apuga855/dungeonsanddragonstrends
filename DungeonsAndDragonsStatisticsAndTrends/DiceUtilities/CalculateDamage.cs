using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;
using Monster;
using Actor;

namespace DiceUtility
{
    class CalculateDamage
    {
        static private Random _excecuteDice = new Random();
        public static int Calculate(IList<Dice> damageDice)
        {
            int result = 0;
            foreach(int die in damageDice)
            {
                result += _excecuteDice.Next(1, die + 1);//The random number generator is non inclusive, have to add 1
            }
            return result;
        }

        public static int AttackAttempt(ActorBackBone attacker)
        {

        }

        public static bool CalculateHit(IBaseActor attacker, IBaseActor target)
        {

        }
    }
}
