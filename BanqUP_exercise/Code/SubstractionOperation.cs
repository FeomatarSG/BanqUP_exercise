using System;
using BanqUP_exercise.Code;

namespace BanqUP_exercise.Code
{
    class SubstractionOperation: MathematicOperation
    {
        private const char operationCharacter = '-';
        public SubstractionOperation(string textToCalculate) : base(textToCalculate, operationCharacter)
        {
        }
        public override string Calculation()
        {
            return ((double)num1 - num2).ToString();
        }
    }
}
