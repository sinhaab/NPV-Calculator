using System;
namespace Core.BusinessService.Interface
{
    public interface INPVCalculatorService
    {
        //decimal NetPresentValue(decimal rate, decimal[] cashFlow);
        decimal GetNPV(decimal discountRate, decimal lowerBoundRate, decimal upperBoundRate);
     }
}
