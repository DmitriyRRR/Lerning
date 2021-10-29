using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    class Octagon: IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        void IDrawToForm.Draw()
        {
            Console.WriteLine("Drawing the Octagon... IDrawToForm");
        }
        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Drawing the Octagon... IDrawToMemory");
        }
        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Drawing the Octagon... IDrawToPrinter");
        }
    }
}
