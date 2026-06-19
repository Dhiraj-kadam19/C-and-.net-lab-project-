using CLassLibrary;

namespace ADDITION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); 

             Class1 class1 = new Class1();
           int result= class1.addition(4,3);
            Console.WriteLine("print the addition "+result);
        }
    }
}
