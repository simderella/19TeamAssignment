using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtanGame


{
    public class Monster
    {
        public string Name { get; }
        public int Level { get; }
        public int Atk { get; }
        public int MaxHp { get; private set; }

        public int Hp { get; private set; }
        public bool IsAlive
        {
            get { return Hp > 0; }
        }

        public Monster(string name, int level, int atk, int hp)
        {
            Name = name;
            Level = level;
            Atk = atk;
            MaxHp = hp;
            Hp = hp;
        }

        public void TakeDamage(int damage)
        {
            Hp = Math.Max(0, Hp - damage);
        }

        public void Heal(int amount)
        {
            Hp = Math.Min(MaxHp, Hp + amount);
        }
    }
}