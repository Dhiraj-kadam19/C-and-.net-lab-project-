namespace UsingLinqMethodProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<emp> emps = new List<emp>()
            {
                new emp(){id=1,name="dhiraj",Adress="pune"},
                new emp(){id=2,name="kadam",Adress="pimpri"},
                  new emp(){id=3,name="kalpana",Adress="ravet" },
                    new emp(){id=4,name="anuj",Adress="sambhal"},
                      new emp(){id=5,name="ganesh",Adress="pimpri"},
                        new emp(){id=6,name="ramesh",Adress="pimpri"},
                          new emp(){id=7,name="kalam",Adress="sarasa"},
                            new emp(){id=8,name="naru",Adress="parve"}

            };

            //here all emp data print because the data get fire the query of all emp thats why call here 

            //var result = (from emp in emps select emp);

            //foreach (emp emp in result)
            //{
            //    emp.Dispalaydata();
            //}

            var result = emps.ToList();
            Console.WriteLine(result);
            var result1 = (from emp in emps
                          where emp.name == "kalam"
                          select emp
                          );

            foreach (emp emp in result1)
            {
                emp.Dispalaydata();
            }

        }
    }

   public class emp
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Adress { get; set; }


        public void Dispalaydata()
        {
            Console.WriteLine($"id={id} ,name={name},adress{Adress}");
        }
    }
}
