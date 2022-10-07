using Recursion_and_numbers.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            NumSet test = new NumSet();

            StreamWriter writer = new StreamWriter("OUTPUT.txt");
            StreamReader reader = new StreamReader("INPUT.txt");
            var line = reader.ReadLine(); line = reader.ReadLine();

            while (line != null)
            {
                string text = line.ToString();
                string firstValue = "";
                string secondValue = "";

                string[] substring = text.Split(' ');
                firstValue = substring[0];
                secondValue = substring[1];
                int sets = Int32.Parse(secondValue);
                int index = Int32.Parse(firstValue);


                int sizeNow = test.Size;

                if (sets > sizeNow)
                    for (int i = 0; i <= sets - sizeNow; i++)
                        test.Add();

                if (index > test.Set[sets - 1].Numbers.Length)
                    writer.WriteLine("No solution");
                else
                    writer.WriteLine(test.Set[sets - 1].Numbers[index - 1]);

                line = reader.ReadLine();
            }
            reader.Close();
            writer.Close();

            /*for (int i = 0; i < test.Size; i++)
            {
                    Console.Write(test.SetNumbers(i));
                Console.WriteLine();
            }*/
        }
    }
}
