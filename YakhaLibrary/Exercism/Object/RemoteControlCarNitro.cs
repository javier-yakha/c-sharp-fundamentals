using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Exercism.Object
{
    public class RemoteControlCarNitro
    {
        public int speed;
        private int distanceDriven;

        public int batteryDrain;
        public int battery;
        public RemoteControlCarNitro(int speed, int batteryDrain)
        {
            this.distanceDriven = 0;
            this.speed = speed;

            this.battery = 100;
            this.batteryDrain = batteryDrain;
        }

        public bool BatteryDrained() => battery < batteryDrain;

        public int DistanceDriven() => distanceDriven;


        public void Drive()
        {
            if (BatteryDrained()) return;
            battery -= batteryDrain;
            distanceDriven += speed;
        }
        public static RemoteControlCarNitro Nitro() => new RemoteControlCarNitro(50, 4);
    }

    
}
