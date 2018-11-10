using System;
using System.Collections;

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
            var upperCaseNames = new ArrayList();
            var lowerCaseNames = new ArrayList();
            for (int z = 0; z < multipleNames.Length; z++)
            {
                if (multipleNames[z] == multipleNames[z].ToUpper())
                {
                    upperCaseNames.Add(multipleNames[z]);
                }
                else
                {
                    lowerCaseNames.Add(multipleNames[z]);
                }
            }
            
            if (lowerCaseNames.Count == 2)
                greeting += lowerCaseNames[0] + " and " + lowerCaseNames[1].ToString() + ".";
            if (lowerCaseNames.Count > 2)
            {
                for (int i = 0; i < lowerCaseNames.Count -1; i++)
                {
                    greeting += lowerCaseNames[i].ToString() + ", ";
                }

                greeting += "and " + lowerCaseNames[lowerCaseNames.Count -1] + ".";
            }

            if (upperCaseNames.Count > 0)
            {
                greeting += " AND HELLO " + upperCaseNames[0] +"!";
            }
//            return lowerCaseNames[3].ToString();
            return greeting;
        }

    }
}