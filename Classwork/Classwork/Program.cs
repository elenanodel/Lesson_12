using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Classwork
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number: ");
            int size = int.Parse(Console.ReadLine());
            Random rand = new Random();

            List<int> numList = new List<int>();
            fillList(numList, size);            

            Console.Write("Elements from your List are: ");
            printList(numList);

            //List<int> numList = new List<int>();
           // numList.Add(1);
            //numList.Add(8);
            //numList.Add(4);
            //numList.Add(2);

            /*LinkedList<int> numList = new LinkedList<int>();
            numList.AddFirst(1);
            numList.AddLast(8);
            numList.AddLast(3);
            numList.RemoveLast();


            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            // numList.Remove(4);
            //numList.RemoveAt(0);


            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            /* int f = 6;
             int h = 5;
             Inc(ref f, ref h);

             Console.Write(Inc(ref f, ref h));

             /*string path = "";
             string text;
             Console.Write("Enter name of file: ");
             path = Console.ReadLine();

             Console.Write("Enter text: ");
             text = Console.ReadLine();

             writeToFile(text, path);

             bool choice = true;
             do
             {
                 Console.WriteLine("Do you want to continue?");
                 Console.WriteLine("1 - Yes");
                 Console.WriteLine("2 - No");
                 char a = char.Parse(Console.ReadLine());

                 switch (a)
                 {
                     case '1':
                         {
                             Console.Write("Please, enter your text: ");
                             text = Console.ReadLine();
                             writeToFile(text, path, true);
                             break;
                         }
                     case '2':
                         {
                             choice = false;
                             break;
                         }
                 }

             } while (choice);

             /*if (path.Length == 0)
             {
                 writeToFile(text);
             }
             else
             {
                 writeToFile(text, path);
             }*/

            Console.ReadLine();
        }

        static void writeToFile(string text, string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(text);
            sw.Close();
        }

        static void writeToFile(string text)
        {
            string path = "default.txt";
            writeToFile(text, path);
        }

        static void writeToFile(string text, string path, bool choice)
        {
            StreamWriter sw = new StreamWriter(path, choice);
            sw.WriteLine(text);
            sw.Close();
        }

        static int Inc (ref int in1)
        {
            in1++;
            return 1;
        }
        static int Inc(ref int in1, ref int in2)
        {
            in1++;
            in2++;
            return 2;
        }
        static int Inc(ref int in1, ref int in2, ref int in3)
        {
            in1++;
            in2++;
            in3++;
            return 3;
        }

        static void fillList(List<int> list, int size)
        {
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                list.Add(rand.Next(50));
            }
        }

        static List<int> printList(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            return new List<int>();
        }
    }
}
