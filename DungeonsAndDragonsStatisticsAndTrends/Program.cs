using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster;
using MathUtilities;
using Weapons;

namespace DungeonsAndDragonsStatisticsAndTrends
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseWeapon scimitar = new Scimitar();
            Goblin attacker = new Goblin();
            Goblin target = new Goblin();
            attacker.EquipWeapon(scimitar);
            LongTermTrend trend = new LongTermTrend(1000000, attacker, target);
            LongTermReport report = trend.CalculateLongTermTrend();
            report.ReportPrint();
            Console.ReadLine();

            
        }
    }
}
