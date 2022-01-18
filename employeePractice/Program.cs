using employeePractice;
using System;
public class program
{ 
    public static void Main()
    {
        //Console.WriteLine(" program of fibannoci number");
        //Fibonnaci obj = new Fibonnaci();
        //obj.Fib();
        //Reverse a = new Reverse();
        //a.ReverseNumber();
        Palindrom b = new Palindrom();
        b.NumberPalindrom();
    //}
}
public class Fibonnaci
{
    public void Fib()
    {
        int number,n1 = 0, n2 = 1, n3;
        Console.WriteLine(" enter a number");
        number = Convert.ToInt32(Console.ReadLine());
        if(number == 0)
        {
            Console.WriteLine("please enter numbers from 2");
            return;
        }
        if(number==1)
        {
            Console.WriteLine("please enter numbers from 2");
            return;
        }
        Console.WriteLine(n1);
        Console.WriteLine(n2);
        for (int i = 3; i <= number; i++)
        {
            n3 = n1 + n2;
            Console.WriteLine(n3);
            n1 = n2;
            n2 = n3;
        }
    }
}