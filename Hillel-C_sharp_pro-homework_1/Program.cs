using Hillel_C_sharp_pro_homework_1;


while (true)
{
    double value;
    double value1;
    double value2;
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("-----------Calc-----------");
    Console.WriteLine("Please choose what you want to do");
    Console.WriteLine("--------------------------");
    Console.WriteLine("1. Add two numbers");
    Console.WriteLine("2. Subtract two numbers");
    Console.WriteLine("3. Multiply two numbers");
    Console.WriteLine("4. Divide the two numbers");
    Console.WriteLine("5. Raise a number to a power");
    Console.WriteLine("6. Take the root of the number");
    Console.WriteLine("7. Exit");
    Console.WriteLine("--------------------------");
    int key = int.Parse(Console.ReadLine());


    switch (key)
    {
        case 1:
            NumbersInput(out value1, out value2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Result: " + Calc.Addition(value1, value2));
            break;
        case 2:
            NumbersInput(out value1, out value2);
            Console.WriteLine("Result: " + Calc.Subtraction(value1, value2));
            break;
        case 3:
            NumbersInput(out value1, out value2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Result: " + Calc.Multiplication(value1, value2));
            break;
        case 4:
            NumbersInput(out value1, out value2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Result: " + Calc.Division(value1, value2));
            break;
        case 5:
            NumbersInput(out value1, out value2);
            Console.WriteLine("Result: " + Calc.Exponentation(value1, value2));
            break;
        case 6:
            NumberInput(out value);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Result: " + Calc.SquareRoot(value));
            break;
        case 7:
            return;
        default:
            Console.WriteLine("Wrong input! Please try again.");
            break;
    }

}

void NumbersInput(out double value1, out double value2)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter first number here -> ");
    value1 = double.Parse(Console.ReadLine());

    Console.Write("Enter second number here -> ");
    value2 = double.Parse(Console.ReadLine());
}

void NumberInput(out double value)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write("Enter number here -> ");
    value = double.Parse(Console.ReadLine());
}