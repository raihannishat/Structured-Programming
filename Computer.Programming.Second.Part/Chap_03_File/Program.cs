using System;
using System.IO;

namespace Chap_03_File
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Code: 3-1
            /*
            string path = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\My_file.txt";

            StreamWriter streamWriter = File.CreateText(path);

            streamWriter.WriteLine("This is a file created by my program! ");
            streamWriter.WriteLine("I am so happy.");
            streamWriter.Close();
            */
            #endregion

            #region Code: 3-2
            /*
            string path = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\My_file.txt";

            StreamWriter streamWriter = File.CreateText(path);

            streamWriter.WriteLine("This is a file created by my program! ");
            streamWriter.WriteLine("I am so happy.");
            streamWriter.Close();

            streamWriter.WriteLine(" Second line.");
            */
            #endregion

            #region Code: 3-3
            /*
            string path = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\My_file.txt";

            StreamWriter streamWriter = File.CreateText(path);

            streamWriter.WriteLine("This is a file created by my program! ");
            streamWriter.WriteLine("I am so happy.");
            streamWriter.Close();

            streamWriter = File.AppendText(path);
            streamWriter.WriteLine(" Second line.");
            streamWriter.Close();
            */
            #endregion

            #region Code: 3-4
            /*
            string input_file = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\in.txt";
            string output_file = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\out.txt";

            int num1, num2, sum;

            string[] line = File.ReadAllLines(input_file);

            num1 = int.Parse(line[0]);
            num2 = int.Parse(line[1]);
            sum = num1 + num2;

            StreamWriter streamWriter = File.CreateText(output_file);
            streamWriter.WriteLine(sum);
            streamWriter.Close();
            */
            #endregion

            #region Code: 3-5
            /*
            string input_file = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\in.txt";
            string output_file = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\out.txt";

            string lines = File.ReadAllText(input_file);

            string[] number = lines.Split(' ');

            int num1, num2, sum;

            num1 = int.Parse(number[0]);
            num2 = int.Parse(number[1]);
            sum = num1 + num2;

            StreamWriter streamWriter = File.CreateText(output_file);
            streamWriter.WriteLine($"{num1} {num2} {sum}");
            streamWriter.Close();
            */
            #endregion

            #region Code: 3-6
            /*
            string math_input = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\math.txt";
            string bangla_input = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\bangla.txt";
            string english_input = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\english.txt";
            string outout_file = @"D:\Code\GitHub\Structured-Programming\Computer.Programming.Second.Part\Chap_03_File\output.txt";

            StreamWriter mathStreamWriter = File.CreateText(math_input);
            StreamWriter banglaStreamWriter = File.CreateText(bangla_input);
            StreamWriter englishStreamWriter = File.CreateText(english_input);
            StreamWriter outputStreamWriter = File.CreateText(outout_file);

            Console.WriteLine("Input for Math file (Roll Number): ");
            for (int i = 1; i <= 10; i++)
            {
                mathStreamWriter.WriteLine($"{i} {Console.ReadLine()}");
            }
            mathStreamWriter.Close();

            Console.WriteLine("\nInput for Bangla file (Roll Number): ");
            for (int i = 0; i < 10; i++)
            {
                banglaStreamWriter.WriteLine($"{i} {Console.ReadLine()}");
            }
            banglaStreamWriter.Close();

            Console.WriteLine("\nInput for English file (Roll Number): ");
            for (int i = 0; i < 10; i++)
            {
                englishStreamWriter.WriteLine($"{i} {Console.ReadLine()}");
            }
            englishStreamWriter.Close();

            string math_file = File.ReadAllText(math_input);
            string bangla_file = File.ReadAllText(bangla_input);
            string english_file = File.ReadAllText(english_input);

            string[] math = math_file.Split(' ', '\n');
            string[] bangla = bangla_file.Split(' ', '\n');
            string[] english = english_file.Split(' ', '\n');

            int[] output_number = new int[20];

            for (int i = 1; i < 20; i = i + 2)
            {
                output_number[i] += int.Parse(english[i]) + int.Parse(bangla[i]) + int.Parse(math[i]);
            }

            for (int i = 1, x = 1; i < 20; i = i + 2, x++)
            {
                outputStreamWriter.WriteLine($"{x} {output_number[i] / 3}");
            }
            Console.WriteLine();

            outputStreamWriter.Close();
            */
            #endregion
        }
    }
}
