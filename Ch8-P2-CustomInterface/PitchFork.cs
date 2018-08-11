using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch8_P2_CustomInterface
{
    public class PitchFork : IPointy
    {
        public byte Points => 1;
    }
}