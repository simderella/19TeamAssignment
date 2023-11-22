namespace _19teamGroupAssignment
{
    public class Item
    {

        

        public int Parts { get; } // 검을 끼면 다른 아이템이 안껴져서 아이템 ID를 생성하여 검도 끼고 갑옷도 입을 수 있게 해줍니다.
        public string Name { get; }
        public string Info { get; }
        public int Atk { get; }
        public int Def { get; }

        //Item클래스의 생성자
        public Item(int parts, string name, string info, int atk, int def)
        {
            Parts = parts;
            Name = name;
            Info = info;
            Atk = atk;
            Def = def;
        }
        
        //장비아이템 착용여부
        //아이템 해제


        //아이템 DB를 여기다가 만들어주면 된다.
        //몬스터가 사망할 때 itemDB를 캐릭터한테 준다.
        public static List<Item> itemDB = new List<Item>
        {
            new Item(1, "철 검", "날이 선 철검이다.", 8, 0),

        };

    }

    
}
