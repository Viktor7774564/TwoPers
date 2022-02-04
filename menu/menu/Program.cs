using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите В");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Выберите одну из операций");
            Console.WriteLine("1 - выполнить операцию “+”");
            Console.WriteLine("2 - выполнить операцию “-”");
            Console.WriteLine("3 - выполнить операцию “*”");
            Console.WriteLine("4 - выполнить операцию “/”");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n) 
            {
                case 1:
                    Console.WriteLine(a+b);
                    break;
                case 2:
                 
                    break;
                case 3:
                   
                    break;
                case 4:
                   
                    break;
            }
        }
    }
}
