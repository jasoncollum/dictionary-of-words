﻿using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
            wordsAndDefinitions.Add("Phenomenal", "The way Phenoms tend to feel");
            wordsAndDefinitions.Add("Confused", "Unable to think clearly, bewildered");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

            Console.WriteLine(wordsAndDefinitions["Phenomenal"]);
            Console.WriteLine(wordsAndDefinitions["Confused"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            }
        }
    }
}
