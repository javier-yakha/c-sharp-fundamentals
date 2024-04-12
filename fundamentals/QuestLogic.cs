using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals
{
    static class QuestLogic
    {
        public static bool CanFastAttack(bool knightIsAwake) => !knightIsAwake;

        public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
        {
            return (knightIsAwake || archerIsAwake || prisonerIsAwake);
        }
        public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => !archerIsAwake && prisonerIsAwake;

        public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
        {
            if (archerIsAwake) return false;
            if (petDogIsPresent) return true;
            return (prisonerIsAwake && !knightIsAwake);
        }
    }

}
