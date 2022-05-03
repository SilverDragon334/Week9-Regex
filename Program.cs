using System;
using System.Text.RegularExpressions;
using System.IO;

namespace Week_x_Assignment
{
    class Tester
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter .txt file: ");
            string input = Console.ReadLine();
            int a = 0;
            int fileL = 0;
            
            

            var txtChecker = new Regex(@"^[A-Z]{1}:{1}[/]+[A-Za-z0-9 /]+.txt$");

            if (txtChecker.IsMatch(input))
            {
                Console.WriteLine("You entered a text file :)");
                try
                {
                    StreamReader streamReader = new StreamReader(input);
                    string line = streamReader.ReadLine();
                    Console.WriteLine(line);

                    while (a <= line.Length - 1)
                    {
                        if (line[a] == ' ' || line[a] == '\n' || line[a] == '\t')
                        {
                            fileL++;
                        }
                        a++;
                    }
                }
                catch (Exception ex)
                {
                    //Console.WriteLine("This file is empty :(");
                    Console.WriteLine(ex.Message);

                }

            }
            else
            {
                Console.WriteLine("That isn't a text file!!!! :(");
            }
            /*{

            }
            catch (FormatException)
            {
                Console.WriteLine("Input entered incorrectly");

            }

            catch (Exception existential)
            {

            }

            try
            {

            }
            catch (Exception empty)
            {

            }*/

            Console.WriteLine("Na na na na. Na na na na. Hey Hey Hey. GOOOODBYYYYYYYE!");
        }
    }
}

