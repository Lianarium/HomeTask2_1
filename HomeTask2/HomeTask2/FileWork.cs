using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    class FileWork
    {
        FileWork() { }
        static string path = "Resource.txt";

        public static string OpenFile( )
        {
            string source = File.ReadAllText(path);
            return source;
            
        }

        public static string ExecuteFile(string source)
        {

            char[] charArray = source.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (Char.IsUpper(charArray[i]))
                    charArray[i] = char.ToLower(charArray[i]);
                 
            }
            source = new string(charArray);

            return source;
            
        }

        public static string NewLine(string source)
        { 
            char[] sourceArray = source.ToCharArray();
            ArrayList index = new ArrayList();
            index.Add(0);
            for (int i = 0; i < sourceArray.Length; i++)
            {

                if (sourceArray[i] == '.')
                    index.Add(i);
                
            }

            string source1 = source.Insert(0, GetDateTime());
            foreach (int ind in index)
            {
                if (ind != 0)
                    source = source.Insert(ind + 3, "\n");
                else source = source.Insert(ind, "\n");
                
            }

            return source;
             
        }

        public static string AddDateTime(string source)
        {
            char[] sourceArray = source.ToCharArray();
            ArrayList index = new ArrayList();
            index.Add(0);

            for (int i = 0; i < sourceArray.Length; i++)
            {

                if (sourceArray[i] == '.')
                    index.Add(i);

            }

            source = source.Insert(0, GetDateTime());
            foreach (int ind in index)
            {
                if (ind != 0)
                    source = source.Insert(ind + 2, GetDateTime());

            }

            return source;

        }

        public static string GetDateTime()
        {
            DateTime date = DateTime.Now;
            string sdate = date.ToString();
            return sdate;
        }

         
    }
}
