namespace UseSetGetMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo demo = new Demo();
            demo.WrapperMethod();

            HR hr = new HR();
            hr.Display();
        }
    }

    public class Person
    {
        public virtual string Name { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Person : Display");
        }
    }
    public sealed class Employee : Person
    {
        public override string Name { get => base.Name; set => base.Name = value; }
        public override void Display()
        {
            Console.WriteLine("Employee: Display");
        }
    }
    // this class is not override because the employee class is sealed that why the 
    //other mehtod and objecte is not created that time that  why the ehen you relese the sealed clss then the 
    //this hr method or clsss is working

    //public  class HR : Employee
    //{
    //    public override string Name { get => base.Name; set => base.Name = value; }
    //    public override void Display()
    //    {
    //      Console.WriteLine("HR: Display");

    //    }
    //    public void EmpData()
    //    {
    //        base.Display();
    //        Console.WriteLine("EmpData: HR");
    //    }
    }
    public  sealed class Demo //: String //:HR
    {
        public void WrapperMethod()
        {
            HR obj = new HR();
            obj.EmpData();
        }
    }



}
    

    
   

    
    