using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Exercism.Object
{
    public class RaceTrack
    {
        private int distance;
        public RaceTrack(int distance)
        {
            this.distance = distance;
        }
        public bool TryFinishTrack(RemoteControlCarNitro car)
        {
            int batteryRemaining = car.battery / car.batteryDrain;
            int possibleDistance = batteryRemaining * car.speed;
            return possibleDistance >= distance;
        }
    }
}
