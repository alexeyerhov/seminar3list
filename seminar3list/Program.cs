using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar3list
{


    internal class Program
    {
        static void Main(string[] args)
        {
            // Убрать повторяющиеся числа из списка

            List<int> ints = new List<int>() { 5, 7, 9, 5, 6, 8, 9, 9, 0, 5 };

            new ListOperations().DeleteRepeatsAndPrint(ints);

            Console.WriteLine();

            new ListOperations().DeleteRepeatsAndPrint2(ints);

            

            /*Дан список целых числен, в котором числа повторяются. Необходимо
             * вывести на экран список числен, расположив их в порядке
             * возрастания частоты повторения */

            List<int> ints2 = new List<int>() { 1, 1, 2, 2, 3, 4, 5, 5, 6, 7, 7, 8 };

            new ListOperations().CountOfRepeats(ints2);

            Console.Read();
        }
    }
}
