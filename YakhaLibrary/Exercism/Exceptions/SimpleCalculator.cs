using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakhaLibrary.Exercism.Exceptions
{
    public static class SimpleCalculator
    {
        public static string Calculate(int operand1, int operand2, string operation)
        {
            return operation switch
            {
                "/" => operand2 == 0 ? "Division by zero is not allowed." : $"{operand1} {operation} {operand2} = {operand1 / operand2}",
                "+" => $"{operand1} {operation} {operand2} = {operand1 + operand2}",
                "*" => $"{operand1} {operation} {operand2} = {operand1 * operand2}",
                "" => throw new ArgumentException(),
                null => throw new ArgumentNullException(),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
