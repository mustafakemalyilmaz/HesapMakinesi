namespace HesapMakinesi
{
    class Operation
    {
        public string firstTerm;
        public string secondTerm;
        public string firstOrSecond; // first true, second false


        public double operationResult(double first, double second, string sign)
        {
            if (sign == "+")
            {
                return first + second;
            } else if (sign == "-")
            {
                return first - second;
            } else if (sign == "x")
            {
                return first * second;
            } else if (sign == "/")
            {
                return first / second;

            } else
            {
                return (first / second) * 100;
            }

        }

    }
}
