using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Parent
    {
        private int private_var { get; set; }
        protected int protected_var { get; set; }
        public int public_var { get; set; }
        internal int internal_var { get; set; }

        internal protected int internal_protected_var { get; set; }
        private protected int private_protected_var { get; set; }
    }

    public class Child_WithinCurrentAssembly : Parent
    {
        public Child_WithinCurrentAssembly()
        {
            //this.private_var = 0;             // not accessible = because private members are not accessible out side of the class
            this.protected_var = 0;             // accessible - because protected members are accessible within derived class
            this.public_var = 0;                // accessible - because public is accessible anywhere
            this.internal_var = 0;              // accessible - because internal is accessible anywhere within the assembly
            this.internal_protected_var = 0;    // accessible - because internal protected is accessible within derived class or within current assembly
            this.private_protected_var = 0;     // accessible - because private protected is accessible within derived and within current assembly
        }
    }

    public class NonChild_WithinCurrentAssembly
    {
        public NonChild_WithinCurrentAssembly()
        {
            Parent p = new Parent();
            //p.private_var = 0;                // not accessible = because private members are not accessible out side of the class
            //p.protected_var = 0;              // not accessible - because it is not derived class
            p.public_var = 0;                   // accessible - because public is accessible anywhere
            p.internal_var = 0;                 // accessible - because internal is accessible anywhere within current assembly
            p.internal_protected_var = 0;       // accessible - because internal protected is accessible within derived class or within current assembly
            //p.private_protected_var = 0;      // not accessible - because private protected is accessible within derived and within current assembly
        }
    }
}