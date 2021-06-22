//Hello World Explained with Scott and Kendra https://youtu.be/qmZ2RVZ4giY
//Using statements in C# are just importing other libraries
using System;

//Namespaces are used to group and organize code
//If you have multiple classes and they are all related, you may want to group them in the same namespace
//Whoa - System is a namespace!
namespace HelloWorldExplained
{
    
    class Program
    {
        //Every program needs a main method that we see as the entry point
        //This must be named Main
        //The main method also needs to be static - which means it is not going to change dynamically as the program is executing
        //All methods in C# need to specify if the method returns something or not
        static void Main(string[] args) //"A string array of arguments"
                                        //C# starts out with a string array of arguments
                                        //args is a variable that could be used in the method below!
        {
            //System.Console.WriteLine($"Hello World!"); //If I want to not have to use the using System; up top!
            Console.WriteLine("Hello World!");
        }
    }
}