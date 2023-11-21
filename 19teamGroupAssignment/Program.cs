using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using RtanGame;

namespace _19teamGroupAssignment
{


    internal class Program
    {
        static List<Monster> _monsters = new List<Monster>();

            static void GameDataSetting()
            {

                Random random = new Random();
                Monster[] choices =
                {
                    new Monster("미니언",2,5,15),
                    new Monster("공허충",3,9,10),
                    new Monster("대포미니언",5,8,25)
                };
            int monsterCnt = random.Next(1, 5); //랜덤으로 마리수 정하기 1~4 중 하나를 선택

            //List<Monster> list = new List<Monster>();
            //list.Add(new Monster("미니언", 2, 5, 15));
            //list.Add(new Monster("공허충", 5, 9, 10));
            //list.Add(new Monster("대포미니언", 5, 8, 25));

            Console.WriteLine("[몬스터 정보]");

                for (int i = 0; i < monsterCnt; i++) //마리수 정하기
                {
                     Monster monsterType = choices[random.Next(0, 3)];
                    Console.WriteLine($"Lv.{monsterType.Level} {monsterType.Name}  HP {monsterType.Hp}");
                    _monsters.Add(monsterType);   
                }
            }

        //private static void AddMonster(Monster monster)
        //{
        //    if (Monster.MonsterCnt == 4) return;
        //    _monsters[Monster.MonsterCnt] = monster;
        //    Monster.MonsterCnt++;
        //}
        static void BattleStart(Battle battle, Monster monster)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Battle!!");
            Console.ResetColor();
            Console.WriteLine();

            // 몬스터 정보
            Random random = new Random();
            Monster[] choices =
            {
                    new Monster("미니언",2,5,15),
                    new Monster("공허충",3,9,10),
                    new Monster("대포미니언",5,8,25)
                };
            int monsterCnt = random.Next(1, 5); //랜덤으로 마리수 정하기 1~4 중 하나를 선택

            //List<Monster> list = new List<Monster>();
            //list.Add(new Monster("미니언", 2, 5, 15));
            //list.Add(new Monster("공허충", 5, 9, 10));
            //list.Add(new Monster("대포미니언", 5, 8, 25));

            Console.WriteLine("[몬스터 정보]");

            for (int i = 0; i < monsterCnt; i++) //마리수 정하기
            {
                Monster monsterType = choices[random.Next(0, 3)];
                Console.WriteLine($"Lv.{monsterType.Level} {monsterType.Name}  HP {monsterType.Hp}");
                _monsters.Add(monsterType);
            }
            Console.WriteLine($"Lv.{monster.Level} {monster.Name} HP {monster.Hp}");

            Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");
            Console.WriteLine("1. 공격");
            int input = CheckValidInput(0, 1);

            switch (input)
            {
                case 0:
                    // 특수 기술 등을 사용할 수 있도록 구현
                    break;
                case 1:
                    Console.WriteLine("배틀시작");

                    // 플레이어가 몬스터를 공격하도록 호출
                    battle.AttackMonster(monster);

                    // 몬스터 생존 여부 확인
                    if (!battle.MonsterIsAlive(monster))
                    {
                        Console.WriteLine("몬스터가 죽었습니다!");
                    }

                    break;
            }
        }

        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
            }
        }
        static void Main(string[] args)
        {
            GameDataSetting();

            // Battle 인스턴스 생성 시 몬스터 배열을 전달
            Battle battle = new Battle(_monsters.ToArray());

            foreach (var monster in _monsters)
            {
                BattleStart(battle, monster);
            }
        }


    }
}
