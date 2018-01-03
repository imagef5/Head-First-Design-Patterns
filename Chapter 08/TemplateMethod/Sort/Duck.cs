using System;
using System.Collections.Generic;

namespace Sort
{
    public class Duck : IComparable<Duck>
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
        public int CompareTo(Duck other)
        {
            if(this.weight < other.weight)
            {
                return -1;
            }
            else if(this.weight == other.weight)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public override string ToString()
        {
            return $"{name} , 체중 : {weight}";
        }
    }
}