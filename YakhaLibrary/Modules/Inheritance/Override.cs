using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Modules.Inheritance
{
    public static class Override
    {
        public class BaseClass
        {
            public BaseClass() 
            {
                Console.WriteLine("Base constructor");
            }
            public BaseClass(string abc)
            {
                Console.WriteLine("Base constructor: " + abc);
            }
            public virtual void Show()
            {
                Console.WriteLine("Base Class");
            }
        }
        interface IBaseClass
        {
            void Show();
            public enum JobLevel
            {
                JL1 = 1,
                JL2,
                JL3
            }
        }
        public class SubClass : BaseClass, IBaseClass
        {
            public SubClass()
            {
                Console.WriteLine("Sub constructor");
            }
            public SubClass(string abc)
            {
                Console.WriteLine("Sub constructor with: " + abc);
            }
            public override void Show()
            {
                Console.WriteLine("Sub Class");
            }
        }
        public static void ShowOverride()
        {
            BaseClass baseObject = new BaseClass();
            BaseClass subObject = new SubClass();

            baseObject.Show();
            subObject.Show();

            BaseClass subDoubleObject = new SubClass("input");
            subDoubleObject.Show();
        }
    }
}
