using System;

namespace DataType
{
    public class DataTypeProgram
    {
        static void Main(string[] args)
        {
            // put the number of apple first
            Console.Write("Enter the number of apples: ");
            int appleCount = Convert.ToInt32(Console.ReadLine());

            // count the apples
            if (appleCount <= 0)
            {
                Console.WriteLine("Invalid input. The number of apples must be a positive integer.");
                return; // this will pop up if the input is invalid
            }

            // input for the total price of the apples
            Console.Write("Enter the total " + appleCount + " price of the apples: ");
            double totalPrice = Convert.ToDouble(Console.ReadLine());

            // this will ensure the total price if it is a valid number
            if (totalPrice <= 0)
            {
                Console.WriteLine("Invalid input.");
                return; 
            }

            
            

            // this thing will convert the total price to an integer  
            int convertedPrice = (int)totalPrice;

            // results
            Console.WriteLine("============================================");
            Console.WriteLine("The total price of "  + appleCount + " apple is: " + totalPrice);
            Console.WriteLine("The total price of apple is: " + totalPrice);
            Console.WriteLine("The value of converted price is: " + convertedPrice);

           
            
        }
    }
}
