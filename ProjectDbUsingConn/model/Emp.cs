using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDbUsingConn.model
{
    public class emp

    {
        public int id { get; set; }
        public string name { get; set; }
        public string  adress { get; set; }


        public void Displaydata()
        {
            Console.WriteLine($"id={id},name={name},adress{adress}");
        }


    }
}
