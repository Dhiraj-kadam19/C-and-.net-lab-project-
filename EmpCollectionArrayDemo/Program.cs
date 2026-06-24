using System.Xml.Serialization;

namespace EmpCollectionArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp emp1 = new Emp();
            emp1.pid = 1;
            emp1.pname = "kadam";
            emp1.city = "pune";
            emp1.dept = "mechanical";

           Emp emp2 = new Emp();    
            emp2.pid = 2;
            emp2.pname = "dhiraj";
            emp2.city = "latur";
            emp2.dept = "freedom";

            Emp emp3 = new Emp();
            emp3.pid = 3;
            emp3.pname = "ram";
            emp3.city = "upbihar";
            emp3.dept = "computer";



            Emp[] emps = new Emp[3]; 
            emps[0]=emp1;
            emps[1]=emp2;
            emps[2]=emp3;

            for (int i = 0; i < emps.Length; i++)
            {
                emps[i].getemployeedetails();
            }
        }
    } 
    public class Emp
    {
        private int     _Pid;
        private string _Pname;
        private string _City;
        private string  _Dept;

        public int pid
        {
            get { return _Pid; }
            set { _Pid  = value; }
        }

        public string pname
        {
            set { _Pname = value; }
            get { return _Pname; }
        }
        public string city
        {
            set { _City = value; }
            get { return _City; }
        }
        public string dept
        {

            set { _Dept = value; }
            get { return _Dept; }
        }

        public void getemployeedetails()
        {
            Console.WriteLine($"pid:{pid}, pname:{pname} ,city:{city} ,dept:{dept}");
        }
    }
}
