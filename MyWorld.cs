using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyStart
{
    internal class MyWorld : World
    {
        public MyWorld() : base(1920, 1080)
        {
            // Tile background with the file "Bakgrund_resized" in the Content folder.
            BackgroundTileName = "Bakgrund_resized";
            Add(new Gible(), "Gible", 1000, 500);
            Add(new Boss1(), "Boss1", 100, 200);
            Add(new Pinapberry(), "pinap-berry", 100, 200);
        }  
    }
}
