using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAndTesting
{
    // Модуль математических вычислений
    // КОРРЕКТНАЯ РАБОТА без потери точности гарантирована для чисел в дапазоне от -9.999999e+6 до 9.9999999e+7
    public class MathModule
    {
        public const double MAX_OPERAND_VAL = 9.9999999e+7, MIN_OPERAND_VAL = -9.999999e+6;
        public static void CheckOperands(double op1, double op2)
        {
            if (!(
                op1 <= MAX_OPERAND_VAL && op1 >= MIN_OPERAND_VAL && 
                op2 <= MAX_OPERAND_VAL && op2 >= MIN_OPERAND_VAL
                ))
            {
                throw new ArgumentException("Argument out of bounds");
            }
        }
        public static double Sum(double op1, double op2)
        {
            CheckOperands(op1, op2);
            return op1 + op2;
        }

        public static double Substract(double op1, double op2)
        {
            CheckOperands(op1, op2);
            return op1 - op2;
        }

        public static double Multiply(double op1, double op2)
        {
            CheckOperands(op1, op2);
            return op1 * op2;
        }

        // Точность возвращаемого значения - 14 дробных разрядов
        public static double Divide(double op1, double op2)
        {
            CheckOperands(op1, op2);
            double rawResult = op1 / op2;
            return Math.Round(rawResult, 14);
        }
    }
}
