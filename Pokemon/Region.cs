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

        //A region has many Pokémon.
        public List<Pokemon> Pokemons { get; private set; } = new List<Pokemon>();
        public Region(string name, RegionType type)
        {
            name = name;
            Type = type;
        }

        public string Name { get; private set; }
        public RegionType Type { get; private set; }




    }
}
