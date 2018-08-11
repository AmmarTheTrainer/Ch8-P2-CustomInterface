using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P2_CustomInterface
{
    class Triangle : Shape , IPointy
    {
        public Triangle() { }
        public Triangle(string name) : base(name) { }


        public override void Draw()
        { Console.WriteLine("Drawing {0} the Triangle", PetName); }

        public byte GetNumberOfPoints()
        {
            return 3;
        }

        public byte Points => 3;

        //IPointy implementation.
        //public byte Points
        //{
        //    get { return 3; }
        //}
    }
}
