using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    public class Item : IComparable<Item>
    {

        private double Weight
        {
            set;
            get;
        }

        public int CompareTo(Item obj)
        {
            return (this.Weight).CompareTo(obj.Weight);
        }

        public static explicit operator double(Item obj)
        {
            return obj.Weight;
        }

        public override string ToString()
        {
            return $"Weight: {Weight}.";
        }
    }
}
