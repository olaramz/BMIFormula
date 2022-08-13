using BMIModel;
using MyLogic;
using MyModel;
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
        public double multiply(MultiplyViewModel model)
        {
            var give = model.price * model.quantity;
            return give;
        }
    }
}
