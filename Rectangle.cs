using System;

namespace P6___Areas
{
    class Rectangle
    {
       int bAse;
       int hight;

       public Rectangle(int bAse, int hight)
       {
           this.bAse = bAse;
           this.hight = hight;
       }

       public int getArea()
       {
            if(this.bAse < 1 || this.hight < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                int area = this.bAse * this.hight;
                return area;
            }   
        }
    }
}