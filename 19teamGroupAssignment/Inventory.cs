using System.Xml.Linq;

namespace _19teamGroupAssignment
{
    public class Inventory
    {
        //필드란 무엇인가 = 데이터 저장
        //메서드는 행동
        //데이터를 저장할 필드 myInventory
        public static List<Item> myInventory = new List<Item>();//객체(new라는 키워드)를 생성해서 실질적으로 활용 가능한 상태로 만든다.
        static int i ; //임시 지정

        //인벤토리 화면
        public static void DisplayMyInventory()
        {
            Console.Clear();

            Console.WriteLine("■인벤토리■");
            Console.WriteLine("");

            Console.WriteLine("보유 중인 아이템을 볼 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            //나의 인벤토리 안에 있는 아이템 보여주기
            for (int i = 0; i < myInventory.Count;/*인벤토리 길이만큼*/ i++)
            {
                myInventory[i].InvenItemList();
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("");

            Console.WriteLine("1. 장착관리");

            int input = InputValidator.CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    GameIntro.DisplayMain();
                    break;
                case 1:
                    DisplayEquip();
                    break;
            }


        }
        //인벤토리에서 장착화면
        public static void DisplayEquip()
        {
            Console.Clear();

            Console.WriteLine("■인벤토리 - 장착관리■");
            Console.WriteLine("");

            Console.WriteLine("보유 중인 아이템을 장착할 수 있습니다.");

            Console.WriteLine("");
            Console.WriteLine("[아이템 목록]");
            Console.WriteLine("");

            //나의 인벤토리 안에 있는 아이템 보여주기
            for (int i = 0; i < myInventory.Count;/*인벤토리 길이만큼*/ i++)
            {
                myInventory[i].InvenItemList(true, i + 1);
            }

            Console.WriteLine("");
            Console.WriteLine("0. 나가기");

            int input = InputValidator.CheckValidInput(0, myInventory.Count);
            switch (input)
            {
                case 0:
                    DisplayMyInventory();
                    break;
                default:
                    ToggleEquipStatus(input - 1);
                    DisplayEquip();
                    break;
            }
        }
        //아이템 장착여부를 바꿔줌
        //bool값에서 값을 반대로 만들어주는 걸 Toggle이라고한다.
        static void ToggleEquipStatus(int idx)
        {
            Item.itemList[idx].IsEquip = !Item.itemList[idx].IsEquip;
        }


    }
}
