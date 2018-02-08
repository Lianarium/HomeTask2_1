using System;
using System.Collections;
using System.Linq;
using Microsoft.VisualBasic;

namespace HomeTask2_2
{
	class LineWork
    {
        public LineWork()
        {
            lineList = new ArrayList();
			lineList_no_commas = new ArrayList();
            IntList = new ArrayList();
            DoubleList = new ArrayList();
            NotNum = new ArrayList();
			nc = new NameComparer();

        }

        public ArrayList lineList;
		public ArrayList lineList_no_commas;
		public ArrayList IntList;
        public ArrayList DoubleList;
        public ArrayList NotNum;
		public NameComparer nc;
		public object NameComparer { get; private set; }

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


		public string ChangeCommasToPointsProcess(string item)
		{
			 
				char[] stringArray = item.ToCharArray();
				for (int i=0; i<stringArray.Count(); i++)
				{
					if (stringArray[i] == ',')
						stringArray[i] = '.';
					//Console.WriteLine(stringArray[i]);
				}

			 
			item = new string (stringArray);
			
			return item;

		}



		/*public ArrayList ChangeCommasToPointsPrepare(ArrayList obj)
		{
			foreach (string item  in obj)
			{
				 
			}
		}*/


		public void CheckType(ArrayList obj1, ArrayList obj2, ArrayList obj3, ArrayList obj4)
        {
            int integer;
            double doublenum;

            foreach (string item in obj1)
            {

				if (int.TryParse(item, out integer))
				{ obj2.Add(integer); }
				else if (double.TryParse(ChangeCommasToPointsProcess(item), out doublenum))
				{obj3.Add(doublenum);
					Console.WriteLine(ChangeCommasToPointsProcess(item));
				}
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

            Console.WriteLine(String.Format("{0,20:0.00}", AverageDouble(obj)));
        }

        public void RightFormatOutputString(ArrayList obj)
        {
            foreach (string item in obj)
            {
                Console.WriteLine(String.Format("{0,20:0.00}", item));
            }
			 
            Console.WriteLine(String.Format("{0,20:0.00}", AverageInt(obj)));
        }


       public void NotNumSort(ArrayList obj)
		{

			string[] notNumArray = new string[obj.Count];
			int i = 0;
			foreach (string item in obj)
			{
				notNumArray[i] = item;
				i++;
			}

			for (int j=0; j<notNumArray.Count()-1; j++)
			{
				 
				if(notNumArray[j].Length > notNumArray[j+1].Length)
				{
					string temp;
					temp = notNumArray[j];
					notNumArray[j] = notNumArray[j + 1];
					notNumArray[j + 1] = temp;
				}


			}

			for (int j = 0; j < notNumArray.Count() - 1; j++)
			{
				if (notNumArray[j].Length == notNumArray[j + 1].Length)
				{
					if (String.Compare(notNumArray[j], notNumArray[j + 1]) > 0)
					{
						string temp;
						temp = notNumArray[j];
						notNumArray[j] = notNumArray[j + 1];
						notNumArray[j + 1] = temp;
					}
				}
			}

			for (int j = 0; j < notNumArray.Count(); j++)
			{
				Console.WriteLine(notNumArray[j] + "&&&&");
			}


			}
    }
}
