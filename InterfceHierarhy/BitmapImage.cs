﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfceHierarhy
{
    class BitmapImage: IAdvancedDraw
    {
        public void Draw()
        {
            Console.WriteLine("Drawong...");
        }
        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing in a box...");
        }
        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing upside down!");
        }
    }
}
