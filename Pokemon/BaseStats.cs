using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    internal class BaseStats
    {
        private int _Hp;
        private int _Attack;
        private int _SpecialAttack;
        private int _Defense;
        private int _SpecialDefense;
        private int _Speed;

        public int HP { get; set; }
        public int Attack { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

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
