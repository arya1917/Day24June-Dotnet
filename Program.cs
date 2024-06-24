// C# Program to Get the DayLight Saving Information
using System;

class Program
{
    static void Main()
    {
        TimeZoneInfo localZone = TimeZoneInfo.Local;
        Console.WriteLine("Local Time Zone: " + localZone.DisplayName);
        Console.WriteLine("Supports Daylight Saving Time: " + localZone.SupportsDaylightSavingTime);
        Console.WriteLine("Daylight Name: " + localZone.DaylightName);
        Console.WriteLine("Standard Name: " + localZone.StandardName);
    }
}

//C# Program to Create a Gray Code
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of bits: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Gray Code for {0} bits:", n);
        GenerateGrayCode(n);
    }

    static void GenerateGrayCode(int n)
    {
        int numCodes = 1 << n;
        for (int i = 0; i < numCodes; i++)
        {
            int gray = i ^ (i >> 1);
            Console.WriteLine(Convert.ToString(gray, 2).PadLeft(n, '0'));
        }
    }
}

// C# Program to Convert Celsius to Fahrenheit
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }
}

//C# Program to Get IP Address
using System;
using System.Net;

class Program
{
    static void Main()
    {
        Console.Write("Enter the hostname: ");
        string hostName = Console.ReadLine();
        IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
        foreach (IPAddress ip in hostEntry.AddressList)
        {
            Console.WriteLine("IP Address: " + ip);
        }
    }
}

//C# Program to Implement PhoneBook

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        while (true)
        {
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter phone number: ");
                string phone = Console.ReadLine();
                phoneBook[name] = phone;
            }
            else if (choice == 2)
            {
                foreach (var contact in phoneBook)
                {
                    Console.WriteLine("Name: {0}, Phone: {1}", contact.Key, contact.Value);
                }
            }
            else if (choice == 3)
            {
                break;
            }
        }
    }
}

//C# Program to Create a Stop Watch

using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        Console.WriteLine("Press 's' to start, 't' to stop, 'r' to reset, and 'e' to exit.");
        
        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.S)
            {
                stopwatch.Start();
                Console.WriteLine("Stopwatch started.");
            }
            else if (key == ConsoleKey.T)
            {
                stopwatch.Stop();
                Console.WriteLine("Elapsed Time: " + stopwatch.Elapsed);
            }
            else if (key == ConsoleKey.R)
            {
                stopwatch.Reset();
                Console.WriteLine("Stopwatch reset.");
            }
            else if (key == ConsoleKey.E)
            {
                break;
            }
        }
    }
}

//C# Program to Generate the Marksheet of the Student
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter student name: ");
        string name = Console.ReadLine();
        Console.Write("Enter number of subjects: ");
        int subjectsCount = int.Parse(Console.ReadLine());

        double totalMarks = 0;
        for (int i = 1; i <= subjectsCount; i++)
        {
            Console.Write("Enter marks for subject {0}: ", i);
            totalMarks += double.Parse(Console.ReadLine());
        }

        double percentage = (totalMarks / (subjectsCount * 100)) * 100;
        Console.WriteLine("Student Name: " + name);
        Console.WriteLine("Total Marks: " + totalMarks);
        Console.WriteLine("Percentage: " + percentage + "%");
    }
}

// C# Program to Convert Meter to Kilometer and Vice Versa
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. Convert Meter to Kilometer");
        Console.WriteLine("2. Convert Kilometer to Meter");
        Console.Write("Choose an option: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter distance in meters: ");
            double meters = double.Parse(Console.ReadLine());
            double kilometers = meters / 1000;
            Console.WriteLine("Distance in kilometers: " + kilometers);
        }
        else if (choice == 2)
        {
            Console.Write("Enter distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());
            double meters = kilometers * 1000;
            Console.WriteLine("Distance in meters: " + meters);
        }
    }
}

//C# Program to Display Square Feet of a House
 using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length of the house in feet: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width of the house in feet: ");
        double width = double.Parse(Console.ReadLine());
        double area = length * width;
        Console.WriteLine("Area of the house in square feet: " + area);
    }
}

//C# Program to Convert Infix to Postfix
using System;
using System.Collections.Generic;

class Program
{
    static int Precedence(char c)
    {
        if (c == '+' || c == '-') return 1;
        if (c == '*' || c == '/') return 2;
        return 0;
    }

    static string InfixToPostfix(string exp)
    {
        Stack<char> stack = new Stack<char>();
        string result = "";

        foreach (char c in exp)
        {
            if (char.IsLetterOrDigit(c))
            {
                result += c;
            }
            else if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                while (stack.Count > 0 && stack.Peek() != '(')
                {
                    result += stack.Pop();
                }
                stack.Pop();
            }
            else
            {
                while (stack.Count > 0 && Precedence(c) <= Precedence(stack.Peek()))
                {
                    result += stack.Pop();
                }
                stack.Push(c);
            }
        }

        while (stack.Count > 0)
        {
            result += stack.Pop();
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter infix expression: ");
        string infix = Console.ReadLine();
        string postfix = InfixToPostfix(infix);
        Console.WriteLine("Postfix expression: " + postfix);
    }
}
