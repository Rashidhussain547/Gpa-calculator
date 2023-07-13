using System;
using System.Security.Cryptography.X509Certificates;

namespace Gpacalculator
{
    public class program
    {


        public double calculation(double gradePoint)                      // Method for calculate quality of perticular subject
        {
            double res;
            int Timepersub = 3;
            res = gradePoint * Timepersub;
            return res;
        }
        static void Main(string[] args)
        {
            double marks = 0.0;
            double gradePoint = 0.0;
            int Totalsub = 6;
            int QuailtyTime = 18;
            double quality = 0.0;
            double Totalquality = 0.0;
            double Gpa = 0.0;
            for (int i = 1; i <= Totalsub; i++)
            {
                Console.WriteLine("Enter marks of subjects {0} : ", i);
                marks = Convert.ToDouble(Console.ReadLine());
                if (marks >= 45 && marks <= 52)
                {
                    gradePoint = 1.0;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 53 && marks <= 56)
                {
                    gradePoint = 1.4;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 57 && marks <= 60)
                {
                    gradePoint = 1.8;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 61 && marks <= 63)
                {
                    gradePoint = 2.0;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 64 && marks <= 67)
                {
                    gradePoint = 2.4;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 68 && marks <= 70)
                {
                    gradePoint = 2.8;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 71 && marks <= 74)
                {
                    gradePoint = 3.0;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 75 && marks <= 79)
                {
                    gradePoint = 3.4;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 80 && marks <= 84)
                {
                    gradePoint = 3.8;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else if (marks >= 85)
                {
                    gradePoint = 4.0;
                    program respersub = new program();
                    quality = respersub.calculation(gradePoint);
                    Console.WriteLine("quality of subject {0} is {1} \n", i, quality);

                }
                else
                {
                    Console.WriteLine("You are fail in {0}...",i);
                }
                
                Totalquality += quality;
            }
            Console.WriteLine("Total quality is {0}", Totalquality);

            Gpa = Totalquality / QuailtyTime;
            Console.WriteLine("| Your Gpa is {0} |", Gpa);

        }


    }
}

/*
 In this application i use Method , decion making and for loop
 */