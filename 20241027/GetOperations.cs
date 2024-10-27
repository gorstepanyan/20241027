namespace _20241027
{
    public static class GetOperations
    {
        public static decimal? GetNumber()
        {
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal num1))
            {
                return num1;
            }
            Console.Write("Please enter a valid number : ");
            return null;
        }

        public static OperationEnum? GetOperationType()
        {
            Console.Write("Input one of these operations type '+,-,*,/,%' : ");
            string? operationType = Console.ReadLine();
            OperationEnum? result = operationType switch
            {
                "+" => OperationEnum.Add,
                "-" => OperationEnum.Sub,
                "*" => OperationEnum.Mult,
                "/" => OperationEnum.Div,
                "%" => OperationEnum.Mod,
                _ => null
            };
            if (result == null) Console.WriteLine("Please input valid operations type");
            return result;
        }
    }
}
