using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_JQA
{
    class Rounds : Shapes
    {
        private int Radius { get; set; }
        public Rounds(int area, int parameter, int height, int radius) : base(area, parameter, height)
        {
            Radius = radius;
        }

        public int CalculateParameter()
        {
            int result = this.Radius * this.Radius;
            return result;
        }

        public double GetArea()
        {
            int param = GetParameter();
            int result = param * 2;
            return result;
        }
    }
}
