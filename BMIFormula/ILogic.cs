using BMIModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLogic
{
    public interface ILogic
    {
        double Formula(FormulaViewModel model);
    }
}
