using System;
using System.Collections.Generic;
using System.Text;

namespace employeePractice
{
    class StringPalindrom
    {
        public void StringRev()
        {
            string name, rev;
            name = "akhil";
            char[] ch = name.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = name.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + name + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + name + " is not a Palindrome!");
            }
            Console.Read();
        }
    }
}
