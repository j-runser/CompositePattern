using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : Component
    {
        private List<Component> children;

        public Composite(string name, double weight) : base(name, weight)
        {
            children = new List<Component>();
        }

        public override void Add(Component c)
        {
            children.Add(c);
        }

        public override void Remove(Component c)
        {
            children.Remove(c);
        }

        public override double CalculateWeight()
        {
            double retval = 0;

            foreach(Component child in children)
            {
                retval += child.CalculateWeight();
            }

            return retval;
        }

        public override string ToString(int depth)
        {
            string retval = new string(tabSymbol, depth * tabWidth) + name + "\n";

            foreach(Component child in children)
            {
                retval += child.ToString(depth + 1);
            }

            return retval;
        }
    }
}
