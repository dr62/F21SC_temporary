/* Time-stamp: <Thu Jul 15 2021 12:54:58 hwloidl>

   Exercise 3h from the Lecture on C# Fundamentals (F20SC/F21SC)

   Task: Implement the greatest common divisor of two integer values using the Euclidean Algorithm
   Input: Take two integers from the command line; see the CmdLineInput.cs example for a template
   See:  https://en.wikipedia.org/wiki/Greatest_common_divisor#Euclidean_algorithm 

   Compile: mcs -out:gcd.exe gcd.cs
   Run:     mono ./gcd.exe 25 75

*/

using System;

public class GCD {
  // Use this main function, without changing the output, for automated testing via gitlab-CI
  public static void Main (string []args) {
     if (args.Length != 2) {               // expect 2 args: x and y
       System.Console.WriteLine("Usage: gcd <int> <int>");
     } else {
       int x = Convert.ToInt32(args[0]);   // read an integer value as 1st argument from the command-line
       int y = Convert.ToInt32(args[1]);   // read an integer value as 2nd argument from the command-line
       System.Console.WriteLine("gcd({0},{1}) = {2}", x, y, GCD.gcd(x,y));
     }
  }

  // MAIN TASK to implement  
  public static int gcd (int x, int y) {
      // *** COMPLETE THIS CODE ***
      if (x == 0)
        return y;

      return GCD.gcd(y % x, x);
  }
}
