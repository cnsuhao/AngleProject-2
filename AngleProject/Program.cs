using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle a = new Angle(3, 36, 53);
            Angle b = new Angle(4, 27, 45);
            Angle aa = new Angle(3, 36, 53);
            Angle bb = new Angle(4, 27, 45);
            


          
            Angle a1 = new Angle(44, 27, 45);
            Angle a2 = new Angle(44, 27, 45);
            Angle a3 = new Angle(3, 45, 3);
            Angle a4 = new Angle(34, 7, 55);
            Angle a5 = new Angle(-34, -7, -55);
            Angle a5temp = new Angle(-34, -7, -55);

            Console.WriteLine("a = " + a.ToString());
            Console.WriteLine("b = " + b.ToString());
            Console.WriteLine("a1 = " + a1.ToString());
            Console.WriteLine("a2 = " + a2.ToString());
            Console.WriteLine("a3 = " + a3.ToString());
            Console.WriteLine("a4 = " + a4.ToString());
            Console.WriteLine("a5 = " + a5.ToString());

            Console.WriteLine("\n\nOperatii:" );
            Angle c = new Angle();
            c = a + b;
            Angle d = new Angle();
            d = a - b;
            Angle e = new Angle();
            e = bb - aa;

            Angle f = new Angle();
            f = a3 + a5;

            Console.WriteLine(a.ToString() + " + " + b.ToString() + " = " +  c.ToString());
            Console.WriteLine(a.ToString() + " - " + b.ToString() + " = " + d.ToString());
            Console.WriteLine(b.ToString() + " - " + a.ToString() + " = " + e.ToString());
            Console.WriteLine(a3.ToString() + " + " + a5temp.ToString() + " = " + f.ToString());

            if (a1 == a2)
                Console.WriteLine("a1 = a2");
            else
                Console.WriteLine("a1 != a2");

            if (a1 != a3)
                Console.WriteLine("a1 != a3");
            else
                Console.WriteLine("a1 == a3");

            if (a3 >= a4)
                Console.WriteLine("a3 >= a4");
            else
                Console.WriteLine("a3 <= a4");

            
            if (a4 <= a3)
                Console.WriteLine("a4 <= a3");
            else
                Console.WriteLine("a4 >= a3");

            
            if (a3 < a4)
                Console.WriteLine("a3 < a4");
            else
                Console.WriteLine("a3 > a4");

            
            if (a3 > a4)
                Console.WriteLine("a3 > a4");
            else
                Console.WriteLine("a3 < a4");


            Angle longAngle = new Angle(123, 345, 567);
            Console.WriteLine("\nConvert: " + longAngle.ToString());
            Console.WriteLine("Result: " + Angle.NormilizeAngle(longAngle));






            Console.ReadKey();
        }
    }
}
