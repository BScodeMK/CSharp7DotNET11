using HelloCSharpSayHello.myClass;

namespace HelloCSharpSayHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName = Console.ReadLine();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hello My name is Boban");
            Console.Write("Hello");
            Console.Write(" my name is " + myName);

            Class1 myClass1 = new Class1();
        }
    }
}