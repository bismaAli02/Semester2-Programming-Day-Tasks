using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App.BL
{
    class CalculatorClass
    {
        private static string operand1 = "";
        private static char op = ' ';
        private static string operand2 = "";

        public static string Operand1 { get => operand1; set => operand1 = value; }
        public static char Op { get => op; set => op = value; }
        public static string Operand2 { get => operand2; set => operand2 = value; }

        public static float PerformOperation()
        {
            float op1 = float.Parse(operand1);
            float op2 = float.Parse(operand2);
            if (op == '+')
            {
                return (op1 + op2);
            }
            else if (op == '-')
            {
                return (op1 - op2);
            }
            else if (op == '/')
            {
                return (op1 / op2);
            }
            else if (op == '*')
            {
                return (op1 * op2);
            }
            return 0;
        }
    }
}
