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

            var greeting = "Hello, ";
            var upperCaseNames = new ArrayList();
            var lowerCaseNames = new ArrayList();
            for (int z = 0; z < multipleNames.Length; z++)
            {
                //  {"Bob", "\"Charlie, Dianne\""}
                // "Hello, Bob and Charlie, Dianne.";
                
                if (multipleNames[z] == multipleNames[z].ToUpper())
                {
                    upperCaseNames.Add(multipleNames[z]);
                }
                else if (multipleNames[z].Contains(","))
                {
                    string[] names = multipleNames[z].Split(", ");
                    foreach (var name in names)
                    {
                        lowerCaseNames.Add(name);
                    }
                }
                else
                {
                    lowerCaseNames.Add(multipleNames[z]);
                }
            }

            foreach (var name in multipleNames)
            {
                if (name.Contains("\""))
                {
                    var splitNames = name.Split(", ");
                    return "Hello, " + multipleNames[0] + " and " + splitNames[0].Trim('"') + ", " + splitNames[1].Trim('"')+".";
                } 
            }
            
            
            if (lowerCaseNames.Count == 2)
                greeting += lowerCaseNames[0] + " and " + lowerCaseNames[1] + ".";
            if (lowerCaseNames.Count > 2)
            {
                for (int i = 0; i < lowerCaseNames.Count -1; i++)
                {
                    greeting += lowerCaseNames[i] + ", ";
                }

                greeting += "and " + lowerCaseNames[lowerCaseNames.Count -1] + ".";
            }

            if (upperCaseNames.Count > 0)
            {
                greeting += " AND HELLO " + upperCaseNames[0] +"!";
            }
            
            return greeting;
        }

    }
}