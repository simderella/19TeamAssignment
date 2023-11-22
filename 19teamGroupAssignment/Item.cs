namespace _19teamGroupAssignment
{
    public class Item
    {
        //Item 프로퍼티 생성
        public int PartsId { get; } // 부위별 아이템 중복 방지를 위해 추가
        public string Name { get; }
        public string Info { get; }
        public int Atk { get; }
        public int Def { get; }
        public bool IsEquip { get; set; }

        //Item class의 생성자
        public Item(int partsId, string name, string info, int atk, int def, bool isEquip = false)
        {
            PartsId = partsId;
            Name = name;
            Info = info;
            Atk = atk;
            Def = def;
            IsEquip = isEquip;//장착관리를 위해 추가
        }

        //아이템 DB
        //리스트 초기값을 지정해놓고 쓴다.
        public static List<Item> itemList = new List<Item>()
        {

            new Item(1, "무딘 검", "날이 많이 무딘 검이다.", 2, 0),
            new Item(2, "가죽 갑옷", "가죽으로 만들어진 갑옷이다.", 0, 3)

        };


        //itemList가 있는 곳에 만들어줘야되는 이유???????????????????
        public void InvenItemList(bool withNumber = false, int idx = 0)
        {
            Console.Write("- ");
            // 장착관리 전용
            if (withNumber)
            {
                Console.Write("{0} ", idx);
            }
            if (IsEquip)
            {
                Console.Write("[E]");
                Console.Write(InputValidator.PadRightForMixedText(Name, 9));
                //IsEquip가 true일 때 Character의 공격과 방어에 값을 더해줌
                Character.instance.Atk += Atk;
                Character.instance.Def += Def;
            }
            else Console.Write(InputValidator.PadRightForMixedText(Name, 12));

            Console.Write(" | ");
            if (Atk > 0)
            {

                Console.Write($"공격력 + {Atk}");
            }
            if (Def > 0)
            {
                Console.Write($"방어력 + {Def}");
            }
            Console.Write(" | ");
            Console.WriteLine($"{Info}");
        }


        

    }
}
