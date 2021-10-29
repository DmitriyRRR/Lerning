using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomInterface
{
    class Fork:  IPointy
    {
        public Fork() { }
        public Fork(string name = "Fork zero") 
        {
             PetName = name;

        }
        
        public string PetName { get; set; }
        public byte Points
        {
            get { return 124; }
        }
    }
}