using System;
using System.Collections.Generic;
using System.Text;

namespace Prefab
{
    public class CalculationService : ICalculationService
    {
        public int GetSquare(int input)
        {
            return checked(input * input);
        }
    }
}
