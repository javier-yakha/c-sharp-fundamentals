using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Objects
{
    public interface ITelemetry
    {
        public bool SelfTest();
        public void Calibrate();
        public void ShowSponsor(string sponsorName);
        public void SetSpeed(decimal amount, string unitsString);
    }
    public class RemoteControlCarX
    {
        public RemoteControlCarX() => Telemetry = new CarTelemetry(this);
        private class CarTelemetry(RemoteControlCarX car) : ITelemetry
        {
            RemoteControlCarX _car = car;
            public bool SelfTest() => true;
            public void Calibrate() { }
            public void ShowSponsor(string sponsorName) => _car.SetSponsor(sponsorName);
            public void SetSpeed(decimal amount, string unitsString)
            {
                SpeedUnits speedUnits = unitsString == "cps" ? SpeedUnits.CentimetersPerSecond : SpeedUnits.MetersPerSecond;
                _car.SetSpeed(new Speed(amount, speedUnits));
            }
        }
        public ITelemetry Telemetry { get; private set; } 
        public string? CurrentSponsor { get; private set; }
        private Speed currentSpeed;
        public string GetSpeed() => currentSpeed.ToString();
        private void SetSponsor(string sponsorName) => CurrentSponsor = sponsorName;
        private void SetSpeed(Speed speed) => currentSpeed = speed;
        private struct Speed(decimal amount, SpeedUnits speedUnits)
        {
            public decimal Amount { get; } = amount;
            public SpeedUnits SpeedUnits { get; } = speedUnits;
            public override string ToString() => Amount + " " + (SpeedUnits == SpeedUnits.CentimetersPerSecond ? "centimeters per second" : "meters per second");
        }
        private enum SpeedUnits
        {
            MetersPerSecond,
            CentimetersPerSecond
        }
    }
}
