using System;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionClass.Iterate();

            TESTModule(1);
            TESTModule(2);
            TESTModule(3);
            TESTModule(4);
            TESTModule(5);

            try
            {
                TESTModule(-3);
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch
            {
            }

            TESTModule(1.0f);
            TESTModule(2.0f);
            TESTModule(3.0f);
            TESTModule("Sbrubles");
            TESTModule(10d);
            TESTModule(10m);
        }

        static object TESTModule(object input)
        {
            switch (input)
            {
                case int i when (i == 1 || i == 2 || i == 3 || i == 4):
                    return i * 2;

                case int i when i > 4:
                    return i * 3;

                case int i when i < 1:
                    throw new ArgumentOutOfRangeException();

                case float f when (f == 1.0f || f == 2.0f):
                    return 3.0f;

                case string s:
                    return s.ToUpper();

                default:
                    return input;
            }
        }
    }
}