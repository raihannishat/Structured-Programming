using System;
using System.IO;

namespace Chap_03_File
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 3-1
            // File path : Chap_03_File\bin\Debug\netcoreapp3.1

            //string fileName = $@"my_file.txt";

            //StreamWriter streamWriter = File.CreateText(fileName);

            //streamWriter.WriteLine("This is a file created by my program! ");
            //streamWriter.WriteLine("I am so happy.");

            //streamWriter.Close();
            #endregion

            #region Code: 3-2
            /*
            string fileName = "my_file.txt";
            StreamWriter streamWriter = File.CreateText(fileName);

            streamWriter.WriteLine("This a file created by my program! ");
            streamWriter.WriteLine("I anm so happy.");
            streamWriter.Close();
            streamWriter.WriteLine(" Second line.");
            */
            #endregion

            #region Code: 3-3
            //string fileName = "my_file.txt";

            //StreamWriter streamWriter = File.CreateText(fileName);
            //streamWriter.WriteLine("This a file created by my program! ");
            //streamWriter.WriteLine("I anm so happy.");
            //streamWriter.Close();

            //streamWriter = File.CreateText(fileName);
            //streamWriter.WriteLine(" Second line.");
            //streamWriter.Close();
            #endregion
        }
    }
}
