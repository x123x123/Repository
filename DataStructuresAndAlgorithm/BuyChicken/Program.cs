using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyChicken
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 100; a++)  //a公鸡数量
                for (int b = 0; b <= 100; b++)  //b母鸡数量
                    for (int c = 0; c <= 100; c++)  //c小鸡数量
                        if ((a + b + c) == 100 && (a * 5 + b * 3 + c / 3) == 100 && c % 3 == 0)
                            Console.WriteLine("公鸡{0}只,母鸡,{1}只，小鸡{2}\n", a, b, c);//
            Console.ReadLine();
        }
    }
}




