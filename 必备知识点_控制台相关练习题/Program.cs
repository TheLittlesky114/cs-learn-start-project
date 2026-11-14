namespace 必备知识点_控制台相关练习题
{
    internal class Program
    {
        //1.如何打断点 F9
        //2.如何一步一步看代码逻辑 F10
        //3.继续执行 停止一步一步看 F5

        //4.可以通过监视窗口查看想要得到的变量的值

        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(100, 30);
            Console.SetBufferSize(100, 30);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            int x = 0, y = 0;
            while (true)
            {
                //第一种清空之前信息的方式
                //Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                char c = Console.ReadKey(true).KeyChar;
                //把之前的方块擦除
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                switch (c)
                {
                    case 'W':
                    case 'w':
                        y--;
                        break;
                    case 'S':
                    case 's':
                        y++;
                        break;
                    case 'A':
                    case 'a':
                        //中文符号 在控制台上占2个位置
                        x -= 2;
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        break;
                }
                if (x < 0)
                {
                    x = 0;
                }
                if (x > Console.BufferWidth - 2)
                {
                    x = Console.BufferWidth - 2;
                }
                if (y < 0)
                {
                    y = 0;
                }
                if (y > Console.BufferHeight - 1)
                {
                    y = Console.BufferHeight - 1;
                }
            }
        }
    }
}
