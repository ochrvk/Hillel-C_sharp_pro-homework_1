namespace Hillel_C_sharp_pro_homework_1
{
    public static class Calc
    {
        public static double Addition(double value1, double value2)
        {
            return value1 + value2;
        }

        public static double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }

        public static double Multiplication(double value1, double value2)
        {
            return (value1 * value2);
        }

        public static double Division(double value1, double value2)
        {
            if (value2 == 0)
            {
                throw new Exception("division by zero");
            }
            else
            {
                return value1 / value2;

            }
        }

        public static double SquareRoot(double value)
        {
            return Math.Sqrt(value);
        }

        public static double Exponentation(double value1, double value2)
        {
            return Math.Pow(value1, value2);
        }
    }
}
