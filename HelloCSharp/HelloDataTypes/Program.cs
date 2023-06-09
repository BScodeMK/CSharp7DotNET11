﻿using HelloCSharpSayHello.myClass;

namespace HelloDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Data Types!");
            Int32 myInt = 256;
            byte myByte = Convert.ToByte("255");
            bool myBool = false;
            string myString = "Boban";
            char myChar = 'B';
            DateTime myDate = DateTime.Now;
            Console.WriteLine("My int is: " +  myInt);
            Console.WriteLine("My byte is: " + myByte);
            Console.WriteLine("My Bool is: " + myBool);
            Console.WriteLine("My String is: " + myString);
            Console.WriteLine("My Char is: " + myChar);
            Console.WriteLine("My Date is: " + myDate);

            Class1 myClass = new Class1();
            myClass.MyProperty = 1;
            int mySecondInt = myClass.MyProperty;
            myClass.ShowMyInt();
        }
    }
}