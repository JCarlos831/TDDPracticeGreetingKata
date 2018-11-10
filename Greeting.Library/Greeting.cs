using System;

namespace Greeting.Library
{
    public class Greeting
    {
        public static string Greet()
        {
            return "Hello, my friend";
        }
        
        public static string Greet(string name)
        {
            if (name == name.ToUpper())
                return "HELLO " + name + "!";
            return "Hello, " + name;
        }
        
        public static string Greet(string[] multipleNames)
        {
//            {"Amy", "BRIAN", "Charlotte"};         
//             "Hello, Amy and Charlotte. AND HELLO BRIAN!";
            
            var greeting = "Hello, ";
            if (multipleNames.Length == 2)
                greeting += multipleNames[0] + " and " + multipleNames[1] + ".";
            if (multipleNames.Length > 2)
            {
                for (int i = 0; i < multipleNames.Length - 1; i++)
                {
                    greeting += multipleNames[i] + ", ";
                }

                greeting += "and " + multipleNames[multipleNames.Length - 1] + ".";
            }
            return greeting;
        }

    }
}