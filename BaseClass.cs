using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class BaseClass
    {
        //Here we can see EVERYTHING!
        private int MyPrivateField = 0;
        protected int MyProtectedField = 10;
        internal int MyInternalField = 100;
        public int MyProperty { get; set; }
    }
}
