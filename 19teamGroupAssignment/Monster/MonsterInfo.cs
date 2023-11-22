using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19teamGroupAssignment
{
    internal class MonsterInfo
    {
        static List<Monster> _monsters = new List<Monster>();

        public static void GameDataSetting()
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
            int monsterCnt = random.Next(1, 5);

            for (int i = 0; i < monsterCnt; i++) //마리수 정하기
            {
                Monster monsterType = choices[random.Next(0, 3)];
                Console.WriteLine($"Lv.{monsterType.Level} {monsterType.Name}  HP {monsterType.Hp}");
                _monsters.Add(monsterType);
            }
            Console.WriteLine($"Lv.{monster.Level} {monster.Name} HP {monster.Hp}");

            Console.WriteLine("원하시는 행동을 입력해주세요. \n >>");
            Console.WriteLine("1. 공격");
        }
    }
}

