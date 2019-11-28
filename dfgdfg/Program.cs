using System;

namespace dfgdfg
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)     //公鸡最多只能有19只
            {
                for (int j = 0; j < 33; j++)  //母鸡最多有32只
                {
                    if ((100 - i - j) % 3 == 0 && i * 5 + j * 3 + (100 - i - j) / 3 == 100)  //满足花一百块钱，鸡满一百只输出
                    {
                        Console.WriteLine("公鸡：{0},母鸡：{1},小鸡：{2}", i, j, 100 - i - j);
                    }
                }
            }

            Console.Read();
        }
    }
}