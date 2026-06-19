using System.Security.Cryptography.X509Certificates;

namespace CmathLibary1
{

    public class cmath
    {
        public void Addition(int x, int y)
        {
            Console.WriteLine("$ add={X+Y}");
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("$ sub={x-y}");
        }

        private void mul(int x, int y)
        {
            Console.WriteLine("$ mul={x*y}");
        }
    }

    public class demo
    {
        public void wrappermethod()
        {
            //multipliction method is not bounded because the multiplication method is private
            cmath obj = new cmath();
            Console.WriteLine("PRINTING DATA IN THE WRAPPER  METHOD DEMO");
            obj.sub(5, 1);
            obj.Addition(5, 2);

            Console.WriteLine("$ sub={5,1} ");

        }





        public class myclass : cmath
        {
            public void Warraperclass()
            {
                Console.WriteLine("print the myclass wrapper class");
                myclass dtd= new myclass();
                dtd.Addition(5, 1);
                dtd.sub(5, 2);
            }


        }

    }

}


