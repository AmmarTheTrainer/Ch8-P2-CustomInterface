﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8_P2_CustomInterface
{
    class Hexagon : Shape , IPointy , IDraw3D
    {
        public Hexagon()
        {

        }

        public Hexagon(string name) : base(name)
        {

        }

        public byte Points => 6 ;

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public void Draw3D()
        {
            Console.WriteLine(" Drawing hexagon in 3D ");
        }
    }
}
