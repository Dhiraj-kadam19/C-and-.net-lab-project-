using System.Xml.Serialization;
using static Dem0swirchOop.myserver;

namespace Dem0swirchOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myserver data = new myserver();
            data.insert();
            data.update();
            oracalServer data1 = new oracalServer();

            while (true) {

                Console.WriteLine("Choose your database\n 1.Mysqlserver \n 2.OraycalSrever");
                int Dchoice = Convert.ToInt32(Console.ReadLine());
            
            }
        }
        



    }
    public class myserver
    {
        public myserver()
        {
            Console.WriteLine("default construtor is created");
        }
        public void insert()
        {

            Console.WriteLine("insert dtada in mysql data base");
            Console.WriteLine();

        }
        public void delete()
        {
            Console.WriteLine("DELETE THE DATA IN MYSQL DATA BASE");
            Console.WriteLine();
        }
        public void update()
        {
            Console.WriteLine("update mydata in mysql data base");
            Console.WriteLine();

        }

        public class oracalServer {

            public void insert()
            {
                Console.WriteLine("INSERT DATA IN ORCAL DATA BASE");
                Console.WriteLine();

            }

            public void delete()
            {
                Console.WriteLine("delete data in oracle database");
                    Console.WriteLine();

                
            }
            public void update() {

                Console.WriteLine("uppdate data in oracl server");
                Console.WriteLine();
            
            }
        }
    }

}
