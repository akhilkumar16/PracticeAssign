using System;
using System.Collections.Generic;
using System.Text;

namespace employeePractice
{
    public class Reverse
    {
        public void ReverseNumber()
        {
            int number, r, n1 = 0, i;
            Console.WriteLine(" enter a number ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = number; i != 0; i = i / 10)
            {
                r = i % 10;
                n1 = n1 * 10 + r;
            }
            Console.WriteLine(n1);
        }
    }
}
