using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3list
{

    public class OperationsWithList
    {
        public void DeleteRepeatsAndPrint(List<int> list)
        {
            List<int> list2 = new List<int>();


            foreach (var item in list)
            {
                if (!list2.Contains(item))
                {
                    list2.Add(item);
                }
            }
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }
        }

        public void DeleteRepeatsAndPrint2(List<int> list)
        {
            list.Distinct().ToList().ForEach(x => Console.WriteLine(x));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> ints = new List<int>() { 5, 7, 9, 5, 6, 8, 9, 9, 0, 5 };

            new OperationsWithList().DeleteRepeatsAndPrint(ints);

            Console.WriteLine();

            new OperationsWithList().DeleteRepeatsAndPrint2(ints);

            Console.Read();

        }
    }
}
