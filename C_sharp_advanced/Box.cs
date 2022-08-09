using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_advanced
{
    class Box
    {

        //member variables
        private int lenght;
        private int height;
        private int width;
        private int volume;
        //readonly can have only get method for the proper
        public Box(int lenght, int height, int width)
        {
            this.lenght = lenght;
            this.height = height;
            this.width = width;
        }

        public int Lenght
        { 
            get 
            { 
                return lenght; 
            }
            set 
            { 
               this.lenght = value;
            }
        }

        public int Height
        {
            get 
            {
                return height;
            }
            set 
            {
                if (height < 0)
                {
                    height = -value;
                }
                else
                { 
                    height = value;
                }
               
            }
        }

        //set the value
        public void SetWidth(int Width)
        {
            this.width = Width;
        }

        //returns the value
        public int GetWidth()
        {
            return this.width;
        }

        public int Volume
        {
            get 
            {
                return this.lenght * this.height * this.width;
            } 
        }

        public int FrontSurface
        { 
            get 
            {
                return this.height * this.lenght; 
            }
        }
        public void DisplayInfo()
        {
            Console.WriteLine("lenght is {0} and height is {1} and width is {2} so the volume is {3}",
                lenght, height, width, volume = lenght * height * width);
        }
    }
}
