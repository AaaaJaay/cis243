/* Jess Cruse
 * 6 Dec 2020
 * Week 1 - Assignment_1_Cruse 
 * Purpose: Greet the user then promtpt them to enter three integers.
 * Computes an average of the three entries.
 * Computes any remainder of the integer division
 */
using System;

namespace Assignment_1_Cruse
{
  class Program
  {
    static void Main(string[] args)
    { //declaring the variables used in this program
      string person = "Jess"; //variable that stores my name for greeting
      string number; //variable used to store the number the user enters
      string numberList = ""; //variable that stores the list of numbers entered
      int numberSum = 0; //variable that stores the sum of numbers entered
      int numberCount = 0; //variable that stores the times a number is entered
      int numberPass = 3; //variable that stores the number of times we will ask the user to enter a number

      //Greeting the user
      Console.WriteLine($"Hello world, this is {person}. Welcome to my first CIS 243 program!");

      //loop though the number of times specified by our numberCount variable
      while (numberCount < numberPass)
      {
        Console.Write("Enter an interger score:");
        number = Console.ReadLine();  //capturing the number entered by the user
        numberSum += Convert.ToInt32(number);  //adding the input number to our sum
        numberCount += 1;  // counting each time we loop through

        if (numberCount < numberPass)
        {//appending the new number to the end of the list
          numberList += number + ",";
        }
        else
        {// excluding the comma on the last number
          numberList += number;
        }
      }

      Console.WriteLine($"The average of {numberList} is {numberSum/numberCount} with a remainder of {numberSum%numberCount} ");
    }
  }
}
