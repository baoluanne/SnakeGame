using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classsic_Snake
{
    internal class Settings
    {
        public static int Width {get; set;}
        public static int Height { get; set;}
        public static string directions;//chir đường 
        public Settings()
        {
            Width = 16; Height = 16;
            directions = "left";
        }
    }
}
