namespace DemoDrink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public interface IDRINK
    {
        string getstring();
    }

    public class ColdDrink
    {
        public string getdrink()
        {
            return "Coca-cola";
        
        }
    }

    public class Hotdrink()
    {


        public string getdrink()
        {
            return "TEA";
        }
    
    }


}
