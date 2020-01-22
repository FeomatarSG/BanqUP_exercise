using System;
using System.Linq;
using System.Text.RegularExpressions;
using BanqUP_exercise.Code;

namespace BanqUP_exercise.Code
{
    class OperationManager
    {
        string inputString = "";
        public OperationManager(string input)
        {
            this.inputString = input;
        }

        public string GetResult()
        {
            var multiplyAndDivRegex = @"\d+(?:\,\d+)?[\*\/]\d+(?:\,\d+)?";
            var addAndSubRegex = @"\d+(?:\,\d+)?[\+\-]\d+(?:\,\d+)?";

            var replaceNumber = "";
            while (Regex.Match(inputString, multiplyAndDivRegex).Success)
            {
                var operationToDo = Regex.Match(inputString, multiplyAndDivRegex).Value;
                MathematicOperation newOperation;
                if (operationToDo.Contains('*'))
                    newOperation = new MultiplyOperation(operationToDo);
                else
                    newOperation = new DivisionOperation(operationToDo);
                replaceNumber = newOperation.Calculation();
                this.inputString = this.inputString.Replace(operationToDo, replaceNumber);
            }
            while (Regex.Match(inputString, addAndSubRegex).Success)
            {
                var operationToDo = Regex.Match(inputString, addAndSubRegex).Value;
                MathematicOperation newOperation;
                if (operationToDo.Contains('+'))
                    newOperation = new AddOperation(operationToDo);
                else
                    newOperation = new SubstractionOperation(operationToDo);
                replaceNumber = newOperation.Calculation();
                this.inputString = this.inputString.Replace(operationToDo, replaceNumber);
            }
            return inputString;
        }
    }
}
