// // Uncomment exercises below to run! // //

using System;
using System.Collections.Generic;

namespace ArrayListExercises
{
  class Program
  {
    /*
    When you post a message on Facebook, depending on the number of people who
    like your post, Facebook displays different information.

    If no one likes your post, it doesn't display anything. If only one person
    likes your post, it displays: [Friend's Name] likes your post. If two people
    like your post, it displays: [Friend 1] and [Friend 2] like your post. If
    more than two people like your post, it displays: [Friend 1], [Friend 2] and
    [Number of Other People] others like your post.

    Write a program and continuously ask the user to enter different names,
    until the user presses Enter (without supplying a name). Depending on the
    number of names provided, display a message based on the above pattern.
    */
    static void Main(string[] args)
    {
      var personsWhoLikedPost = new List<string>();
      var entry = "";
      do
      {
        Console.Write("Which friend liked your post?: ");
        entry = Console.ReadLine();
        if (entry != "")
        {
          personsWhoLikedPost.Add(entry);
        }
      }
      while (entry != "");

      if (personsWhoLikedPost.Count == 1)
      {
        Console.WriteLine($"{personsWhoLikedPost[0]} likes your post.");
      }
      else if (personsWhoLikedPost.Count == 2)
      {
        Console.WriteLine($"{personsWhoLikedPost[0]} and {personsWhoLikedPost[1]} like your post.");
      }
      else
      {
        Console.WriteLine($"{personsWhoLikedPost[0]}, {personsWhoLikedPost[1]}, and {personsWhoLikedPost.Count - 2} others like your post.");
      }
    }


    // /*
    // Write a program and ask the user to enter their name. Use an array to
    // reverse the name and then store the result in a new string. Display the
    // reversed name on the console.
    // */
    // static void Main(string[] args)
    // {
    //   Console.Write("Please enter your name: ");
    //   var input = Console.ReadLine();
    //   var inputList = new List<char>() { };
    //   var reversedInput = "";
    //   foreach (char character in input)
    //   {
    //     inputList.Add(character);
    //   }
    //   for (var i = input.Length - 1; i >= 0; i--)
    //   {
    //     reversedInput += inputList[i];
    //   }
    //   Console.WriteLine("New string: " + reversedInput);
    // }


    // /*
    // Write a program and ask the user to enter 5 numbers. If a number has been
    // previously entered, display an error message and ask the user to re-try.
    // Once the user successfully enters 5 unique numbers, sort them and display
    // the result on the console.
    // */
    // static void Main(string[] args)
    // {
    //   int num1 = 0;
    //   int num2 = 0;
    //   int num3 = 0;
    //   int num4 = 0;
    //   int num5 = 0;

    //   Console.WriteLine("Please enter five different numbers, one for each line.");
    //   Console.Write("First number: ");
    //   num1 = Convert.ToInt32(Console.ReadLine());

    //   do
    //   {
    //     Console.Write("Second number: ");
    //     num2 = Convert.ToInt32(Console.ReadLine());
    //     if (num2 == num1)
    //     {
    //       Console.Write("That number was already entered. Please enter another!");
    //     };
    //   } while (num2 == num1);
    //   do
    //   {
    //     Console.Write("Third number: ");
    //     num3 = Convert.ToInt32(Console.ReadLine());
    //     if (num3 == num1 || num3 == num2)
    //     {
    //       Console.Write("That number was already entered. Please enter another!");
    //     };
    //   }
    //   while (num3 == num1 || num3 == num2);
    //   do
    //   {
    //     Console.Write("Fourth number: ");
    //     num4 = Convert.ToInt32(Console.ReadLine());
    //     if (num4 == num1 || num4 == num2 || num4 == num3)
    //     {
    //       Console.Write("That number was already entered. Please enter another!");
    //     };
    //   }
    //   while (num4 == num1 || num4 == num2 || num4 == num3);
    //   do
    //   {
    //     Console.Write("Fifth number: ");
    //     num5 = Convert.ToInt32(Console.ReadLine());
    //     if (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4)
    //     {
    //       Console.Write("That number was already entered. Please enter another!");
    //     };
    //   }
    //   while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4);

    //   var inputArray = new int[5] { num1, num2, num3, num4, num5 };
    //   Array.Sort(inputArray);
    //   Console.Write("The sorted numbers are: ");
    //   foreach (var i in inputArray)
    //   {
    //     Console.Write(i.ToString() + " ");
    //   }
    // }


    // /*
    // Write a program and ask the user to continuously enter a number or type
    // "Quit" to exit. The list of numbers may include duplicates. Display the
    // unique numbers that the user has entered.
    // */
    // static void Main(string[] args)
    // {
    //   var input = "";
    //   var uniqueNumbers = new List<int>();

    //   while (input != "Quit")
    //   {
    //     Console.WriteLine("Enter a number or type [Quit] to quit the program");
    //     input = Console.ReadLine();
    //     if (input == "Quit")
    //     {
    //       Console.Write("Here are the unique values: ");
    //       foreach (int num in uniqueNumbers)
    //       {
    //         Console.Write($"{num} ");
    //       }
    //     }
    //     else if (!uniqueNumbers.Contains(Convert.ToInt32(input)))
    //     {
    //       uniqueNumbers.Add(Convert.ToInt32(input));
    //     }
    //   }
    // }


    // /*
    // Write a program and ask the user to supply a list of comma separated numbers
    // (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers,
    // display "Invalid List" and ask the user to re-try; otherwise, display the 3
    // smallest numbers in the list.
    // */
    // static void Main(string[] args)
    // {
    //   var inputList = new List<int>();
    //   Console.Write("Please enter a list of at least 5 comma separated numbers: ");
    //   do
    //   {
    //     var input = Console.ReadLine().Trim();
    //     var tempList = input.Split(",");
    //     foreach (var num in tempList)
    //     {
    //       inputList.Add(Convert.ToInt32(num));
    //     }

    //     if (inputList.Count < 5)
    //     {
    //       Console.WriteLine("Invalid List. Please enter a list of at least 5 comma separated numbers: ");
    //     }
    //     else
    //     {
    //       inputList.Sort();
    //       Console.WriteLine($"The 3 smallest numbers are: {inputList[0]}, {inputList[1]}, and {inputList[2]}");
    //     }
    //   } while (inputList.Count < 5);
    // }
  }
}
