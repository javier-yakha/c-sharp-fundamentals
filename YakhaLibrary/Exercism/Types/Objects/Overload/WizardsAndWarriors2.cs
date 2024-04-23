using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Objects.Overload
{
    public static class GameMaster
    {
        public static string Describe(Character character) => $"You're a level {character.Level} {character.Class} with {character.HitPoints} hit points.";
        public static string Describe(Destination destination) => $"You've arrived at {destination.Name}, which has {destination.Inhabitants} inhabitants.";
        public static string Describe(TravelMethod travelMethod)
        {
            string msg = "You're traveling to your destination ";
            if (travelMethod == TravelMethod.Walking) msg += "by walking.";
            if (travelMethod == TravelMethod.Horseback) msg += "on horseback.";
            return msg;
        }
        public static string Describe(Character character, Destination destination, TravelMethod travelMethod) => $"{Describe(character)} {Describe(travelMethod)} {Describe(destination)}";
        public static string Describe(Character character, Destination destination) => $"{Describe(character)} You're traveling to your destination by walking. {Describe(destination)}";
    }
    public class Character
    {
        public string Class { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
    }
    public class Destination
    {
        public string Name { get; set; }
        public int Inhabitants { get; set; }
    }
    public enum TravelMethod
    {
        Walking,
        Horseback
    }

}
