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

        public double AverageDamage
        {
            get;
            set;
        }

        public double AverageCrits
        {
            get;
            set;
        }

        public double AverageHits
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
            AverageDamage = 0;
            AverageCrits = 0;
            AverageHits = 0;
            StandardDeviation = 0;
            Variance = 0;
        }

        public void ReportPrint()
        {
            Console.WriteLine("Report*******************");
            Console.WriteLine("In %d trials this were the results", Trials);
            Console.WriteLine("Damage : %d", Damage);
            Console.WriteLine("Average Damage : %d", AverageDamage);
            Console.WriteLine("Crits : %d", Crits);
            Console.WriteLine("Average Crits : %d", AverageCrits);
            Console.WriteLine("Hits : %d", Hits);
            Console.WriteLine("Average Hits : %d", AverageHits);
            Console.WriteLine("Variance : %d", Variance);
            Console.WriteLine("Standard Deviation : %d", StandardDeviation);

        }
    }
}
