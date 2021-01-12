using System;

namespace P6___Areas
{
    class Pentagon
    {
       int perimeter;
       int apothem;
       public Pentagon(int perimeter, int apothem)
       {
           this.perimeter = perimeter;
           this.apothem = apothem;
       }

       public int getArea()
       {
            if(this.perimeter < 1 || this.apothem < 1)
            {
                System.Console.WriteLine("Error");
                return 0;
            }
            else
            {
                int area = this.perimeter * this.apothem / 2;
                return area;
            }   
        }
    }
}