using System;

namespace P6___Areas
{
    class Square
    {
        int size;

        public Square(int size)
        {
            this.size = size;
        }

        public int getArea()
        {
            if(this.size < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                int area = this.size * this.size;
                return area;
            }   
        }
    }

}