using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Structs
{
    public class LandGrabInSpace
    {
        public readonly struct Coord(ushort x, ushort y)
        {
            public ushort X { get; } = x;
            public ushort Y { get; } = y;
            public static bool operator ==(Coord lhs, Coord rhs) => lhs.X == rhs.X && lhs.Y == rhs.Y;
            public static bool operator !=(Coord lhs, Coord rhs) => lhs.X != rhs.X || lhs.Y != rhs.Y;
            public bool Equals(Coord other) => this == other;
            public override bool Equals(object? obj) => obj is not null && obj.GetType() == GetType() && Equals((Coord)obj);
            public override int GetHashCode() => X.GetHashCode() ^ Y.GetHashCode();
            
        }
        public readonly struct Plot(Coord west, Coord east, Coord south, Coord north)
        {
            public static bool operator ==(Plot lhs, Plot rhs) => lhs.Equals(rhs);
            public static bool operator !=(Plot lhs, Plot rhs) => !lhs.Equals(rhs);
            public readonly bool Equals(Plot other)
            {
                return
                    West == other.West &&
                    East == other.East &&
                    North == other.North &&
                    South == other.South;
            }
            public override readonly bool Equals(object? obj) => obj is not null && obj.GetType() == GetType() && Equals((Plot)obj);
            public override readonly int GetHashCode() => West.GetHashCode() ^ East.GetHashCode() ^ North.GetHashCode() ^ South.GetHashCode();
            public Coord West { get; } = west;
            public Coord East { get; } = east;
            public Coord North { get; } = north;
            public Coord South { get; } = south;
            public int GetPerimeter()
            {
                int NW = (int)(Math.Pow(West.X - North.X, 2) + Math.Pow(West.Y - North.Y, 2));
                int NE = (int)(Math.Pow(East.X - North.X, 2) + Math.Pow(East.Y - North.Y, 2));
                int SW = (int)(Math.Pow(West.X - South.X, 2) + Math.Pow(West.Y - South.Y, 2));
                int SE = (int)(Math.Pow(East.X - South.X, 2) + Math.Pow(East.Y - South.Y, 2));
                return NW + NE + SW + SE;
            }
        }
        public class ClaimsHandler
        {
            public HashSet<Plot> plots = [];
            public Plot lastPlot;
            public void StakeClaim(Plot plot)
            {
                lastPlot = plot;
                plots.Add(plot);
            }
            public bool IsClaimStaked(Plot plot) => plots.Contains(plot);
            public bool IsLastClaim(Plot plot) => lastPlot == plot;
            public Plot GetClaimWithLongestSide()
            {
                if (plots.Count == 0) throw new ArgumentOutOfRangeException("There are no plots claimed");
                Plot biggest = lastPlot;
                foreach (var plot in plots)
                {
                    if (plot.GetPerimeter() > biggest.GetPerimeter()) biggest = plot;
                }
                return biggest;
            }
        }
    }
}
