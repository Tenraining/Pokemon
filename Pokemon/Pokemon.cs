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


        //constants

        private const int MINIMUMLEVEL = 1;
        private const int MAXIMUMLEVEL = 100;


        


        public string Name { get; set; }
        public string Type { get; set; }
        public int Level { get; set; }

        public Pokemon(string name, string type, int level)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("LastName", "Last name cannot be missing or blank");
            }
            Name = name;
            Type = type;
            Level = level;

            if (employments != null)
            {
                EmploymentPositions = employments; //save it
            }
        }
        //The parent class is the one where this property is declared.
        public List<BaseStats> Pokemonsds { get; private set; } = new List<BaseStats>();


    }

}
