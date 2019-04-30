using System;
using System.Collections.Generic;
using Core.BusinessService.Interface;

namespace Core.BusinessService.Implementation
{
    public class NPVCalculatorService : INPVCalculatorService
    {
        #region constructor
        public NPVCalculatorService()
        {

        }
        #endregion

        #region public method
        public decimal GetNPV(decimal discountRate, decimal lowerBoundRate, decimal upperBoundRate)
        { 
            List<decimal> cashFlow = GetCashFlow(discountRate, lowerBoundRate, upperBoundRate);
            return InternalPresentValue(discountRate, cashFlow, 0);
        }
        #endregion

        #region private method

        private List<decimal> GetCashFlow(decimal discountRate, decimal lowerBoundRate, decimal upperBoundRate)
        {
            List<decimal> cashFlow = new List<decimal>();
            for(decimal x= lowerBoundRate; x <= upperBoundRate; x+= discountRate)
            {
                cashFlow.Add(x);
            }
            return cashFlow;
        }


        private  decimal InternalPresentValue(decimal rate, List<decimal> cashFlow,short paymentDueCollectable)
        {
            bool flagLessThenZero = paymentDueCollectable < 0;
            bool flagGreaterThenZero = paymentDueCollectable > 0;
            decimal auxiliaryValue = 1;
            decimal internalPresentValue = 0;

            foreach(var item in cashFlow)
            {
                auxiliaryValue += (auxiliaryValue * rate);
                internalPresentValue += (item / auxiliaryValue);
            }

       
            return internalPresentValue;
        }
        #endregion
    }
}


