using System;

namespace HesapMakinesi
{
    class Operation
    {
        public string firstTerm = "";
        public string oprSign = "";         // "+", "-", "x", "/", "%", "sq", "sqrt"
        public string secondTerm = "";
        public string whatToRead = "new";     // "I", "II", "new"
        public double result;

        public double oprResult(double first, string sign, double second)
        {
            switch (sign)
            {
                case "+":
                    return first + second;
                case "-":
                    return first - second;
                case "x":
                case "sq":
                    return first * second;
                case "/":
                    return first / second;
                case "%":
                    return (first / second) * 100;
                case "sqrt":
                    return Math.Sqrt(first);
                default:
                    return 0;
            }
        }
    }
}
