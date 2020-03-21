# First study C#
c# is very similar to Java   
c# source code must have Main() Method and it is only one. Main() 
this file is studies for Console.WriteLine, Console.ReadLine and Global, local variable

## 1. Console.WriteLine(), Console.ReadLine()
both Method real full name is "System.Console.~()"   
if you declare "using System" then you can remove "System."   
Console.WriteLine() is the printf() in C
Example for Console.WriteLine()

    class Program
    {
      static void main(string[] args)
      {
        Console.WriteLine("Hello World");
      }
    }
is equal to

    int main()
    {
      printf("Hello World");
    }

Console.ReadLine() is the scanf() in C   
Example for Console.ReadLine()

    class Program
    {
     static void main(string[] args)
     {
      string a;
      a = Console.ReadLine();
     }
    }

is equal to

    int main()
    {
     char a[50];
     scanf("%s",a);
    }

if you want to input Numeric thing (ex. int)   
using Convert.To~() or ~.Parse()   
Example

    class Program
    {
     static void main(string[] args)
     {
      int a;
      a = Convert.ToInt32(Console.ReadLine());
     }
    }

because Console.ReadLine() read for string matrial so if you want to Input Numeric Must using Covert.To~(), ~.Parse() Don't Forget it   
## 2. Global, Local variable   
in C# coding Global and Local variable have little different   
if you do not init Global variable, it will init 0 automatically but Local varialbe does not equal.   
if you do not init Local variable, the program will be crashed.   
So if you make C# program, you must remember this rule.  
Example

    using System;
    class example
    {
        int global;
        public void Method()
        {
            int local;
            local = 200;
            Console.WriteLine("init global var : {0}",global);
            Console.WriteLine("Local var : {0}",local);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CS obj = new CS();
            obj.Method();
        }
    } 

this code result is 

    init global var : 0 
    Local var : 200 
    
and if you don't init local variable in Method(), the program will be crashed   
   
*Try this simple code and study Interesting C#*   
If you have any question about this code, send email   
tmdrl5661@gmail.com

      
