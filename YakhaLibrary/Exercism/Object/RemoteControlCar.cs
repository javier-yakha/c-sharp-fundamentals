using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Object
{
    class RemoteControlCar
    {
        private int distance = 0;
        private int battery = 100;
        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }
        public string DistanceDisplay()
        {
            if (battery <= 0) return $"Driven {distance} meters";

            return $"Driven {distance} meters";
        }
        public string BatteryDisplay()
        {
            if (battery <= 0) return "Battery empty";

            return $"Battery at {battery}%";
        }
        public void Drive()
        {
            if (battery <= 0) return;

            battery -= 1;
            distance += 20;
        }
    }

}
