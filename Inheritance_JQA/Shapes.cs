using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_JQA
{
    class Shapes
    {
        private int Area { get; set; }
        private int Parameter;

        public int Height { get; set; }

        public Shapes(int area, int parameter, int height)
        {
            this.Area = area;
            this.Parameter = parameter;
            this.Height = height;
        }
        public int GetParameter()
        {
            return Parameter;
        }

        public void SetParameter(int param)
        {
            Parameter = param;
        }

        public int CalculateArea()
        {
            int result = this.Height * this.Parameter;
            return result;
        }
    }
}
