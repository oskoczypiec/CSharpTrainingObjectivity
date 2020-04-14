using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject1
{
    class Cat : Animal
    {
        //string kind;
        public Cat() : base("Furry kitty")
        {
            kind = base.kind;
            //kind = "Nice animal";
        }

    }
}
