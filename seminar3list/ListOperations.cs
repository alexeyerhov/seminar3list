using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace seminar3list
{
    public class ListOperations
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

        public void CountOfRepeats(List<int> list)
        {
                
                Dictionary<int,int> dict = new Dictionary<int,int>();
                
                foreach (var item in list)
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }
                    else
                    {
                        dict.Add(item, 1);
                    }
                }

                dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }
        }


        
    }
}
