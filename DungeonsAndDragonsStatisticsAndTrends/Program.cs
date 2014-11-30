using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster;
using MathUtilities;

namespace DungeonsAndDragonsStatisticsAndTrends
{
    class Program
    {
        static void Main(string[] args)
        {
            Goblin attacker = new Goblin();
            Goblin target = new Goblin();
            LongTermTrend trend = new LongTermTrend(100000, attacker, target);
            LongTermReport report = trend.CalculateLongTermTrend();
            report.ReportPrint();
            Console.ReadLine();

            
        }
    }
}
