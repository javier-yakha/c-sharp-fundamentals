using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Loops
{
    class BirdCount
    {
        private int[] birdsPerDay;
        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }
        public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];
        public int Today() => birdsPerDay[birdsPerDay.Length - 1];
        public void IncrementTodaysCount()
        {
            birdsPerDay[^1] += 1;
        }
        public bool HasDayWithoutBirds()
        {
            foreach (int bird in birdsPerDay)
            {
                if (bird == 0) return true;
            }
            return false;
        }
        public int CountForFirstDays(int numberOfDays)
        {
            int count = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                count += birdsPerDay[i];
            }
            return count;
        }
        public int BusyDays()
        {
            int count = 0;
            foreach (int birds in birdsPerDay)
            {
                if (birds >= 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
