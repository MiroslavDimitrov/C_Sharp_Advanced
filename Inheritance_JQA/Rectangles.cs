using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_JQA
{
    class Rectangles : Shapes
    {
        private int SideA;
        private int SideB;
        public Rectangles(int area, int parameter, int height, int sideA, int sideB) : base(area, parameter, height)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public void SetSideA(int firstSide)
        {
            this.SideA = firstSide;
        }
        public int GetSideA()
        {
            return SideA;
        }

        public void SetSideB(int secondSide)
        {
            this.SideA = secondSide;
        }
        public int GetSideB()
        {
            return SideB;
        }

        public int CalculateParameter()
        {
            int result = SideA * SideB;
            return result;
        }

        public double SumArea()
        {
            int result = this.SideA * this.SideB;
            return (int)result;
        }

        public double SumVolume()
        {
            int result = this.SideA * this.SideB * this.Height;
            return result;
        }
    }
}
