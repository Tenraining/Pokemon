using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class BaseStats
    {
        private int _Hp;
        private int _Attack;
        private int _SpecialAttack;
        private int _Defense;
        private int _SpecialDefense;
        private int _Speed;


        //Private sets will protect then from external modifications
        public int HP
        {
            get => _Hp;
            set
            {
                if (value < 1 || value > 255)
                    throw new ArgumentOutOfRangeException(nameof(HP), value, "HP must be between 1 and 255.");
                _Hp = value;
            }
        }

        public int Attack { get; private set; }
        public int SpecialAttack { get; private set; }
        public int SpecialDefense { get; private set; }
        public int Defense { get; private set; }
        public int Speed { get; private set; }

        private int ValidateStats(string statName, int value)
        {
            if (value < 1 || value > 256)
                throw new ArgumentOutOfRangeException(statName, value, $"{statName} must be between 1 and 256.");
            return value;
        }

        public BaseStats(int hp, int attack, int specialattack,int specialdefense, int defense, int speed)
        {
          

            HP = hp;
            Attack = attack;
            SpecialAttack = specialattack;
            SpecialDefense = specialdefense;
            Defense = defense;
            Speed = speed;
        }

       

        //public virtual void DisplayStats()
        //{
        //    Console.WriteLine($"HP: {HP}, Attack: {Attack}, Defense: {Defense}, Speed: {Speed}");
        //}
    }
}
