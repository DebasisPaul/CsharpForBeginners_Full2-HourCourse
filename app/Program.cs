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

using System;
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
}