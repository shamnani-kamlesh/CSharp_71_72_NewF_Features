using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Child_OutsideCurrentAssembly : Parent
    {
        public Child_OutsideCurrentAssembly()
        {
            //this.private_var = 0;                 // not accessible = because private members are not accessible out side of the class
            this.protected_var = 0;                 // accessible - because protected members are accessible within derived class
            this.public_var = 0;                    // accessible - because public is accessible anywhere
            //this.internal_var = 0;                // not accessible - because internal is not accessible outside the assembly
            this.internal_protected_var = 0;        // accessible - because internal protected is accessible within derived class  or within current assembly
            //this.private_protected_var = 0;       // not accessible - because private protected is accessible within derived and within current assembly
        }
    }

    public class NonChild_OutsideCurrentAssembly
    {
        public NonChild_OutsideCurrentAssembly()
        {
            Parent p = new Parent();
            //base.private_var = 0;                 // not accessible = because private members are not accessible out side of the class
            //p.protected_var = 0;                  // not accessible - because protected members are accessible within derived class
            p.public_var = 0;                       // accessible - because public is accessible anywhere
            //p.internal_var = 0;                   // not accessible - because internal is not accessible outside the assembly
            //p.internal_protected_var = 0;         // not accessible - because internal protected is only accessible within derived class or within current assembly
            //p.private_protected_var = 0;          // not accessible - because private protected is accessible within derived and within current assembly
        }
    }
}