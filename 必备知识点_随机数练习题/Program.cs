namespace 必备知识点_随机数练习题
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int atk = 0;
            int def = 10, hp = 20;
            while (hp > 0)
            {
                atk = r.Next(8, 13);
                if (atk > def)
                {
                    hp -= atk - def;
                    Console.WriteLine("攻击力为{0}，小怪兽受到{1}点伤害，怪物血量为{2}", 
                        atk, atk - def, hp);
                    if (hp <= 0)
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("攻击力为{0}，小怪兽未受到伤害", atk);
                }
                Console.WriteLine("按任意键继续攻击");
                Console.ReadKey(true);
                Console.Clear();
            }
            Console.WriteLine("小怪兽已死亡");
        }
    }
}
