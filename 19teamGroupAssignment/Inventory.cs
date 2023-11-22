namespace _19teamGroupAssignment
{
    public class Inventory
    {
        //필드란 무언가 = 데이터 저장
        //메서드는 행동
        //데이터를 저장할 필드 myInventory
        public static List<Item> myInventory = new List<Item>();//객체(new라는 키워드)를 생성해서 실질적으로 활용 가능한 상태로 만든다.


        public static void DisplayMyInventory()
        {
            Console.Clear();

            Console.WriteLine("인벤토리-장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            //나의 인벤토리 안에 있는 아이템 보여주기
            for (int i = 0; i < myInventory.Count;/*인벤토리 길이만큼*/ i++)
            {
                Console.Write("- ");
                Console.Write(myInventory[i].Name);
                Console.Write(" l ");
                if (myInventory[i].Atk > 0)
                {

                    Console.Write($"공격력 + {myInventory[i].Atk}");
                }

                if (myInventory[i].Def > 0)
                {
                    Console.Write($"방어력 + {myInventory[i].Def}");
                }
                Console.Write(" l ");
                Console.Write(myInventory[i].Info);
                Console.WriteLine();
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기");

            int input = InputValidator.CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    GameIntro.DisplayMain();
                    break;
            }


        }





    }
}
