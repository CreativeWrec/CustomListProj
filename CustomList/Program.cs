using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T>
            CustomList<int> myList = new CustomList<int>();

            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);

            myList.Remove(563);

            foreach(int number in myList)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }
    }
}
