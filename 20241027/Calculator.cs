namespace _20241027
{
    public class Calculator
    {
        public void RunCalculator()
        {
            while (true)
            {
                OperationEnum? opEnum = null;
                do
                {
                    opEnum = GetOperations.GetOperationType();
                }
                while (opEnum == null);
                Console.Write("Input first number : ");
                decimal? num1 = null, num2 = null;
                do
                {
                    num1 = GetOperations.GetNumber();
                }
                while (num1 == null);
                Console.Write("Input second number : ");
                do
                {
                    num2 = GetOperations.GetNumber();
                }
                while (num2 == null);

                if (num1 != null && num2 != null)
                {
                    PerformAction(num1 ?? 0, num2 ?? 0, opEnum);
                }

            }
        }

        private void PerformAction(decimal num1, decimal num2, OperationEnum? opEnum)
        {
            if (num2 == 0 && (opEnum == OperationEnum.Div || opEnum == OperationEnum.Mod))
            {
                Console.WriteLine("Second number cannot be zero!!!");
            }

            decimal returnValue = opEnum switch
            {
                OperationEnum.Add => num1 + num2,
                OperationEnum.Sub => num1 - num2,
                OperationEnum.Mult => num1 * num2,
                OperationEnum.Div => num1 / num2,
                OperationEnum.Mod => num1 % num2,
            };
            Console.WriteLine($"The result is : {returnValue}");
        }

    }
}
