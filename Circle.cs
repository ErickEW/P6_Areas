using System;

namespace P6___Areas
{
    class Circle
    {
       int rad;

       public Circle(int rad)
       {
           this.rad = rad;
       }

       public int getArea()
       {
            if(this.rad < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                double decArea = this.rad * this.rad * Math.PI;
                int area = Convert.ToInt32(decArea);
                return area;
            }   
        }
    }
}