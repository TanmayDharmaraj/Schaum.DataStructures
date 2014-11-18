using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4_Arrays_Records_Pointers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] YEAR = new int[] { 2, 4, 1, 2, 3, 2, 2, 2, 1, 3, 2, 4, 3, 2, 1, 2, 3, 2 };
            string[] GIVEN = new string[] { "Bruce", "Irene L", "Kim", "John", "Steven", "Kenneth", "Gerald S", "Gary", "Deborah M.", "John", "William", "Ronald P.", "Paul", "David", "Mary J.", "Joanna", "David E.", "Adam" };
            string[] LAST = new string[] { "Adam", "Bailey", "Cheng", "Davis", "Edwards", "Fox", "Green", "Hopkins", "Klein", "Lee", "Murphy", "Newman", "Osborn", "Parker", "Rogers", "Schwab", "Thompson", "White" };
            string[] SSN = new string[] { "211581329", "169384248", "166485842", "187524076", "126636382", "135589565", "1724818449", "172603157", "160601826", "166524147", "186580403", "187581123", "174580732", "183523865", "135481397", "182526712", "184488539", "187482377" };
            double[] CUM = new double[] { 2.55, 3.25, 3.40, 2.85, 1.75, 2.80, 2.35, 2.70, 3.05, 2.60, 2.30, 3.90, 2.05, 1.55, 1.85, 2.95, 3.15, 2.50 };


            //list all students whose CUM is greater than K=3
            Console.WriteLine("\nlist all students whose CUM is greater than K=3");
            four_31_a(GIVEN, CUM, (double)3);

            //list all students in year 2
            Console.WriteLine("\nlist all students in year 2");
            four_31_b(GIVEN, YEAR, 2);

            //Linear Search
            Console.WriteLine("\nLinear Search : O(n)");
            int index = -1;
            string item = "Tanmay";

            LINEAR_4_32(GIVEN, item, out index);

            Console.WriteLine("Fount at Item Number :" + index);

            //Binary Search
            Console.WriteLine("\nBinary Search : O(log n)");

            BINARY_4_33(YEAR, 7, out index);
            Console.WriteLine("Binary Search output   : " + index);

            //print records of students given SSN
            Console.WriteLine("\nPrint records of students given SSN");
            LINEAR_STUDENT_RECORDS_4_34(SSN, "211581329", GIVEN, LAST, CUM, YEAR);

            //Using Binary algo print details of students given last name
            Console.WriteLine("\nUsing Binary algo print details of students given last name");

            BINARY_4_35(LAST, "Rogers", SSN, GIVEN, CUM, YEAR);
            BINARY_4_35(LAST, "Johnson", SSN, GIVEN, CUM, YEAR);
            BINARY_4_35(LAST, "Bailey", SSN, GIVEN, CUM, YEAR);


            //Write a program that reads the records of the student and inserts them in the correct place using Binary
            Console.WriteLine("\nWrite a program that reads the records of the student and inserts them in the correct place using Binary");
            string SSNST = "1234831384",
                GIVENST = "Tanmay",
                LASTST = "Buaslkdj";
            double CUMST = 2.5;
            int YEARST = 3;
            Binary_4_36(SSNST, GIVENST, LASTST, CUMST, YEARST, LAST);

            //Given last name delete from record
            Console.WriteLine("\nGiven last name delete from record");
            Binary_4_37("Parker", LAST);
            Binary_4_37("Fox", LAST);


            PTR_4_38(SSN);

            Console.ReadLine();

        }


        static void four_31_a(string[] students, double[] cum, double k)
        {
            for (int i = 0; i < cum.Length; i++)
                if (cum[i] > k)
                    Console.WriteLine(students[i]);
        }

        static void four_31_b(string[] students, int[] YEAR, int k)
        {
            for (int i = 0; i < YEAR.Length; i++)
                if (YEAR[i] == k)
                    Console.WriteLine(students[i]);
        }

        static void LINEAR_4_32(string[] array, string item, out int index)
        {
            index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item)
                {
                    index = i + 1;
                    break;
                }
            }
        }
        static void BINARY_4_33(int[] students, int item, out int index)
        {
            index = -1;
            //first sort the array. Could have written Bubble sort but we will save time as it is not asked
            Array.Sort(students);

            //Binary now
            int beg = 0, end = students.Length - 1, mid = (beg + end) / 2;
            while (beg <= end && students[mid] != item)
            {
                if (item < students[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
                mid = (beg + end) / 2;
            }
            if (students[mid] == item)
                index = mid;
            else
            {
                index = mid;
            }
        }

        static void LINEAR_STUDENT_RECORDS_4_34(string[] SSN, string item, string[] GIVEN, string[] LAST, double[] CUM, int[] YEAR)
        {
            for (int i = 0; i < SSN.Length; i++)
            {
                if (SSN[i] == item)
                {
                    Console.WriteLine("SSN : {0} \nName Given : {1} \nLast Name : {2}\nCUM : {3}\nYear : {4}", SSN[i], GIVEN[i], LAST[i], CUM[i], YEAR[i]);
                    return;
                }

            }
            Console.WriteLine("No Records found");
        }

        static void BINARY_4_35(string[] students, string lastName, string[] SSN, string[] GIVEN, double[] CUM, int[] YEAR)
        {
            //binary expects sorted

            int beg = 0, end = students.Length - 1, mid = (beg + end) / 2;
            char[] c = new char[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                c[i] = students[i].ToCharArray(0, 1)[0];
            }
            char ch = lastName.ToCharArray()[0];
            while (beg <= end && students[mid] != lastName)
            {
                if (ch < c[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
                mid = (beg + end) / 2;
            }
            if (c[mid] == ch)
            {
                Console.WriteLine("SSN : {0} \nName Given : {1} \nLast Name : {2}\nCUM : {3}\nYear : {4}", SSN[mid], GIVEN[mid], students[mid], CUM[mid], YEAR[mid]);
            }

        }
        
        static void Binary_4_36(string SSNST, string GIVENST, string LASTST, double CUMST, int YEARST, string[] LAST)
        {
            char ch = LASTST.ToCharArray()[0];
            char[] c = new char[LAST.Length];
            for (int i = 0; i < LAST.Length; i++)
            {
                c[i] = LAST[i].ToCharArray()[0];
            }

            int beg = 0, end = LAST.Length - 1, mid = (beg + end) / 2;
            while (beg <= end && c[mid] != ch)
            {
                if (ch < c[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
                mid = (beg + end) / 2;
            }
            if (c[mid] != ch)
            {
                Console.WriteLine("Should insert at 0 based index " + (mid + 1));
            }
            else
            {
                Console.WriteLine("Should insert at 0 based index " + mid);
            }
        }

        static void Binary_4_37(string LASTST, string[] LAST)
        {
            char ch = LASTST.ToCharArray()[0];
            char[] c = new char[LAST.Length];
            for (int i = 0; i < LAST.Length; i++)
            {
                c[i] = LAST[i].ToCharArray()[0];
            }

            int beg = 0, end = LAST.Length - 1, mid = (beg + end) / 2;
            while (beg <= end && c[mid] != ch)
            {
                if (ch < c[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    beg = mid + 1;
                }
                mid = (beg + end) / 2;
            }
            if (c[mid] == ch)
            {
                Console.WriteLine("Delete Index " + mid);
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }

        static void PTR_4_38(string[] SSN)
        {
            string[] NUMBER = new string[SSN.Length];
            int[] PTR = new int[SSN.Length];
            Array.Sort(SSN);

            for (int i = 0; i < SSN.Length; i++)
            {
                NUMBER[i] = SSN[i];
                PTR[i] = i; //assume pointer
            }

        }
    }
}
