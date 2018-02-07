using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace HomeTask2
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Result1: " + FileWork.ExecuteFile(FileWork.OpenFile())+"\n");
                 
                Console.WriteLine("Result2: " + FileWork.NewLine(FileWork.OpenFile())+"\n");

                Console.WriteLine("Result3: " + FileWork.AddDateTime(FileWork.OpenFile()) + "\n");

        }
    }
}
