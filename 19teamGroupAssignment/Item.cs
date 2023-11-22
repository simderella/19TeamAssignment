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

        //Item class의 생성자
        public Item (int partsId,  string name, string info, int atk, int def)
        {
            PartsId = partsId;
            Name = name;
            Info = info;
            Atk = atk;
            Def = def;
        }

        //아이템 DB
        //리스트 초기값을 지정해놓고 쓴다.
        public static List<Item> itemList = new List<Item>()
        {

            new Item(1, "무딘 검", "날이 많이 무딘 검이다.", 2, 0),
            new Item(2, "가죽 갑옷", "가죽으로 만들어진 갑옷이다.", 0, 3)

        };

    }
}
