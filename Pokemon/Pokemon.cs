namespace Pokemon
{
    public class Pokemon
    {
       
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
            Name = name;
            Type = type;
            Level = level;
        }

        
    }

}
