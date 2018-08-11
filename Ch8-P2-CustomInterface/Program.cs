using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P2_CustomInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Interfaces *****\n");

            #region Invoking Interface Members at the Object Level

            //// Call Points property defined by IPointy.
            //Hexagon hex = new Hexagon();
            //Console.WriteLine("Points: {0}", hex.Points);

            //// Catch a possible InvalidCastException.
            //Circle c = new Circle("A Hot Circle");
            //IPointy itfPt = null;
            //try
            //{
            //    itfPt = (IPointy)c;
            //    Console.WriteLine(itfPt.Points);
            //}
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Obtaining Interface References: The as Keyword

            // Can we treat hex2 as IPointy?
            Hexagon hex2 = new Hexagon("Peter");
            IPointy itfPt2 = hex2 as IPointy;

            if (itfPt2 != null)
            {
                Console.WriteLine("Points: {0}", itfPt2.Points);
            }
            else
            {
                Console.WriteLine("OOPS! Not pointy...");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
