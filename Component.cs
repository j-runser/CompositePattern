using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    abstract class Component
    {
        protected string name;
        protected double weight;
        protected int tabWidth;
        protected char tabSymbol;

        public Component(string name, double weight)
        {
            this.weight = weight;
            this.name = name;
            this.tabWidth = 3;
            this.tabSymbol = '-';
        }

        public virtual void Add(Component c)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(Component c)
        {
            throw new NotImplementedException();
        }
        public abstract double CalculateWeight();
        public abstract string ToString(int depth);

        public int TabWidth
        {
            get { return tabWidth; }
            set { tabWidth = value; }
        }

        public char TabSymbol
        {
            get { return tabSymbol; }
            set { tabSymbol = value; }
        }
    }
}
