using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Inheritance
{

    public interface IRemoteControlCar
    {
        public int DistanceTravelled { get; set; }
        public void Drive();
    }

    public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
    {
        public int DistanceTravelled { get; set; }
        public int NumberOfVictories { get; set; }
        public void Drive()
        {
            DistanceTravelled += 10;
        }
        public int CompareTo(ProductionRemoteControlCar? other) => NumberOfVictories - other.NumberOfVictories;
    }
    public class ExperimentalRemoteControlCar : IRemoteControlCar
    {
        public int DistanceTravelled { get; set; }
        public void Drive()
        {
            DistanceTravelled += 20;
        }
    }
    public static class TestTrack
    {
        public static void Race(IRemoteControlCar car)
        {
            car.Drive();
        }
        public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
            ProductionRemoteControlCar prc2)
        {
            List<ProductionRemoteControlCar> ranks = new() { prc1, prc2 };
            ranks.Sort();
            return ranks;
        }
    }
}
