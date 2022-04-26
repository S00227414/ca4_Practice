using System;
using System.IO;

namespace CA4_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Graduate[] Graduates = new Graduate[4];
            string template = "{0,-20}{1,-10}{2,-10}{3,-25}{4,-20}";
            Console.WriteLine(template, "Graduate Number", "Name", "Marks", "Classification type", "Project");

            Graduates[0] = new Graduate("Anna", 20, "Game");
            Graduates[1] = new Graduate("James", 70, "Mobile App");
            Graduates[2] = new Graduate("Annabelle", 60, "Website");
            Graduates[3] = new Graduate("Paddy", 55, "Mobile App");

            for (int i = 0; i < Graduates.Length; i++)
            {
                Console.WriteLine(Graduates[i].ToString());
            }

            ReadGrads();




        }
        static void ReadGrads()
        {
            string lineIn;
            Graduate[] Graduates = new Graduate[10];
            string[] fields = new string[3];
            string template = "{0,-10}{1,-10}{2,-10}";

            try
            {
                //open connection
                FileStream fs = new FileStream("graduates.csv", FileMode.Open, FileAccess.Read);

                StreamReader inputStream = new StreamReader(fs);

                Console.WriteLine("Graduate Report");
                Console.WriteLine(template, "Name", "Grade", "Graduate Number");

                lineIn = inputStream.ReadLine(); //get first record

                //report body
                while (lineIn != null)
                {

                    for (int i = 0; i < Graduates.Length; i++)
                    {
                        fields = lineIn.Split(','); //split input on the comma
                        IsInteger(fields[1], "Grade");
                        Graduates[i] = new Graduate(fields[0], Int32.Parse(fields[1]), fields[2]);
                        Console.WriteLine(Graduates[i].ToString());
                        lineIn = inputStream.ReadLine(); //get next line


                    }

                }

                inputStream.Close();

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("File is is invalid length.");
            }
            

        }
        static bool IsInteger(string textIn, string itemName)
        {

            bool isOK;
            int num;

            isOK = int.TryParse(textIn, out num); // out means pass the un-initialised variable by reference

            if (isOK == true)
                return true;
            else
            {
                Console.WriteLine("{0} must be of type integer", itemName);
                return false;
            }

        }
    }
}
