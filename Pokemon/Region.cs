using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class Region
    {
        //Kanto, Johto, Hoenn, Sinnoh, Unova, Kalos, Alola, Galar, Hisui (Sinnoh's past), and Paldea.
        //data members

        private string _Location;
        private string _Route;

        //constants

        public string Location { get; set; }
        public string Route { get; set; }

        public RegionType Type { get; set; }

        public Region(RegionType type)
        {
            Type = type;
        }

    }
}
