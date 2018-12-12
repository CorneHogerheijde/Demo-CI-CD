using System;

namespace Prefab
{
    public class TheSystem
    {
        private readonly ICalculationService _calculationService;

        public TheSystem(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }

        public string ProcessUserInput(string userInput)
        {
            if (int.TryParse(userInput, out var inputNumber))
            {
                var output = _calculationService.CalculateSquare(inputNumber);
                return $"The square of {userInput} is {output}";
            }
            else
            {
                return "You're dead. That was not the requested number.";
            }
        }
    }
}
