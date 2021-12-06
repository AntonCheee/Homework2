using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //double result = Task1(double.Parse(EnterNumber()), double.Parse(EnterNumber()));
            // int result = Task2(double.Parse(EnterNumber()), double.Parse(EnterNumber()));
            (int, int, int) result = Task3(int.Parse(EnterNumber()), int.Parse(EnterNumber()), int.Parse(EnterNumber()));
            //(double, double) result = Task4(double.Parse(EnterNumber()), double.Parse(EnterNumber()), double.Parse(EnterNumber()));
            //string result = Task5(int.Parse(EnterNumber()));

            Console.WriteLine(result);
        }

        public static double Task1(double a, double b)
        {
            if (a > b)
            {
                return a + b;
            }
            else if (a < b)
            {
                return a - b;
            }
            else
            {
                return a * b;
            }
        }

        public static int Task2(double x, double y)
        {
            int result;
            switch (x, y)
            {
                case ( > 0, > 0):
                    result = 1;
                    break;
                case ( > 0, < 0):
                    result = 2;
                    break;
                case ( < 0, < 0):
                    result = 3;
                    break;
                case ( < 0, > 0):
                    result = 4;
                    break;
                default:
                    result = 0;
                    break;
            }
            return result;
        }

        public static (int, int, int) Task3(int a, int b, int c)
        {
            int min = a, mid = b, max = c;

            if (min > mid)
            {
                Swap(ref min, ref mid);
            }
            if (min > max)
            {
                Swap(ref min, ref max);
            }
            if (mid > max)
            {
                Swap(ref mid, ref max);
            }
            return (min, mid, max);
        }

        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static (double, double) Task4(double a, double b, double c)
        {
            if (a != 0)
            {
                double discriminant = b * b - 4 * a * c;
                if (discriminant >= 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    return (x1, x2);
                }
                else
                {
                    throw new NotImplementedException("There is no solution of quadratic equation");
                }
            }
            else
            {            
                throw new NotImplementedException("There is no solution of quadratic equation");
            }
        }

        public static string Task5(int number)
        {
            string textValue = string.Empty;
            if (number >= 10 && number <= 19)
            {
                switch (number)
                {
                    case 10:
                        textValue = "ten";
                        break;
                    case 11:
                        textValue = "eleven";
                        break;
                    case 12:
                        textValue = "twelve";
                        break;
                    case 13:
                        textValue = "thirteen";
                        break;
                    case 14:
                        textValue = "fourteen";
                        break;
                    case 15:
                        textValue = "fifteen";
                        break;
                    case 16:
                        textValue = "sixteen";
                        break;
                    case 17:
                        textValue = "seventeen";
                        break;
                    case 18:
                        textValue = "eighteen";
                        break;
                    case 19:
                        textValue = "nineteen";
                        break;
                }
            }
            else
            {
                int tens = number / 10;
                int units = number % 10;

                switch (tens)
                {
                    case 2:
                        textValue += "twenty";
                        break;
                    case 3:
                        textValue += "thirty";
                        break;
                    case 4:
                        textValue += "forty";
                        break;
                    case 5:
                        textValue += "fifty";
                        break;
                    case 6:
                        textValue += "sixty";
                        break;
                    case 7:
                        textValue += "seventy";
                        break;
                    case 8:
                        textValue += "eighty";
                        break;
                    case 9:
                        textValue += "ninety";
                        break;
                }

                switch (units)
                {
                    case 1:
                        textValue += "-one";
                        break;
                    case 2:
                        textValue += "-two";
                        break;
                    case 3:
                        textValue += "-three";
                        break;
                    case 4:
                        textValue += "-four";
                        break;
                    case 5:
                        textValue += "-five";
                        break;
                    case 6:
                        textValue += "-six";
                        break;
                    case 7:
                        textValue += "-seven";
                        break;
                    case 8:
                        textValue += "-eight";
                        break;
                    case 9:
                        textValue += "-nine";
                        break;
                    default:
                        textValue += "";
                        break;
                }
            }
            return textValue;
        }

        private static string EnterNumber()
        {
            return Console.ReadLine();
        }
    }
}
