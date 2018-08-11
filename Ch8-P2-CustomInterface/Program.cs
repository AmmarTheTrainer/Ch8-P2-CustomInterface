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

            //// Can we treat hex2 as IPointy?
            //Hexagon hex2 = new Hexagon("Peter");
            //IPointy itfPt2 = hex2 as IPointy;

            //if (itfPt2 != null)
            //{
            //    Console.WriteLine("Points: {0}", itfPt2.Points);
            //}
            //else
            //{
            //    Console.WriteLine("OOPS! Not pointy...");
            //}

            #endregion

            #region The is Keyword (Updated)

            //// Make an array of Shapes.
            //Shape[] myShapes = { new Hexagon(), new Circle(),
            //                        new Triangle("Joe"), new Circle("JoJo")};

            //for (int i = 0; i < myShapes.Length; i++)
            //{
            //    // Recall the Shape base class defines an abstract Draw() member, so all shapes know how to draw themselves.

            //    myShapes[i].Draw();

            //    if (myShapes[i] is IPointy ip) // Who's pointy?
            //    {
            //        Console.WriteLine("-> Points: {0}", ip.Points);
            //    }
            //    else
            //    {
            //        Console.WriteLine("-> {0}\'s not pointy!", myShapes[i].PetName);
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Interfaces As Parameters

            //Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo") };

            //for (int i = 0; i < myShapes.Length; i++)
            //{
            //    // Can I draw you in 3D?
            //    if (myShapes[i] is IDraw3D)
            //    {
            //        DrawIn3D((IDraw3D)myShapes[i]);
            //    }
            //}

            #endregion

            #region Interfaces As Return Values

            //// Make an array of Shapes.
            //Shape[] myShapes = { new Hexagon(), new Circle(), new Triangle("Joe"), new Circle("JoJo")};

            //// Get first pointy item.
            //// To be safe, you'd want to check firstPointyItem for null before proceeding.

            //IPointy firstPointyItem = FindFirstPointyShape(myShapes);

            //Console.WriteLine("The item has {0} points", firstPointyItem.Points);

            #endregion

            #region Arrays of Interface Types

            // This array can only contain types that
            // implement the IPointy interface.
            IPointy[] myPointyObjects = {new Hexagon(), new Knife(), new Triangle(), new Fork(), new PitchFork()};

            foreach (IPointy i in myPointyObjects)
                Console.WriteLine("Object has {0} points.", i.Points);

            #endregion

            Console.ReadLine();
        }


        // This method returns the first object in the
        // array that implements IPointy.
        private static IPointy FindFirstPointyShape(Shape[] shapes)
        {
            foreach (Shape s in shapes)
            {
                if (s is IPointy ip)
                {
                    return ip;
                }
            }
            return null;
        }

        // I'll draw anyone supporting IDraw3D.
        private static void DrawIn3D(IDraw3D itf3d)
        {
            Console.WriteLine("-> Drawing IDraw3D compatible type");
            itf3d.Draw3D();
        }

    }
}
