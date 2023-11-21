using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtanGame
{
    public class Battle
    {
        // 몬스터 배열
        private Monster[] monsters;

        // 생성자에서 몬스터 배열을 받도록 수정
        public Battle(Monster[] monsters)
        {
            this.monsters = monsters;
        }

        // 몬스터 공격 메서드
        public void AttackMonster(Monster monster)
        {
            // 몬스터 공격
            int damage = CalculateDamage();

            monster.TakeDamage(damage);

            if (!MonsterIsAlive(monster))
            {
                Console.WriteLine("몬스터가 죽었습니다!");
            }
        }

        // 몬스터 생존 여부 확인 메서드
        public bool MonsterIsAlive(Monster monster)
        {
            // 몬스터가 살아있는지 확인
            return monster.IsAlive;
        }

        // 공격력 계산 메서드
        private int CalculateDamage()
        {
            // 공격력 계산 로직을 필요에 맞게 수정
            // 여기서는 단순히 랜덤 값을 반환하도록 하였습니다.
            Random random = new Random();
            return random.Next(5, 15); // 5에서 15 사이의 랜덤한 값을 반환
        }
    }
}

