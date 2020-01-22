using System;

namespace BanqUP_exercise.Code
{
    class AddOperation : MathematicOperation
    {
        private const char operationCharacter = '+';
        public AddOperation(string textToCalculate) : base(textToCalculate, operationCharacter)
        {
        }
        public override string Calculation()
        {
            return ((double)num1 + num2).ToString();
        }
    }
}
