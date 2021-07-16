namespace Calculator
{
    public class Calculator
    {
        public static double Calculate(double operand1, double operand2, OperationType operation)
        {
            return operation switch
            {
                OperationType.Plus => operand1 + operand2,
                OperationType.Minus => operand1 - operand2,
                OperationType.Divide => operand2 != 0 ? operand1 / operand2
                : throw new System.DivideByZeroException("You try to divide by 0"),
                OperationType.Multiply => operand1 * operand2,
                _ => throw new System.NotImplementedException("Unknown operation")
            };
        }

    }
}
