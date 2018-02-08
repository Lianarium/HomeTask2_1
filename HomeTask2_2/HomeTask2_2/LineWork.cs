using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace HomeTask2_2
{
    class LineWork
    {
        public LineWork()
        {
            lineList = new ArrayList();
            IntList = new ArrayList();
            DoubleList = new ArrayList();
            NotNum = new ArrayList();

        }

        public ArrayList lineList;
        public ArrayList IntList;
        public ArrayList DoubleList;
        public ArrayList NotNum;

        public string InsertString()
        {
            Console.WriteLine("Enter new line:");
            string line = Console.ReadLine();
            return line;
        }

        public void AddLineToArr(string line)
        {
            this.lineList.Add(line);
        }

        public void OutputList(ArrayList obj)
        {
            foreach (var item in obj)
                Console.WriteLine(item+"*");
        }

        public void CheckType(ArrayList obj1, ArrayList obj2, ArrayList obj3, ArrayList obj4)
        {
            int integer;
            double doublenum;

            foreach (string item in obj1)
            {

                if (int.TryParse(item, out integer))
                    obj2.Add(integer);
                else if (double.TryParse(item, out doublenum))
                    obj3.Add(doublenum);
                else obj4.Add(item);


            }
            
        }

        public string AverageInt(ArrayList obj)
        {
            int sum=0;
            foreach(int item in obj)
            {
                sum += item;
            }

            return (sum/obj.Count).ToString();

        }


        public int DigitsAfterComma(double number)
        {
            string stringnum = number.ToString();
            int pointplace = 0;
            int number_of_digits=0;
            char[] charnum = stringnum.ToCharArray();
            for (int i=0; i<charnum.Length; i++)
            {
                if (charnum[i] == '.')
                    pointplace = i;
                else continue;

            }

            for (int i = pointplace+1; i<charnum.Length; i++)
            {
                number_of_digits++;
            }
            return number_of_digits;
        }

        public string AverageDouble(ArrayList obj)
        {
            double sum = 0;
            foreach (double item in obj)
            {
                if (DigitsAfterComma(item) ==2)
                sum += item;
            }

            return (sum / obj.Count).ToString();

        }
        

        public ArrayList NotNumOrder(ArrayList obj)
        {

            obj.Sort();
            return obj;
        }

        public void RightFormatOutputInt(ArrayList obj)
        {
            foreach (int item in obj)
            {
                Console.WriteLine(String.Format("{0,20}", item));
            }

            Console.WriteLine(String.Format("{0,20}", AverageInt(obj)));
        }

        public void RightFormatOutputDouble(ArrayList obj)
        {
            foreach (double item in obj)
            {
                Console.WriteLine(String.Format("{0,20:0.00}", item));
            }

            Console.WriteLine(String.Format("{0,20:0.00}", AverageInt(obj)));
        }

        public void RightFormatOutputString(ArrayList obj)
        {
            foreach (string item in obj)
            {
                Console.WriteLine(String.Format("{0,20:0.00}", item));
            }

            Console.WriteLine(String.Format("{0,20:0.00}", AverageInt(obj)));
        }

    }
}
