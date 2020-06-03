using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKRLib
{
    class Box : Item
    {
        private double A
        {
            set;
            get;
        }
        private double B
        {
            set;
            get;
        }
        private double C
        {
            set;
            get;
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
