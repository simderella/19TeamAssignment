namespace _19teamGroupAssignment
{

    public class Character
    {

        public static Character instance;//싱글톤 //캐릭터를 어디서든 편하게접근하게 할 수 있게 만들어줄려고 싱글톤으로 만들어준거다.
                                         //캐릭터가 하나 뿐이라서 싱글톤가능, 



        public string Name { get; }
        public string Job { get; }
        public int Level { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Gold { get; set; }


        //Character클래스의 생성자
        public Character(string name, string job, int level, int atk, int def, int hp, int gold)
        {
            Name = name;
            Job = job;
            Level = level;
            StatsByJob(job);
            Hp = hp;
            Gold = gold;
            instance = this;//Character.instance로 접근하기 위해 public static Character instance;를 클래스 안에 만들어준다.

            //Item.cs에 있는 리스트 아이템을 넣어준다. 나중에 몬스터가 죽을때 myInventory에 아이템을 넣어줄 수 있다.
            Inventory.myInventory.Add(Item.itemList[0]);
            Inventory.myInventory.Add(Item.itemList[1]);

        }
        private void StatsByJob(string job)
        {
            // 직업에 따라 초기 공격력과 방어력 설정
            switch (job)
            {
                case "전사":
                    Atk = 15;
                    Def = 10;
                    break;
                case "궁수":
                    Atk = 12;
                    Def = 8;
                    break;
                case "도적":
                    Atk = 10;
                    Def = 5;
                    break;
                case "마법사":
                    Atk = 5;
                    Def = 5;
                    break;
                // 다른 직업에 대한 설정도 필요하면 추가
                default:
                    Atk = 10;
                    Def = 5;
                    break;
            }
        }


        //캐릭터에게 데미지를 받는 다는 개념을 주는코드
        public void TakeDamage(int damage)
        {
            Hp = Math.Max(0, Hp - damage);
        }
        //캐릭터의 생존을 알 수 있게 해주는 코드
        public bool IsAlive
        {
            get { return Hp > 0; }
        }
    }
}
