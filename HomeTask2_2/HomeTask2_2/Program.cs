using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LineWork obj = new LineWork();
            string yes = " ";
            do
            {
               

                obj.AddLineToArr(obj.InsertString());
                
                Console.WriteLine("Continue?(y/any)");
                yes = Console.ReadLine();

            } while (yes == "y");
            obj.CheckType(obj.lineList, obj.IntList, obj.DoubleList, obj.NotNum);
             
            Console.WriteLine("Number of integers: " + obj.IntList.Count);
            Console.WriteLine("Number of doubles: " + obj.DoubleList.Count);
            Console.WriteLine("Number of others: " + obj.NotNum.Count);
            Console.WriteLine(obj.AverageInt(obj.IntList));
            Console.WriteLine(obj.AverageDouble(obj.DoubleList));
            obj.RightFormatOutputInt(obj.IntList);
            
        }
    }
}
