﻿namespace CalculatorVladDanil.OneArgument
{
    public class Factorial : IOneArgumentcalculator
    {
        public double OneArgumentOperation(double firstArgument)
        {
            int resultate = 1;

            for(int i = 1; i<firstArgument; i++)
            {
                resultate *= (int)firstArgument;
            }
            return resultate;
        }
    }
}
