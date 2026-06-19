using System.Collections;
using System.ComponentModel;

namespace ArrylistDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[4];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }


            string[] days = new string[5];
            days[0] = "Mon";
            days[1] = "Tue";
            days[2] = "Wed";
            days[3] = "Thu";
            days[4] = "Fri";

            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }

        }
    }
}