using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csharp
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
           // program.DigitalTimer();
            //*
            //**
            //***
            //****
            //*****
            for (int row = 1; row <= 5; ++row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            //*****
            //****
            //***
            //**
            //*
            //for (int row = 5; row >= 1; --row)
            //{
            //    for (int col = 1; col <= row; ++col)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //*****
            // ****
            //  ***
            //   **
            //    *
            //int i, j, k;
            //for (i = 5; i >= 1; i--)
            //{
            //    for (j = 5; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //    *
            //   **
            //  ***
            // ****
            //*****

            //int val = 5;
            //int i, j, k;
            //for (i = 1; i <= val; i++)
            //{
            //    for (j = 1; j <= val - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine("");
            //}

            //    *
            //   **
            //  ***
            // ****
            //*****

            //int i, j, k;
            //for (i = 5; i >= 1; i--)
            //{
            //    for (j = 1; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 5; k >= i; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Enter number of rows
            //5
            //    *
            //   ***
            //  *****
            // *******
            //*********
            // *******
            //  *****
            //   ***
            //    *

            //int number, i, k, count = 1;
            //Console.Write("Enter number of rows\n");
            //number = int.Parse(Console.ReadLine());
            //count = number - 1;
            //for (k = 1; k <= number; k++)
            //{
            //    for (i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count--;
            //    for (i = 1; i <= 2 * k - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //count = 1;
            //for (k = 1; k <= number - 1; k++)
            //{
            //    for (i = 1; i <= count; i++)
            //        Console.Write(" ");
            //    count++;
            //    for (i = 1; i <= 2 * (number - k) - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}

            //    *
            //   ***
            //  *****
            // *******
            //*********
            //int i, j, k;
            //for (i = 1; i <= 5; i++)
            //{
            //    for (j = i; j < 5; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 1; k < (i * 2); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //*********
            // *******
            //  *****
            //   ***
            //    *
            //int i, j, k;
            //for (i = 5; i >= 1; i--)
            //{
            //    for (j = 5; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (k = 1; k < (i * 2); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //Enter a number: 4
            //*
            //**
            //***
            //****
            //***
            //**
            //*
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();

            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //for (int i = n; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}


            //Enter a number: 5

            //1
            //12
            //123
            //1234
            //12345
            //1234
            //123
            //12
            //1
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();

            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(j.ToString());
            //    Console.WriteLine();
            //}
            //for (int i = n; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //        Console.Write(j.ToString());
            //    Console.WriteLine();
            //}


            //1
            //22
            //333
            //4444
            //55555

            //int no = 5;
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i);
            //    }
            //    Console.WriteLine();
            //}


            //Enter a number between 1 to 9 : 4
            //   1
            //  121
            // 12321
            //1234321

            //int num, space;
            //Console.Write("Enter a number between 1 to 9 : ");
            //num = Convert.ToInt32(Console.ReadLine());

            //space = num - 1;

            //for (int i = 1; i <= num; i++)
            //{
            //    for (space = 1; space <= (num - i); space++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(j);
            //    }

            //    for (int k = (i - 1); k >= 1; k--)
            //    {
            //        Console.Write(k);
            //    }

            //    Console.WriteLine();

            //}

            //Input number of rows : 4
            //1
            //2 3
            //4 5 6
            //7 8 9 10

            //int i, j, rows, k = 1;
            //Console.Write("Input number of rows : ");
            //rows = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= rows; i++)
            //{
            //    for (j = 1; j <= i; j++)
            //        Console.Write("{0} ", k++);
            //    Console.Write("\n");
            //} 

            //Declaring Arrays:
            //    int[] a;
            //Initializing an Array:
            //    int[] a = new int[10];
            //Assigning Values to an Array:
            //    int[] a = new int[10];
            //    a[0] = 4500.0;
            //Assign values to the array at the time of declaration:
            //    int[]a={1,2,3,4};
            //create and initialize an array:
            //     int [] a = new int[5]  { 99,  98, 92, 97, 95};  (Or)
            //     int [] a = new int[]  { 99,  98, 92, 97, 95};

            //int[] i = new int[0];            
            //Console.WriteLine(i[0]);  //Index was outside the bounds of the array.

            //int[] i= new int[1];
            //Console.WriteLine(i[0]);   // 0
            //Console.WriteLine(i[1]);  //Index was outside the bounds of the array.

            //int[] i = new int[2];
            //Console.WriteLine(i[0]); // 0
            //Console.WriteLine(i[1]); // 0
            //Console.WriteLine(i[2]); //Index was outside the bounds of the array.

            //// This is a zero-element int array.
            //var values1 = new int[] { };
            //Console.WriteLine(values1.Length); // 0

            //// This is a zero-element int array also.
            //var values2 = new int[0];
            //Console.WriteLine(values2.Length); // 0


            Console.ReadLine();
        }

        //public void DigitalTimer()
        //{
        //    Timer t = new Timer();

        //    //timer interval
        //    t.Interval = 1000;  //in milliseconds

        //    t.Elapsed += Time_Elapsed;


        //    //  t.Tick += new EventHandler(this.t_Tick);

        //    //start timer when form loads
        //    t.Start();  //this will use t_Tick() method
        //}

        //private void Time_Elapsed(object sender, ElapsedEventArgs e)
        //{
        //    //get current time
        //    int hh = DateTime.Now.Hour;
        //    int mm = DateTime.Now.Minute;
        //    int ss = DateTime.Now.Second;

        //    //time
        //    string time = "";

        //    //padding leading zero
        //    if (hh < 10)
        //    {
        //        time += "0" + hh;
        //    }
        //    else
        //    {
        //        time += hh;
        //    }
        //    time += ":";

        //    if (mm < 10)
        //    {
        //        time += "0" + mm;
        //    }
        //    else
        //    {
        //        time += mm;
        //    }
        //    time += ":";

        //    if (ss < 10)
        //    {
        //        time += "0" + ss;
        //    }
        //    else
        //    {
        //        time += ss;
        //    }

        //    //update label
        //    Console.WriteLine(time);
        //}

        //timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            //update label
            Console.WriteLine(time);
        }
    }
}
