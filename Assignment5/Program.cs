using System;
using System.Reflection.PortableExecutable;

namespace Assignment5
{
    internal class Program
    {

        public static void SumByValue(int num01 , int num02)
        {
            int sum = num01 + num02;

            num01 = 20;
            Console.WriteLine($"Sum is {sum}");
        }
        public static void SumByRef(ref int num01,ref int num02)
        {
            int sum = num01 + num02;

            num01 = 20;
            Console.WriteLine($"Sum is {sum}");
        }


        public static int SumArrayByVal(int[] arr)
        {
            int sum = 0;
            arr = new int[] { 0,20,30,40,50 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;

        }
        public static int SumArrayByRef(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 0, 20, 30, 40, 50 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;

        }


        public static void SumSub(int num01 , int num02 , out int sum ,out int sub )
        {
            sum = num01 + num02;
            sub = num01 - num02;
        }


        public static int getSum(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }



            return sum;
           

        }

        public static bool isPrime(int num)
        {
            if(num <= 1)
                return false;
            else
            {
                for(int i=2;i < num/2;i++)
                {
                    if(num%i ==0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void MinMaxArray(ref int[] arr, out int max, out int min)
        {
            max = arr.Max();
            min = arr.Min();
        }

        public static int getFactorial(int num)
        {
            int factorial = 1;

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;

        }

        public static string ChangeChar(ref string text, int position , Char letter)
        {
            text = text.Remove(position, 1).Insert(position, letter.ToString());

            return text;
        }


        static void Main(string[] args)
        {
            #region Q1. Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            #region ByValue

            /*while calling valueTypeSum it will create stack frame in the stack and modify on it.
             * so when i changed the value of num01 in the function from 10 to 20 it will not be changed in the main stack frame
            */

            //int num01 = 10;
            //int num02 = 20;
            //Console.WriteLine($"num01 = {num01} \nnum02 = {num02}");
            //SumByValue(num01, num02);
            //Console.WriteLine($"num01 = {num01} \nnum02 = {num02}");


            #endregion

            #region ByReference
            /* while calling RefTypeSum the main stack will play the roll of RefTypeSum stack
             * so any modification in RefTypeSum will affect the main values
             */

            //int num01 = 10;
            //int num02 = 20;
            //Console.WriteLine($"num01 = {num01} \nnum02 = {num02}");
            //SumByRef(ref num01, ref num02);
            //Console.WriteLine($"num01 = {num01} \nnum02 = {num02}");


            #endregion

            #endregion


            #region Q2.Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            #region ByValue
            /* after calling SumArrayByVal there's Stack Frame created to store address of the array in the heap the refers to the same arr in the main
               , but after init new array in the function the address of the function will refer to the new array
                but the main will not be affected
             */

            //int[] arr = { 10,20,30,40,50 };

            //Console.WriteLine($"{arr[0]} before sum");
            //Console.WriteLine(SumArrayByVal(arr));
            //Console.WriteLine($"{arr[0]} after sum");


            #endregion


            #region ByReference

            /*after calling SumArrayByVal  the stack frame of the function will be same stack fram of the main so any changes happen in the function
             * will affect the main values
             */


            //int[] arr = { 10, 20, 30, 40, 50 };

            //Console.WriteLine($"{arr[0]} before sum");
            //Console.WriteLine(SumArrayByRef(ref arr));
            //Console.WriteLine($"{arr[0]} after sum");
            #endregion


            #endregion

            #region Q3.Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //Console.WriteLine("Enter first number");
            //if(int.TryParse(Console.ReadLine() ,out int num01)) 
            //{
            //    Console.WriteLine("Enter second number");
            //    if (int.TryParse(Console.ReadLine(), out int num02))
            //    {
            //        int sum, sub;
            //        SumSub(num01, num02, out sum, out sub);
            //        Console.WriteLine("Sum = {0}",sum);
            //        Console.WriteLine("Sub = {0}",sub);


            //    }
            //}







            #endregion


            #region Q4. Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number

            //Console.WriteLine("Please enter number");
            //if(int.TryParse(Console.ReadLine(), out int num01))
            //{
            //    Console.WriteLine(getSum(num01));
            //}

            #endregion


            #region Q5. Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.WriteLine("Enter number");
            //if(int.TryParse(Console.ReadLine(), out int num))
            //{
            //    Console.WriteLine(isPrime(num));
            //}

            #endregion


            #region Q6.Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] arr = { 30,100,20,1,55,60};

            //int max;
            //int min;

            //MinMaxArray(ref arr,out max , out min);

            //Console.WriteLine("Max is {0}", max);
            //Console.WriteLine("Min is {0}", min);



            #endregion


            #region Q7. Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            //Console.WriteLine("Get factorial of number: ");
            //if (int.TryParse(Console.ReadLine(), out int num) && num > 0)
            //{
            //    if(num == 1)
            //    {
            //        Console.WriteLine("Result: 1");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Result: {getFactorial(num)}");
            //    }
            //}


            #endregion

            #region Q8.Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter

            //string text = "Hello World!";

            //Console.WriteLine(text);
            //Console.WriteLine("Insert Position first then character you need to change");
            //int position = int.Parse(Console.ReadLine());
            //char letter = char.Parse(Console.ReadLine());


            //Console.WriteLine(ChangeChar(ref text , position , letter));

                #endregion



        }
    }
}
