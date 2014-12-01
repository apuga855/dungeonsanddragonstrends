using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities
{
    class LongTermReport
    {
        public double Trials
        {
            get;
            set;
        }

        public double ExpectedDamage
        {
            get;
            set;
        }

        public double ExpectedCrits
        {
            get;
            set;
        }

        public double ExpectedHits
        {
            get;
            set;
        }

        public double Crits
        {
            get;
            set;
        }

        public double Hits
        {
            get;
            set;
        }

        public double Damage
        {
            get;
            set;
        }

        public double AverageDamage
        {
            get;
            set;
        }

        public double AverageCritDamage
        {
            get;
            set;
        }
        public double StandardDeviation
        {
            get;
            set;
        }

        public double Variance
        {
            get;
            set;
        }
        public LongTermReport()
        {
            Damage = 0;
            Trials = 0;
            Crits = 0;
            ExpectedDamage = 0;
            ExpectedCrits = 0;
            ExpectedHits = 0;
            StandardDeviation = 0;
            Variance = 0;
        }

        public void ReportPrint()
        {
            Console.WriteLine("Report*******************");
            Console.WriteLine("In {0} trials this were the results", Trials);
            Console.WriteLine("Damage : {0}", Damage);
            Console.WriteLine("Expected Damage : {0}", ExpectedDamage);
            Console.WriteLine("Average Damage : {0}", AverageDamage);
            Console.WriteLine("Crits : {0}", Crits);
            Console.WriteLine("Expected Crits : {0}", ExpectedCrits);
            Console.WriteLine("Average Crit Damage : {0}", AverageCritDamage);
            Console.WriteLine("Hits : {0}", Hits);
            Console.WriteLine("Average Hits : {0}", ExpectedHits);
            Console.WriteLine("Variance : {0}", Variance);
            Console.WriteLine("Standard Deviation : {0}", StandardDeviation);

        }
    }
}
