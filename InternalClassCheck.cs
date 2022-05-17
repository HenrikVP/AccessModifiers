using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    internal class InternalClassCheck
    {
        BaseClass bc = new BaseClass();
        DerivedClass derived = new DerivedClass();
        void Test2()
        {
            //Only Public and Internal can be seen from here.
            derived.MyInternalField = 100;
            derived.MyProperty = 10;

        }
    }
}
