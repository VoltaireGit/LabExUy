using System;

namespace ComputeAveApp
{
    public class AverageApp
    {
        public static void Main(string[] args)
        {
            // declare an array 
            double[] grades = new double[5];
            double total = 0;

            // Loop to collect grades
            for (int index = 0; index < grades.Length; index++)
            {
                Console.Write($"Please enter grade number {index + 1}: ");
                grades[index] = Convert.ToDouble(Console.ReadLine());

                //  total sum of the grades
                total += grades[index];
            }

            // Compute the average grade
            double averageGrade = total / grades.Length;

            // round off the average grade
            double roundedAverage = Math.Round(averageGrade);

            //  resultsss
            Console.WriteLine($"\nCalculated average grade: {averageGrade:F2}");
            Console.WriteLine($"Rounded average grade: {roundedAverage}");
        }
    }
}
