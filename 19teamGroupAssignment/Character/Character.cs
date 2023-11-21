namespace _19teamGroupAssignment
{
    
    public class Character
    {
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
    }
}