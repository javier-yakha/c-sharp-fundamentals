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
            // TODO: implement equality and GetHashCode() methods
            public bool Equals(FacialFeatures other)
            {
                bool eyes = EyeColor == other.EyeColor;
                bool philtrum = PhiltrumWidth == other.PhiltrumWidth;
                return eyes && philtrum;
            }
            public override int GetHashCode()
            {
                return (EyeColor.GetHashCode() - PhiltrumWidth.GetHashCode()).GetHashCode();
            }
        }
        public class Identity(string email, FacialFeatures facialFeatures)
        {
            public string Email { get; } = email;
            public FacialFeatures FacialFeatures { get; } = facialFeatures;
            // TODO: implement equality and GetHashCode() methods
        }
        public class Authenticator
        {
            public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB) => faceA.Equals(faceB);
            
            public bool IsAdmin(Identity identity)
            {
                throw new NotImplementedException("Please implement the Authenticator.IsAdmin() method");
            }
            public bool Register(Identity identity)
            {
                throw new NotImplementedException("Please implement the Authenticator.Register() method");
            }
            public bool IsRegistered(Identity identity)
            {
                throw new NotImplementedException("Please implement the Authenticator.IsRegistered() method");
            }
            public static bool AreSameObject(Identity identityA, Identity identityB)
            {
                throw new NotImplementedException("Please implement the Authenticator.AreSameObject() method");
            }
        }
    }
}
