using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Races;

namespace DungeonsAndDragonsStatisticsAndTrends.Actors.ActorUtility.ActorRandomizer.PlayerRandomizer
{
    interface IBaseRandomizer
    {
        int MaxAge { get; }
        int MinAge { get; }
        int MaxSize { get; }
        int MinSize { get; }
        IList<AlignmentDenomination> PossibleAlignments { get; }

    }
}
