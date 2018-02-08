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

			obj.OutputList(obj.lineList);
		
			obj.CheckType(obj.lineList, obj.IntList, obj.DoubleList, obj.NotNum);
             
            Console.WriteLine("Number of integers: " + obj.IntList.Count);
            Console.WriteLine("Number of doubles: " + obj.DoubleList.Count);
            Console.WriteLine("Number of others: " + obj.NotNum.Count);
			obj.OutputList(obj.DoubleList);
			Console.WriteLine(obj.AverageInt(obj.IntList));
			Console.WriteLine(obj.AverageDouble(obj.DoubleList));
            obj.RightFormatOutputInt(obj.IntList);
			obj.RightFormatOutputDouble(obj.DoubleList);
			obj.NotNumSort(obj.NotNum);
			//obj.OutputList(obj.NotNum);

		}
    }
}
