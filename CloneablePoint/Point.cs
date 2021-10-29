using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public PointDescription desc = new PointDescription();
        public  Point(int xPos, int yPos, string petName) { X = xPos; Y = yPos; desc.PetName = petName; }
        public  Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        public Point() { }
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n ";
        //public object Clone () => new Point(this.X, this.Y, this.desc.PetName);
        //public object Clone() => this.MemberwiseClone();
        public object Clone()
        {
            Point newPoint = (Point)this.MemberwiseClone();
            PointDescription currentDesc = new PointDescription();
            currentDesc.PetName = this.desc.PetName;
            newPoint.desc = currentDesc;
            return newPoint;
        }

    }
}
