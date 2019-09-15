using System;

namespace AutoServiceCalculator
{
    public class Calculator
    {
        string partname = "oil";
        decimal partprice = 11.00m;

        public string getOilChangePartName()
        {
            return partname;
        }

        public decimal getOilChangePartPrice()
        {
            return partprice;
        }
    }
}
