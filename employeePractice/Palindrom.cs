using System;
using System.Collections.Generic;
using System.Text;

namespace employeePractice
{
    class Palindrom
    {
        public void NumberPalindrom()
        {
            int number, n1, r = 0, remider;
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());
            n1 = number;
            while (number > 0)
            {
                remider = number % 10;
                r = r * 10 + remider;
                number = number / 10;
            }
            if (r == n1)
            {
                Console.WriteLine("its a palindrom");
            }
            else
            {
                Console.WriteLine("not palindrom");
            }
        }
    }
}
