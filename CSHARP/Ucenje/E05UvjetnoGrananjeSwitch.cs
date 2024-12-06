using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E05UvjetnoGrananjeSwitch
    {


        public static void Izvedi()
        {

            // Console.WriteLine("e05");

            int i = 2;

            switch (i)
            {
                case 1:
                    Console.WriteLine("nedovoljan");
                    break;
                case 2:
                    Console.WriteLine("dovoljan");
                    break;
                default:
                    Console.WriteLine("ostalo");
                    break;

            }



            char znak = '@';
            Console.WriteLine("znak");
            Console.WriteLine((int)znak);



        }
    }
}
