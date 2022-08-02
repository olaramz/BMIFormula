using BMIModel;
using MyLogic;
using System;

namespace BMIFormula
{
    public class Logic : ILogic
    {
        public double Formula(FormulaViewModel model)
        {
         var reply = model.killogram / model.metres;
            return reply;
        }
    }
}
