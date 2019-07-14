using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interviewQuestion
{
    class EnteryPoint
    {
        //basic function which recives a dynamic typed instance (which means the type will be decided in run time)
        //and prints the functions this instance can use based on its type
        public static void interview1(dynamic input)
        {
            dynamic checker;
            StringBuilder output = new StringBuilder();
            checker = input as C;
            if (checker != null)
            {
                output.Append("c1,c2");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
                return;
            }
            checker = input as B;
            if (checker != null)
            {
                output.Append("a1,a2,b1,b2");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
                return;
            }
            checker = input as A;
            if(checker != null)
            {
                output.Append("a1, a2");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
                return;
            }
            if (checker == null)
            {
                output.Append("none of these types :*");
                Console.WriteLine(output.ToString());
                Console.ReadKey();
                return;

            }
        }


        static void Main(string[] args)
        {
            A a=new B();
            interview1(a);
        }
    }
}
