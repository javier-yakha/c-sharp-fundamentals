using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules
{
    public class EventsDelegates
    {
        public delegate void ClickEventHandler();
        public static event ClickEventHandler? Click;

        public static void SimulateClick()
        {
            Console.WriteLine("Button clicked");
            OnClick();
        }
        public static void OnClick()
        {
            Click?.Invoke();
        }
    }
    public class EventHandlerClass()
    {
        public static void ButtonClickHandler()
        {
            Console.WriteLine("Button click event handler");
        }
    }
}
