using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject1
{
    interface IAnimal
    {
        string Fur { get; set; }
        string SaySomething();
    }
}
