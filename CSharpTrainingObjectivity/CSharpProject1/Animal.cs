using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject1
{
    public class Animal : IAnimal
    {
        public string kind;
        public Animal(string kind)
        {
            kind = "Nice animal";
        }

        public string Fur { get ; set; }

        public string SaySomething()
        {
            throw new NotImplementedException();
        }
    }
}
