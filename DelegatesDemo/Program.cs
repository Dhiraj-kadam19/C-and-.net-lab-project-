namespace DelegatesDemo
{
    public delegate int Mydelegate(int P, int Q);
    internal class Program
    {
        static void Main(string[] args)
        {
            Cmath m1 = new Cmath();
            m1.multiply(10, 20);
            Mydelegate add = new Mydelegate(m1.add);
            int addresult = add(20, 10);
            Console.WriteLine(addresult);
            Mydelegate del = new Mydelegate(m1.subtract);
            Console.WriteLine($"subtract={del(20, 10)}");

        }
    }

    public class Cmath
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int subtract(int x, int y)
        {
            return x - y;
        }
        public int multiply(int x, int y)
        {
            return x * y;
        }
        public int Divide(int x, int y)
        {
            return x / y;
        }
    }

}