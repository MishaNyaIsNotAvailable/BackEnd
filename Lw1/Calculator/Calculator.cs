namespace Calculator
{
    class Calculator
    {
        private double x, y;
        private int operationKey;

        public void InputOperation()
        {
            bool operationNotFound = true;
            while (operationNotFound)
            {
                Console.WriteLine("Operations:\n" +
                "0 for exit\n" +
                "1 for + \n" +
                "2 for - \n" +
                "3 for * \n" +
                "4 for / \n");
                Console.WriteLine("Enter operation:");

                try
                {
                    operationKey = Convert.ToInt32(Console.ReadLine());

                    if (operationKey < 0 || operationKey > 4)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Incorect operation number");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (operationKey == 0)
                        {
                            Console.WriteLine("Exiting...");
                            System.Environment.Exit(1);
                        }

                        operationNotFound = false;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorect operation format");
                    Console.ResetColor();
                }
            }
        }

        public void InputOperands()
        {
            bool operandNotFound = true;
            while (operandNotFound)
            {
                Console.WriteLine("Enter 1 operand: ");

                try
                {
                    x = Convert.ToDouble(Console.ReadLine());
                    operandNotFound = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorect number format");
                    Console.ResetColor();
                }
            }

            operandNotFound = true;
            while (operandNotFound)
            {
                Console.WriteLine("Enter 2 operand: ");

                try
                {
                    y = Convert.ToDouble(Console.ReadLine());
                    operandNotFound = false;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorect number format");
                    Console.ResetColor();
                }
            }
        }
        public void PerformOperation()
        {
            switch(operationKey)
            {
                case 1:
                    Console.WriteLine(x + " + " + y + " = " + (x + y));
                    break;
                case 2:
                    Console.WriteLine(x + " - " + y + " = " + (x - y));
                    break;
                case 3:
                    Console.WriteLine(x + " * " + y + " = " + (x * y));
                    break;
                case 4:
                    if (y != 0)
                    {
                        Console.WriteLine(x + " / " + y + " = " + (x / y));
                    }
                    else
                    {
                        Console.WriteLine("Can't divide by zero");
                    }
                    break;
            }
        }
    }
}