using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using implementingOCP.Services.Abstraction;

namespace implementingOCP.Services
{
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Drawing a rectangle");
        }
    }
}