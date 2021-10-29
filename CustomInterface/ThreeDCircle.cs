using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class ThreeDCircle : Circle, IDraw3D
    {
        public ThreeDCircle() { }
        public ThreeDCircle(string name) : base(name) { }
        public override void Draw()
        {
            Console.WriteLine($"Dravind {PetName} the Circle");
        }
        public byte Points
        {
            get { return 0; }
        }
        public void Draw3D()
        { Console.WriteLine("Drawing Circle in 3D!!!"); }
    }
}
