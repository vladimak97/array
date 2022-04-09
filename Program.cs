using System;
using System.Collections.Generic;
using System.Linq;
namespace KotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string testString = "cat dog fish bird";

            string[] arrayOfS = testString.Split(",");

            Dictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();

            foreach (string aa in arrayOfS)
            {
                if (dictionary.ContainsKey())
                {
                    List<string> list = dictionary[key];
                    list.Add(word);
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add(word);
                    dictionary.Add(key, list);
                }
            }
        }

        foreach(KeyValuePair<int, List<string>> kv in Dictionary)
            {
            Console.WriteLine(KeyValuePair.Key);
            foreach(String word in kv.Value)
            {
            Console.WriteLine(word);
            }

    foreach(string wor in words)
        {
        Console.WriteLine(Words.ToUpper());
        }

words.Select(x => x.ToUpper()).TToList().ForEach(x => Console.WriteLine(x));

int[] intTable = { 4, 2, 6, 2, 1, 5, 7, 2, 34, 6 };


Console.WriteLine("------------------");


intTable.Select(x => x * 2).ToList().ForEach(x => Console.WriteLine(x));

intTable.Where(item => item % 2 == 0).ToList().ForEach(item => Console.WriteLine(item));

intTable.Where(item => item > 4).Select(item => item * item).OrderByDescending(item => item);

           arrayOfS.GroupBy(item => item.Length);
         
         }
      }
   }

 




