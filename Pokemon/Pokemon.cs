using System.Net;

namespace Pokemon
{
    public class Pokemon
    {
       //Pokemon will be the parent class


        //data members

        private string _Name;
        private int _Level;
        private string _Type;
        //private string _Stats; // todo 2 


        //constants

        private const int MINIMUMLEVEL = 1;
        private const int MAXIMUMLEVEL = 100;


        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        //public int Stats { get; set; } //todo 2


        public Pokemon(string name, string type, int level, BaseStats stats)
        {
            if (string.IsNullOrWhiteSpace(name)) // commentTodo1(1)
            {
                throw new ArgumentNullException("LastName", "Last name cannot be missing or blank");
            }
            Name = name;
            Type = type;
            Level = level;
            stats = stats; // Stats wth UpperCase
            //this field actually does not exist i actually create in comments because i dont want to invade your code . (//todo 2)
            //ADD: PokemonStats.Add(stats) // actually add the stats to the list.
        }

        //todo 1: the if line is redundant shouldn't be validation in the constructor 



        //The parent class is the one where this property is declared. Didn't work initially 
        //because basestats was not public
        public List<BaseStats> PokemonStats { get; private set; } = new List<BaseStats>();
        //private List<BaseStats> _pokemonStats = new List<BaseStats>();
        //public List<BaseStats> PokemonStats
        //{
        //    get { return _pokemonStats; }
        //    private set { _pokemonStats = value; }  // Only internal set
        //}




        //Declare a public property
        //List<BaseStats> it holds a collection of BaseStats objects from the class "BaseStats"
        // is public so other classes can read it 
        //
        //we should implement this; IReadOnlyList<BaseStats>
        //DaNiEl  WAS HERE  - Happy Halloween!

    }

}
