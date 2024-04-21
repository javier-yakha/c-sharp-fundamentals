using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Types.Equalities
{
    public class Faceid2
    {
        public class FacialFeatures(string eyeColor, decimal philtrumWidth)
        {
            public string EyeColor { get; } = eyeColor;
            public decimal PhiltrumWidth { get; } = philtrumWidth;
            public bool Equals(FacialFeatures other) => EyeColor == other.EyeColor && PhiltrumWidth == other.PhiltrumWidth;
            public override int GetHashCode() => (EyeColor.GetHashCode() - PhiltrumWidth.GetHashCode()).GetHashCode();
        }
        public class Identity(string email, FacialFeatures facialFeatures)
        {
            public string Email { get; } = email;
            public FacialFeatures FacialFeatures { get; } = facialFeatures;
            public bool Equals(Identity other) => FacialFeatures.Equals(other.FacialFeatures) && Email == other.Email;
            public override int GetHashCode() => (Email.GetHashCode() - FacialFeatures.GetHashCode()).GetHashCode();
        }
        public class Authenticator
        {
            private Identity Admin { get; set; } = new Identity("admin@exerc.ism", new FacialFeatures("green", 0.9m));
            private HashSet<Identity> Users { get; set; } = [];
            public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);
            public bool IsAdmin(Identity identity) => identity.Equals(Admin);
            public bool Register(Identity identity)
            {
                if (IsRegistered(identity)) return false;
                return Users.Add(identity);
            }
            public bool IsRegistered(Identity identity) => Users.Any(x => x.Equals(identity));
            public static bool AreSameObject(Identity identityA, Identity identityB) => identityA == identityB;
        }
    }
}
