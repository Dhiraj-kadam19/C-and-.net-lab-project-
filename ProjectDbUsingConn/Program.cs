using ProjectDbUsingConn.DataACESSlAYER_DAL_;
using ProjectDbUsingConn.model;

namespace ProjectDbUsingConn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bussiness layer

            int choice = 0;

            dac21context db = new dac21context();





            do
            {
                Console.WriteLine("1.select all Employee\n 2.UpdateEmployee 3.Delete Employee 4.Add Employee Enter a choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)

                {
                    case 1:
                        List<emp> emp = db.SelectRecords();
                        foreach (emp item in emp)
                        {
                            item.Displaydata();

                        }
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    case 5:
                        Console.WriteLine("Thank your for visiting");
                        break;


                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }




            } while (choice != 5);

















        }
    }
}
