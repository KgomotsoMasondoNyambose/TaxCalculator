using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculator
{
    class cTax
    {
        public double item1;
        public double ncTax_Rate = 0.65;

        public double GetAmount()
        {
            return item1;
        }

        public Double cFindTax(double cAmount)
        {
            double FindTax = cAmount - (cAmount * ncTax_Rate);
            return FindTax;
        }

    }
}
