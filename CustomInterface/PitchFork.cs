using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class PitchFork: IPointy
    {
        public PitchFork() { }
        public PitchFork(string name = "Pitch Fork zero")
        {
            PetName = name;

        }

        public string PetName { get; set; }
        public byte Points
        {
            get { return 111; }
        }
    }
}
