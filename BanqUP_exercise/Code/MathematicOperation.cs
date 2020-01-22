using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanqUP_exercise.Code.Interfaces;

namespace BanqUP_exercise.Code
{
    abstract class MathematicOperation: IOperation
    {
        public MathematicOperation(string text, char operationCharacter)
        {
            num1 = Double.Parse(text.Substring(0, text.IndexOf(operationCharacter)));
            num2 = Double.Parse(text.Substring(text.IndexOf(operationCharacter)+1));
        }
        public double num1 { get; set; }
        public double num2 { get; set; }

        public abstract string Calculation();
    }
}
