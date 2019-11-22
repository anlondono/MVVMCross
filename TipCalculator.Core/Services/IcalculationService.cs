using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator.Core.Services
{
    public interface IcalculatonService
    {
        decimal TipAmount(decimal subTotal, double generosity);
    }
}
