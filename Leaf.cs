using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    partial class Leaf : Component
    {
        public Leaf(string name, double weight) : base(name, weight)
        {
        }
        
        public override double CalculateWeight()
        {
            return weight;
        }

        public override string ToString(int depth)
        {
            return (new string(tabSymbol, depth * tabWidth) + name + "\n");
        }
    }
}
