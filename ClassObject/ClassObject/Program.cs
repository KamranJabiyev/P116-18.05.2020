using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //string[] arr = { "Tural", "Elgun", "Miryasin","Elshen" };
            //Console.WriteLine(JoinStr(arr));

            //Console.WriteLine(ReverseStr("Salam Qrup Gencleri"));

            //string[] words1 = { "Elnur","Elgun","Elshen","Ulvi","Tural"};
            //string[] words2 = { "Hesen", "Elgun", "Ferid","Tural", "Elshen" };
            //SameWord(words1, words2);
            #endregion

            //instance almaq
            //Person p1 = new Person();
            //p1.Name = "Kamran";
            //p1.Surname = "Jabiyev";
            //p1.Age = 30;

            //Person p2 = new Person();
            //p2.Name = "Ulvi";
            //p2.Surname = "Mecidov";
            //p2.Age = 25;

            //p1.GetFullInfo();
            //p2.GetFullInfo();

            //Console.WriteLine($"{p1.Name} {p1.Surname} {p1.Age}");
            //Console.WriteLine($"{p2.Name} {p2.Surname} {p2.Age}");

            //Developer d1 = new Developer("Kamran", "Jabiyev");
            //d1.Name = "Elshen";
            //d1.Surname = "Esgerov";
            //d1.Age = 36;
            //d1.Experience = 5;
            //d1.Knowledge = new string[3] { "C#", "Javascript", "TypeScript" };
            //Console.WriteLine(d1.GetFullName());


            //Person p3 = new Person();
            //p3.Name = "Hesen";
            //p3.Surname = "Hesenli";
            //p3.Age = 25;

            //Person p4 = new Person("Orxan", "Memmedli",30);

            //Console.WriteLine(p3.GetFullInfo());
            //Console.WriteLine(p4.GetFullInfo());

            var stu = new
            {
                Name="Kamran",
                Surname="Jabiyev",
                Age=30
            };
            
            Console.WriteLine(stu.Name);

            var x = 10;
            //x-in tipi int
            x = 100;

            dynamic y = 10;
            y = true;
            y = "Kamran";
            y = 'a';
        }

        #region Homework
        //Task 1
        static StringBuilder JoinStr(string[] arr)
        {
            StringBuilder result = new StringBuilder();
            foreach (string item in arr)
            {
                result.Append(item);

                if(arr[arr.Length-1]!=item)
                    result.Append(",");
            }

            return result;
        }

        //Task 2
        static StringBuilder ReverseStr(string sentence)
        {
            StringBuilder result = new StringBuilder();
            string[] arr = sentence.Split(' ');
            foreach (string word in arr)
            {
                for (int i = word.Length-1; i >=0; i--)
                {
                    result.Append(word[i]);
                }

                if (arr[arr.Length - 1] != word)
                    result.Append(' ');
            }
            return result;
        }

        //Task 3
        static string[] SameWord(string[] arr1,string[] arr2)
        {
            string[] result = new string[0];
            foreach (string word1 in arr1)
            {
                foreach (string word2 in arr2)
                {
                    if (word1==word2)
                    {
                        Array.Resize(ref result,result.Length+1);
                        result[result.Length - 1] = word1;
                    }
                    
                }
            }
            return result;
        }
        #endregion
    }
}
