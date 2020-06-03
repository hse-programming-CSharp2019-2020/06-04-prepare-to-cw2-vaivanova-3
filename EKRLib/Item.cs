using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    [DataContract]
    public class Item : IComparable<Item>
    {
        public Item(double w)
        {
            Weight = w;
        }
        private double weight;

        [DataMember]
        public double Weight
        {
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                weight = value;
            }
            get => weight;
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
