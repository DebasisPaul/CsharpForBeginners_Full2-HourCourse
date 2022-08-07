// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// =======================================================

/*string aFriend = "Scott";
Console.WriteLine($"Hello {aFriend}");*/

// ========================================================

// C#: The Basics of Strings
// Multiple Comment Keyboard Shortcot command "Alt+Shift+A"
/* string firstFriend = "Scott";
string secondFriend = "Kendra";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters."); */

// =========================================================

//Do More With Strings
/* string greeting = "      Hello World!      ";
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();
Console.WriteLine($"[{trimmedGreeting}]"); */

// ===========================================================

/* string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Kendra");
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower()); */

// ============================================================

// Searching String

/* string songLyrics = "You say greetings, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));
Console.WriteLine(songLyrics.Contains("greetings")); */

/* string songLyrics = "You say greetings, and I say hello";

var result = songLyrics.Contains("goodbye");
Console.WriteLine(result);
Console.WriteLine(songLyrics.Contains("greetings")); */

/* string songLyrics = "You say greetings, and I say hello";

var result = songLyrics.StartsWith("You");
Console.WriteLine(result);
Console.WriteLine(songLyrics.Contains("greetings")); */

// ===========================================================================

// Numbers & Integer Math In C#

/* int a = 18;
int b = 6;
// int c = a + b;
// int c = a * b;
// int c = a / b;
int c = a - b;
Console.WriteLine(c); */

/* int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d); */

/* int a = 5;
int b = 4;
int c = 2;
int d = (a + b) * c;
Console.WriteLine(d); */

/* int a = 5;
int b = 4;
int c = 2;
int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
Console.WriteLine(d); */

/* int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
Console.WriteLine(d); */

// =======================================================================

// C#: Numbers & Integer Precision

/* int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}"); */

/* int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");

int what = max + 3;
Console.WriteLine($"An example of overflow: {what}"); */

/* double a = 5;
double b = 4;
double c = 2;
double d = (a + b) / c;
Console.WriteLine(d); */

/* double a = 19;
double b = 23;
double c = 8;
double d = (a + b) / c;
Console.WriteLine(d); */

/* double max = double.MaxValue;
double min = double.MinValue;
Console.WriteLine($"The range of double is {min} to {max}"); */


/* double third = 1.0 / 3.0;
Console.WriteLine(third); */

// ===============================================================================

// C#: Numbers and Decimals

/* decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;

Console.WriteLine($"The renge of the decimal type is {min} to {max}"); */

/* double a = 1.0;
double b = 3.0;
Console.WriteLine(a / b);

decimal c = 1.0M;
decimal d = 3.0M;
Console.WriteLine(c / d);

decimal min = decimal.MinValue;
decimal max = decimal.MaxValue;
Console.WriteLine($"The range of the decimal type is {min} to {max}");

int min2 = int.MinValue;
int max2 = int.MaxValue;
Console.WriteLine($"The range of the int type is {min2} to {max2}");

long min3 = long.MinValue;
long max3 = long.MaxValue;
Console.WriteLine($"The range of the long type is {min3} to {max3}");

short min4 = short.MinValue;
short max4 = short.MaxValue;
Console.WriteLine($"The range of the short type is {min4} to {max4}");


double radius = 2.50;
double area = Math.PI * radius * radius;
Console.WriteLine(area); */

// ========================================================================

// C#: Branches (if)

/* using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 100;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");
        }
    }
} */

/* using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 100;

            bool something = a + b > 10;

            if (something)
                Console.WriteLine("The answer is greater than 10.");
        }
    }
}  */

/* using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10"); 
            }

        }
    }
} */

/* using System;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 3;
            int c = 4;
            // if ((a + b + c > 10) && (a == b))
            if((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second number");
            }
        }
    }
} */

// ===============================================================================================

// C#: "Hello World" Explained

/* using System;

// using statements & c# are just importing other libraries. you may want to be using. Console uses the system library. So its in blue font.

namespace ConsoleApp6

// namespaces are basically just used to group in orgaize code. so if you have multiple different classes & all are very related  then group them in a smae namespace. 

{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");
            Console.WriteLine("Hello World");

            // Console is a Class & namespace is the envelop with the package Comes with the other staff.
        }
     }
 } */

 // ===========================================================================================

 // C#: What are Loops?

/*  using System;
 namespace ConsoleApp6
 {
    class Program
    {
        static void Main(string[] args)
        {
            // int counter = 0;

            short counter = 0;
            // while (counter < 10)
            while (true)
            {
                Console.WriteLine($"Hello World! The counter is {counter} ");
                counter++;
            }
        }
    }
 } */

/*  using System;
 namespace ConsoleApp6
 {
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            // int counter = 10;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }
    }
 } */

/*  using System;
 namespace ConsoleApp6
 {
    class Program
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }

        }
    }
 } */

 // =====================================================================================

 // C#: Combining Branches and Loops

 /* using System;

 namespace ConsoleApp6
 {
    static void Main(string[] args)
    {
        int sum = 0;
        for (int number = 1; number < 21; number++)
        {
        if (number % 3 == 0)
        {
            sum = sum + number;
        }
        }
        Console.WriteLine($"The sum is {sum}");
    }
 } */

 // =====================================================================================

 // C#: Arrays, List, and Collections

 /* using System;
 using System.Collections.Generic;

 namespace ConsoleApp6
 {
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"<name>", "Ana", "Felipe"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"Hello {names[i].ToUpper()}!");
            }
        }
    }
 } */

     /*    // Console.WriteLine();
        var names = new List<string> {"WEIRED", "Scott", "Kendra"};
        names.Add("Maria");
        names.Add("Bill");
        names.Remove("Scott");
        foreach (var name in names)
        {
            //Console.WriteLine($"Hello {name.ToUpper()}!");
            Console.WriteLine(name);
        }

        Console.WriteLine(names[0]);
   */

   // =================================================================================

   // C#: Sort, Search, and Index Lists


     /*     var names = new List<string> {"Hey Friend", "Scott", "Kendra"};
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Scott");

            names.Sort();
            foreach(var name in names)
            {
               // Console.WriteLine(name);
               Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            // Console.WriteLine(names[0]); */


/* var index = names.Indexof("Felipe");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}

index = names.IndexOf("Not Found");
if(index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}")
}
else
{
    Console.WriteLine($"The name {names[index]} is at index {index}")
} */
   

/*    WorkWithString();

   void WorkWithString()
   {
    var names = new List<string> { "<name>", "ana", "Felipe" };
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}");
    }
    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");
    foreach (var name in names)
    {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"My name is {names[0]}");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

    Console.WriteLine($"The list has {names.Count} people in it");

    var index = names.IndexOf("Felipe");
    if (index == -1)
    {
        Console.WriteLine($"when an item is not found, IndexOf returns {index}");
    }
    else
    {
        Console.WriteLine($"The name {names[index]} is at index {index}" );
    }
        index = names.IndexOf("Felipe");
        if (index == -1)
        {
            Console.WriteLine($"When an item is not found, IndexOf returns {index}");
        }
        else
        {
            Console.WriteLine($"The name {names[index]} is at index {index}");
        }

        index = names.IndexOf("Not Found");
        if (index == -1)
        {
            Console.WriteLine($"When an item is not found, IndexOf returns {index}");
        }
        else
        {
            Console.WriteLine($"The name {names[index]} is at index");
        }

        names.Sort();
        foreach (var name in names)
        {
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    } */

    // ================================================================

    // C#: Lists of Other Types

 /*    using System;
    using System.Collections.Generic;

    namespace list_tutorial
    {
        class Program
        {
            static void Main(string[] args)
            {
                var fibonacciNumbers = new List<int> { 1, 1 };

                while (fibonacciNumbers.Count < 20)
                {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
                }

                foreach (var item in fibonacciNumbers)
                    Console.WriteLine(item);
            }
        }
    
    } */

    // ===============================================================================

    // C#: Debugging

   /*   using System;
    using System.Collections.Generic;

    namespace list_tutorial
    {
        class Program
        {
            static void Main(string[] args)
            {
                var fibonacciNumbers = new List<int> { 1, 1 };

                while (fibonacciNumbers.Count < 20)
                {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
                }

                foreach (var item in fibonacciNumbers)
                    Console.WriteLine(item);
            }
        }
    
    }  */

