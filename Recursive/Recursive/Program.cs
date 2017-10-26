using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObjectArray
{
    class Program
    {
        static void Main()
        {
            object[] objectArray = new object[4];
            objectArray[0] = 101; // integer
            objectArray[1] = "C#"; // string
            Customer c = new Customer();
            c.ID = 99;
            c.Name = "Pragim";
            c.Add = "hyd";
            objectArray[2] = c;
            // loop thru the array and retrieve the items
            foreach (object obj in objectArray)
            {
                Console.WriteLine(obj);
            }
            Console.ReadLine();
        }
    }
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Add { get; set; }
        public override string ToString()
        {
            return String.Format("{0} \n {1}", Name, Add);

        }

    }
}