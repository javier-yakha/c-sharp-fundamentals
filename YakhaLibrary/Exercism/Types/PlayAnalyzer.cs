using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YakhaLibrary.Exercism.Types.OffFieldActivitiesAndCharacters;

namespace YakhaLibrary.Exercism.Types
{
    public static class PlayAnalyzer
    {
        public static string AnalyzeOnField(int shirtNum)
        {
            return shirtNum switch
            {
                1 => "goalie",
                2 => "left back",
                3 or 4 => "center back",
                5 => "right back",
                6 or 7 or 8 => "midfielder",
                9 => "left wing",
                10 => "striker",
                11 => "right wing",
                _ => throw new ArgumentOutOfRangeException(),
            };
        }
        public static string AnalyzeOffField(object report)
        {
            if (report is int) return $"There are {report} supporters at the match.";
            if (report is string) return $"{report}";
            if (report is Injury injury)
            {
                return $"Oh no! {injury.GetDescription()} Medics are on the field.";
            }
            if (report is Incident incident)
            {
                return $"{incident.GetDescription()}";
            }
            if (report is Manager manager)
            {
                if (manager.Club == null) return manager.Name;
                return $"{manager.Name} ({manager.Club})";
            }
            throw new ArgumentException();
        }
    }
}
