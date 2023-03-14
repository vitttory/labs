using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _2lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            Ex3();
            Console.WriteLine();
        }
        static void Ex1()
        {
            List<string> lab = new List<string>();

            lab.Add("qw");
            lab.Add("er");
            lab.Add("ty");

            foreach (string s in lab)
            {
                Console.Write($"{s + " "}");
            }
            List<string> lab2 = new List<string>();
            Console.Write("\n");

            lab2.Add(lab[0]);

            for (int i = 1; i < lab.Count; i++)
            {
                lab2.Add(lab[i] + " " + lab2[i - 1]);
            }
            foreach (string s2 in lab2)
            {
                Console.WriteLine($" Новий список : {s2 + " "}");
            }
            Console.ReadKey();
        }
        static void Ex2()
        {
            Dictionary<int, string>[] dictionaries = new Dictionary<int, string>[]
            {
                new Dictionary<int, string>() { {1,"cats"}, {2,"parrots"}, {3,"dogs"} },
                new Dictionary<int, string>() { {1,"cats"}, {4,"parrots"}, {2,"dogs" } },
                new Dictionary<int, string>() { {1,"cats"}, {5,"parrots"}, {6,"dogs"} },
            };
            Console.WriteLine("Введіть ключ: ");

            int counter = 0; 
            int ToFindKey = int.Parse(Console.ReadLine());
            var dict = new List<string>();
            foreach (var dictionary in dictionaries)
            {
                foreach (var pair in dictionary)
                {
                    if (pair.Key == ToFindKey)
                    {
                        counter++;
                        dict.Add(pair.Value);
                    }
                }
            }
            Console.WriteLine(counter);
            foreach (var item in dict)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        static void Ex3()
        {
            List<string> list = new List<string>()
            {
                "Яка різниця – хто куди пішов?",
                "Хто що сказав, і рима вже готова",
                "Поезія – це свято, як любов",
                "О, то не є розмовка побутова!"
            };
            var symbols = (from l in list select l.Length%2==0? l[l.Length-1]:l[0]).ToList(); 
            var sorts = (from s in symbols orderby (int)s select s).ToList();
            foreach (var item in sorts)
            {
                Console.WriteLine(item + " " + (int)item);
            }
            Console.ReadKey();
        }
    }
}
