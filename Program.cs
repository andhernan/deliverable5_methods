/*
 * Author: Andrea Hernandez-Sabanilla
 * Data: 4/25/2023
 * PROGRAM (4): 
 * Method 1: Randomly populate an array with integers numbers between 10 and 50. The array length is a parameter for the method. 
 * Method 2: Return the summation of all the elements of an array (the array is the parameter for this method). 
 * The program has to follow the instructions below:
 * 
 * Ask the user to enter an integer number between 5 and 15.
 * Use a try/catch block to validate the user’s entry.
 * Use a conditional statement to check the user’s entry is between 5 and 15.
 * Use Method 1 to randomly populates an array with a length equal to the user’s input.
 * Display in the console all the elements the in the array.
 * Use Method 2 to sum all the elements in the array from step 4.
 * Display in the console the value from step 6.
 */


using System;
using System.Linq.Expressions;

namespace deliverable5_methods
{
    class Program
    {
        //Method 1: Randomly populate an array with integers numbers between 10 and 50.
        //The array length is a parameter for the method.
        static int[] random_Array(int array_len)
        {
            //creates random variable
            Random randomv = new Random();

            int[] myArray = new int[array_len];

            for (int i = 0; i < array_len; i++)
            {
                myArray[i] = randomv.Next(10,50);
            }
            return myArray;
        }

        // * Method 2: Return the summation of all the elements of an array (the array is the parameter for this method). 
        static int sum(int[] array)
        {
            //initialize
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }
        //main program
        static void Main(string[] args)
        {
            int array_len = 0;

            //using the code from deliverable 3 to validate
            //initiate variable
            bool con1 = false;
            //make sure it is a number
            while (con1 == false)
            {
                Console.WriteLine("Enter an integer value between 5 and 15: ");
                string chosenNumString = Console.ReadLine();

                bool parseSuccess = int.TryParse(chosenNumString, out array_len);
                //check if it is within valid parameters
                if (parseSuccess)
                {
                    if (array_len >= 5 && array_len <= 15)
                    {
                        con1 = true;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter an integer between 5 and 15.");
                }
            }


            //create array with number with the method
            int[] sampleArray = random_Array(array_len);
            

            //write the elements of array
            Console.WriteLine("The elements in the random array are: ");
            //write every number in array
            foreach (int element in sampleArray)
            {

                Console.WriteLine(element);
            }

            //get sum of array
            Console.WriteLine(" ");
            Console.WriteLine("The sum is: "+ sum(sampleArray));
        }
    }
}