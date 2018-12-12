using System;
using System.Collections.Generic;
using System.Text;

namespace Prefab
{
    public class CalculationService : ICalculationService
    {
        public int CalculateSquare(int input)
        {
            return checked(input * input);
        }
    }
}
