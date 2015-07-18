using System;using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grades
{
    class Program
    {
        static void GiveAName(GradeBook book)
        {
            book.Name = "Name GradeBook";

        }

        static void IncrementNumber(int number)
        {
            number += 1;
            Console.WriteLine(number);
        
        }

        static void Main(string[] args)
        {


            //ArrayS();
            //Immutable();
            //CompareTwotrings();
            //PassByValueAndRef();

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            //now I will add a double for grade and I will let the compiler to now that is a float because otehrwise will complain
            book.AddGrade(89.5f);
            book.AddGrade(75f);
            
            GradeStatistics stats = book.ComputeStatistics();
            
            Console.WriteLine("AverageGrade is " + " " + stats.AverageGrade);
            Console.WriteLine("HighestGrade is " + " " + stats.HighestGrade);
            Console.WriteLine("LowestGrade is " + " " + stats.LowestGrade);

            WriteBytes(stats.AverageGrade);
            WriteBytes(20);
            WriteNames("Teddy", " " ,"Mihali", " ","Delia", " Mihali\n");

        }
        private static void WriteBytes(int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);

            WriteBytesArray(bytes);
        }

        private static void WriteBytesArray(byte[] bytes)
        {
            foreach (byte b in bytes)
            {
                Console.Write("0x{0:x}", b);

            }
            Console.WriteLine();
        }

        private static void WriteNames(params string[] names)
        {
            foreach(string name in names)
            {
                Console.Write(name);

            }


        }



        private static void WriteBytes(float value)
        {
            byte [] bytes = BitConverter.GetBytes(value);

            WriteBytesArray(bytes);
        }

        private static void ArrayS()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            foreach (float grade in grades)
            {
                Console.WriteLine(grade);

            }

        }

        private static void AddGrades(float[] grades)
        {
            if (grades.Length > 3)
            {
                grades[0] = 91f;
                grades[1] = 89.5f;
                grades[2] = 79f;
                grades[2] = 0f;
            }
           
        }

        private static void Immutable()
        {
            string name= " Teddy ";
            DateTime date = new DateTime(2014, 1, 1);
           date =  date.AddHours(25);

            name = name.Trim();
            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void CompareTwoStrings()
        {
            string name1 = "teddy";
            string name2 = "Teddy";

            bool areEquals = name1.Equals(name2);
            Console.WriteLine(areEquals);
        }

        private static void PassByValueAndRef()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            GiveAName(g1);
            Console.WriteLine(g1.Name);

            int x1 = 4;

            IncrementNumber(x1);
            Console.WriteLine(x1);
        }
    }
}
