using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ITIDay2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1.Write a program that allows the user to enter a number then print it.
            Console.WriteLine("enter your num :");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(y);

            //2.Write C# program that converts a string to an integer, but the string contains non-numeric characters.
            //And mention what will happen
            string nu = "10n";
            int x;
            int.TryParse(nu, out x); // will return false

            //3.Write C# program that take two string variables and print them as one variable 
            string s1 = "osama";
            string s2 = "Ramadan";
            Console.WriteLine($"two strings equal {s1}  {s2}");

            // 4.	Write a program that calculates the simple interest given the principal amount, rate of interest,
            // and time. 
            //Note: The formula for simple interest is Interest = (principal * rate * time) / 100.
            double principal, rate, time, interest;

            Console.Write("Enter Principal Amount: ");
            principal = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Time (in years): ");
            time = double.Parse(Console.ReadLine());

            interest = (principal * rate * time) / 100;

            Console.WriteLine($"Simple Interest ={interest} ");

            // 5.	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms
            // and height in meters. 
            // Note: The formula for BMI is BMI = (Weight) / (Height * Height)
            double weight, height, bmi;

            Console.Write("Enter Weight (kg): ");
            weight = double.Parse(Console.ReadLine());

            Console.Write("Enter Height (m): ");
            height = double.Parse(Console.ReadLine());

            bmi = weight / (height * height);

            Console.WriteLine($"Body Mass Index (BMI) = {bmi}");

            //   //6.	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            //    Assign the result in a variable then display the result. 
            //   Note:
            // a.that below 10 degrees is "Just Cold"
            //b.above 30 degrees is "Just Hot"
            //c.anything else is "Just Good"
            Console.WriteLine("enter the temprature now:");
            int temprature = int.Parse(Console.ReadLine());
            string result;
            if (temprature < 10)
            {
                result = "Just Cold";
            }
            else if (temprature > 30)
            {
                result = "Just Hot";
            }
            else
            {
                result = "Just Good";
            }

            Console.WriteLine($"Result: {result}:");

            //7.Write a program that takes the date from the user and displays it in
            //various formats using string interpolation.
            //        Ex:
            //            Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Today's date : {day} , {month} , {year}");
            Console.WriteLine($"Today's date : {day} / {month} / {year}");
            Console.WriteLine($"Today's date : {day} - {month} - {year}");


            //8- Write a program that takes a number from the user then print yes
            //if that number can be divided by 3 and 4 otherwise print no.
            //Example(1)
            //Input: 12
            //Output: Yes
            //Example(2)
            //Input: 9
            //Output: No
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            // 9- Write a program that allows the user to insert an integer then print negative
            // if it is negative number otherwise print positive.
            //Example(1)
            //Input: -5
            //Output: negative
            //Example(2)
            //Input: 10
            Console.WriteLine("entrer the number : ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("negative");

            }
            else
            {
                Console.WriteLine("the num is equal to zero");
            }

            //   10 - Write a program that takes 3 integers from the user then prints the max element and
            //   the min element.
            //    Example(1)
            //    Input: 7,8,5
            //    Output:
            //            max element = 8
            //    min element = 5
            //—--------------------------------
            //    Example(2)
            //    Input: 3 6 9
            //    Outputs:
            //            Max element = 9
            //    Min element = 3
            int first, second, third, min, max;
            Console.WriteLine("enter the first num: ");
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second num : ");
            second = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the third num :");
            third = int.Parse(Console.ReadLine());
            if (first >= second && first >= third)
            {
                max = first;
            }
            else if (second >= first && second >= third)
            {
                max = second;
            }
            else
            {
                max = third;
            }

            if (first <= second && first <= third)
            {
                min = first;
            }
            else if (second <= first && second <= third)
            {
                min = second;
            }
            else
            {
                min = third;
            }

            Console.WriteLine($"Max element =  {max}");
            Console.WriteLine($"Min element = {min}");

            // 11- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            Console.Write("Enter an integer number: ");
            int numb = int.Parse(Console.ReadLine());

            if (numb % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            //12 - Write a program that takes character from the user then
            //if it is a vowel chars(a, e, I, o, u) then print(vowel) otherwise print(consonant).
            //Example(1)
            //Input: O
            //Output: vowel
            //Example(2)
            //Input: b
            //Output: Consonant

            Console.Write("Enter a character: ");
            char ch = char.Parse(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

            //13- Write a program to input the month number and print the number of days in that month.
            //Example
            //Input: Month Number: 1
            // Output: Days in Month: 31

            Console.Write("Enter Month Number: ");
            int month1 = int.Parse(Console.ReadLine());

            switch (month1)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Days in Month: 31");
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Days in Month: 30");
                    break;

                case 2:
                    Console.WriteLine("Days in Month: 28");
                    break;

                default:
                    Console.WriteLine("Invalid Month Number");
                    break;



            }

            //looping 
            //1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //        Example
            //        Input: 5
            //Output: 1, 2, 3, 4, 5

            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number1; i++)
            {
                Console.Write(i);


            }

            //2- Write a program that allows the user to insert an integer then 
            //        print a multiplication table up to 12.
            //Example
            //Input: 5
            //Outputs: 5 10 15 20 25 30 35 40 45 50 55 60
            Console.Write("Enter a number: ");
            int number22 =int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(number22 * i + " ||||||");
            }

            // 3 - Write a program that allows to user to insert number then print all even numbers
            // between 1 to this number
            //   Example:
            //   Input: 15
            //Output: 2 4 6 8 10 12 14
            Console.WriteLine("enter number");
            int number100 = int.Parse(Console.ReadLine());
            for (int i = 1,i <= number100,i++)
            {
                if (number100 % 2 == 0)
                {
                    Console.WriteLine($"{number100}  |||||");
                }
            }

            //4 - Write a program to enter marks of five subjects and calculate total, average and percentage.
            //    Example
            //    Input: -Enter Marks of five subjects: 95 76 58 90 89
            //    Output: Total marks = 408
            //Average Marks = 81
            //Percentage = 81
            int sub1, sub2, sub3, sub4, sub5;
            int total;
            double average, percentage;

            Console.Write("Enter marks of five subjects: ");

            sub1 = int.Parse(Console.ReadLine());
            sub2 = int.Parse(Console.ReadLine());
            sub3 = int.Parse(Console.ReadLine());
            sub4 = int.Parse(Console.ReadLine());
            sub5 = int.Parse(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;

            average = total / 5.0;

            percentage = (total / 500.0) * 100;

            Console.WriteLine($"Total marks =  {total}");
            Console.WriteLine($"Average Marks = { average}");
            Console.WriteLine($"Percentage = {percentage}");

            //            5 - Write a program in C# Sharp to find prime numbers within a range of numbers.
            //Test Data:
            //            Input starting number of ranges: 1
            //Input ending number of range: 50

            //Expected Output :
            //The prime number between 1 and 50 are:
            //            2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
            Console.Write("Input starting number of range: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Input ending number of range: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine("The prime number between " + start + " and " + end + " are:");

            for (int number12 = start; number12 <= end; number12++)
            {
                bool isPrime = true;

                if (number12 < 2)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i < number12; i++)
                    {
                        if (number12 % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.Write(number12 + " ");
                }
            }


        }
    }
}
