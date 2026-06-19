using System.Security.Cryptography.X509Certificates;

namespace MultiDeligatePattern
{
    public delegate void multipledekigate();
    internal class Program
    {
        static void Main(string[] args)
        { 
            Annulfunction anu = new Annulfunction();
            multipledekigate handler = new multipledekigate(anu.WELCOME);
            handler += anu.WELCOME;
            handler += anu.guest;
            handler += anu.dance;
            handler += anu.by;

        Console.WriteLine("Hello, World!");
        }
    }
    public class Annulfunction
    {
        public void WELCOME()
        {
            Console.WriteLine("welcome to the functoin");

        }
        public void hostspeech()
        {
            Console.WriteLine("Host:speeech is declare");

        }
        public void guest()
        {
            Console.WriteLine("guset speech here  than");
        }
        public void dance()
        {
            Console.WriteLine("danse :xxxxxxnxxxxxxxxxxxn");
        }
        public void by()
        {
            Console.WriteLine("by by function is over");
        }
        public void packup()
        {
            Console.WriteLine("pack the all light,dinner ,etc");
        }
    }
}
