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


