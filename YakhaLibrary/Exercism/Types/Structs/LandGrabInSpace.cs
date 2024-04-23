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
        public readonly struct Plot(Coord left, Coord right, Coord down, Coord up)
        {
            public static bool operator ==(Plot lhs, Plot rhs) => lhs.Equals(rhs);
            public static bool operator !=(Plot lhs, Plot rhs) => !lhs.Equals(rhs);
            public readonly bool Equals(Plot other)
            {
                return
                    Left == other.Left &&
                    Right == other.Right &&
                    Up == other.Up &&
                    Down == other.Down;
            }
            public override readonly bool Equals(object? obj) => obj is not null && obj.GetType() == GetType() && Equals((Plot)obj);
            public override readonly int GetHashCode() => Left.GetHashCode() ^ Right.GetHashCode() ^ Up.GetHashCode() ^ Down.GetHashCode();
            public Coord Left { get; } = left;
            public Coord Right { get; } = right;
            public Coord Up { get; } = up;
            public Coord Down { get; } = down;
        }
        public class ClaimsHandler
        {
            public List<Plot> plots = [];
            public void StakeClaim(Plot plot) => plots.Add(plot);
            public bool IsClaimStaked(Plot plot) => plots.Contains(plot);
            public bool IsLastClaim(Plot plot) => plots[^1] == plot;
            public Plot GetClaimWithLongestSide()
            {
                return plots[^1];
            }
        }
    }
}
