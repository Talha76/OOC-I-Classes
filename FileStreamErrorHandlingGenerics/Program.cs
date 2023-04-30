using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamErrorHandlingGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /******* Generic Demo ************/
            //List<int> list = new List<int>();
            //list.Add(1); list.Add(3); list.Add(2);

            //DynamicArray<int> dynArray = new DynamicArray<int>(list);
            //for (int i = 0; i < 3; i++)
            //    Console.WriteLine(dynArray.getElement(i));

            /********** Error handling **********/
            //DynamicArray<int> array = new DynamicArray<int>();

            //try
            //{
            //    Console.WriteLine("Before Pop.");
            //    Console.WriteLine(array.Pop());
            //    Console.WriteLine("After Pop");
            //}
            //catch (Exception ex) { Console.WriteLine(ex.Message); }

            /********** File Stream Read/Write *************/
            //using (StreamReader sr = new StreamReader("E:/OOC-I-Classes/README.md"))
            //{
            //    while (!sr.EndOfStream) { Console.WriteLine(sr.ReadLine()); }
            //    sr.Close();
            //}

            using (StreamWriter sr = new StreamWriter("E:/OOC-I-Classes/written.txt"))
            {
                sr.WriteLine("This is a new file.");
                sr.Close();
            }

            using (StreamReader sr = new StreamReader("E:/OOC-I-Classes/written.txt"))
            {
                while (!sr.EndOfStream) Console.WriteLine(sr.ReadLine());
                sr.Close();
            }
        }
    }
}
