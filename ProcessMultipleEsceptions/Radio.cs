using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleEsceptions
{
    class Radio
    {
        public void TurnON(bool on)
        {
            Console.WriteLine(on ? "Jamming..." : "Quiet time...");
        }

    }
}
