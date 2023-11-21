using _19teamGroupAssignment;
using RtanGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
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

//    public void StartBattle()
//    {
//        Console.WriteLine($"전투 시작! {player.Name} vs {monster.Name}");

//        while (player.IsAlive && monster.IsAlive)
//        {
//            DisplayBattleStatus();

//            // 플레이어의 턴
//            PlayerTurn();

//            // 몬스터의 턴
//            if (monster.IsAlive)
//            {
//                MonsterTurn();
//            }
//        }

//        BattleResult result;
//        if (player.IsAlive)
//        {
//            result = BattleResult.Victory;
//        }
//        else if (monster.IsAlive)
//        {
//            result = BattleResult.Defeat;
//        }
//        else
//        {
//            result = BattleResult.Escape;
//        }

//        DisplayBattleResult(result);
//    }
//    private void PlayerTurn()
//    {
//        Console.WriteLine($"{player.Name}의 턴");
//        Console.WriteLine("1. 일반 공격");
//        Console.WriteLine("0. 도망가기");

//        int choice = CheckValidInput(0, 2);

//        switch (choice)
//        {
//            case 1:
//                int playerDamage = CalculateDamage(player.Atk, monster.Def);
//                monster.TakeDamage(playerDamage);
//                Console.WriteLine($"{player.Name}이(가) {monster.Name}에게 {playerDamage}의 피해를 입혔습니다!");
//                break;


//            case 0:
//                Console.WriteLine($"{player.Name}이(가) 도망쳤습니다!");
//                DisplayBattleResult(BattleResult.Escape);
//                break;
//        }
//    }
//    public enum BattleResult
//    {
//        Victory,
//        Escape,
//        Defeat
//    }
//    private void DisplayBattleResult(BattleResult result)
//    {
//        switch (result)
//        {
//            case BattleResult.Victory:
//                Console.WriteLine("전투에서 승리했습니다!");
//                player.Gold += monster.Gold;
//                Console.WriteLine($"전리품으로 {monster.Gold} G를 획득했습니다.");
//                break;

//            case BattleResult.Escape:
//                Console.WriteLine("전투에서 도망쳤습니다...");
//                break;

//            case BattleResult.Defeat:
//                Console.WriteLine("전투에서 패배했습니다...");
//                break;
//        }

//int input = InputValidator.CheckValidInput(0, 1);

//switch (input)
//{
//case 0:
//    // 특수 기술 등을 사용할 수 있도록 구현
//    break;
//case 1:
//    Console.WriteLine("배틀시작");

//    // 플레이어가 몬스터를 공격하도록 호출
//    battle.AttackMonster(monster);

//    // 몬스터 생존 여부 확인
//    if (!battle.MonsterIsAlive(monster))
//    {
//        Console.WriteLine("몬스터가 죽었습니다!");
//    }

//    break;
//}
//    }
//}

