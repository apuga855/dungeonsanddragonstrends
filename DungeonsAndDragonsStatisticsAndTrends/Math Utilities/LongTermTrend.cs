using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Actor;
namespace MathUtilities
{
    class LongTermTrend
    {
        /// <summary>
        /// Gets or Sets the ammount of Trials the trends will go for
        /// </summary>
        public double Trials
        {
            get;
            private set;
        }
        /// <summary>
        /// Gets or Sets Target who is being attacked
        /// </summary>
        public ActorBackBone Target
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or Sets the Attacker who will be attacking
        /// </summary>
        public ActorBackBone Attacker
        {
            get;
            set;
        }
        /// <summary>
        /// Gets or Sets the list of Attacks that happened in the past
        /// </summary>
        private IList<AttackResults> Attacks
        {
            get;
            set;
        }

        public LongTermTrend(double trials, ActorBackBone attacker, ActorBackBone target)
        {
            Trials = trials;
            Target = target;
            Attacker = attacker;
            Attacks = new List<AttackResults>();
        }

        public LongTermReport CalculateLongTermTrend()
        {
            LongTermReport report = new LongTermReport();
            AttackResults current = null;

            for(int trial = 0; trial < Trials; trial++)
            {
                current = Attacker.Attack(Target);
                report.Damage += current.TotalDamage;
                report.Crits += (current.Crit) ? 1 : 0;
                report.Hits += (current.Hit) ? 1 : 0;
                if(current.Hit)
                {
                    report.AverageDamage += current.TotalDamage;
                }
                if(current.Crit)
                {
                    report.AverageCritDamage += current.TotalDamage;
                }
                Attacks.Add(current);
            }

            report.Trials = Trials;
            report.ExpectedHits = report.Hits / report.Trials;
            report.ExpectedCrits = report.Crits / report.Trials;
            report.ExpectedDamage = report.Damage / report.Trials;
            report.AverageDamage = report.AverageDamage / report.Hits;
            report.AverageCritDamage = report.AverageCritDamage / report.Crits;

            double currentVariance = 0;
            foreach(AttackResults attack in Attacks)
            {
                currentVariance = attack.TotalDamage - report.ExpectedDamage;
                currentVariance *= currentVariance;
                report.Variance += currentVariance;
            }
            report.Variance = report.Variance / report.Trials;
            report.StandardDeviation = Math.Sqrt(report.Variance);

            return report;
        }
    }
}
