using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    [DataContract, KnownType((typeof(Item)))]
    public class Box : Item
    {
        private double a, b, c;

        public Box(double w, double a, double b, double c) : base(w)
        {
            A = a;
            B = b;
            C = c;
        }
        

        [DataMember]
        private double A
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                a = value;
            }
            get => a;
        }

        [DataMember]
        private double B
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                b = value;
            }
            get => b;
        }

        [DataMember]
        private double C
        {
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                c = value;
            }
            get => c;
        }

        double GetLongestSideSize()
        {
            return Math.Max(Math.Max(A, B), C);
        }

        public override string ToString()
        {
            return $"{base.ToString()} A: {A}, B: {B}, C: {C}.";
        }
    }
}
