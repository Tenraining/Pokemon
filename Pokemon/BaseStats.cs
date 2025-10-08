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

        public int HP { get; private set; }
        public int Attack { get; private set; }
        public int SpecialAttack { get; private set; }
        public int SpecialDefense { get; private set; }
        public int Defense { get; private set; }
        public int Speed { get; private set; }

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
