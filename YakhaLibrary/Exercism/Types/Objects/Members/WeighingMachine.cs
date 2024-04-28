using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Objects.Members
{
    public class WeighingMachine
    {
        //private int precision;
        private double weight;
        public double TareAdjustment;
        public WeighingMachine(int precision)
        {
            Precision = precision;
            TareAdjustment = 5.0d;
        }
        public int Precision { get; private set; }

        public double Weight
        {
            get { return weight; }
            set
            {
                ArgumentOutOfRangeException.ThrowIfNegative(value);
                weight = value;
            }
        }
        public string DisplayWeight
        {
            get
            {
                string displayWeight = (Weight - TareAdjustment).ToString("F" + Precision);
                return $"{displayWeight} kg";
            }
        }
    }
}
