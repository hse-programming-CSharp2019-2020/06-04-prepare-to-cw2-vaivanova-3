using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    class Box : Item
    {
        private double a, b, c;
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
            return base.ToString() + $"A: {A}, B: {B}, C: {C}.";
        }
    }
}
