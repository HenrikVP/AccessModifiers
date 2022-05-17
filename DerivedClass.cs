using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class DerivedClass : BaseClass
    {
        void Test3()
        {
            //Only Protected, Internal and Public can be seen from here
            //MyPrivateField = 1000;
            MyProtectedField = 10;
        }
    }
}
