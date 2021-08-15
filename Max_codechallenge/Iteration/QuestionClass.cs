using System;
using System.Collections.Generic;

namespace Iteration
{
    public static class QuestionClass
    {
        static List<string> NamesList = new List<string>() {
            "Jimmy",
            "Jeffrey",
            "John",
        };

        public static void Iterate()
        {
            var enumerator = NamesList.GetEnumerator();

            while (enumerator.MoveNext())
                Console.WriteLine(enumerator.Current);
        }
    }
}