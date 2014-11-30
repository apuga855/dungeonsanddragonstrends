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
        public double Trials
        {
            get;
            private set;
        }

        public ActorBackBone Target
        {
            get;
            set;
        }
        
        public ActorBackBone Attacker
        {
            get;
            set;
        }

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
                Attacks.Add(current);
            }

            report.Trials = Trials;
            report.AverageHits = report.Hits / report.Trials;
            report.AverageCrits = report.Crits / report.Trials;
            report.AverageDamage = report.Damage / report.Trials;

            double currentVariance = 0;
            foreach(AttackResults attack in Attacks)
            {
                currentVariance = attack.TotalDamage - report.AverageDamage;
                currentVariance *= currentVariance;
                report.Variance += currentVariance;
            }
            report.Variance = report.Variance / report.Trials;
            report.StandardDeviation = Math.Sqrt(report.Variance);

            return report;
        }
    }
}
