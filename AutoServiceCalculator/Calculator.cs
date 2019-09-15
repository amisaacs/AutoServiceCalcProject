using System;

namespace AutoServiceCalculator
{
    public class Calculator
    {
        protected string _partname { get; set; }
        protected decimal _partprice { get; set; }
        protected decimal _laborhours { get; set; }

        public Calculator()
        {
            _partname = "No part";
            _partprice = 0.0m;
            _laborhours = 0.0m;
        }
        public string Partname
        {
            get { return _partname; }
            set { _partname = value; }
        }
        public decimal Partprice
        {
            get { return _partprice; }
            set { _partprice = value; }
        }
        public decimal Laborhours
        {
            get { return _laborhours; }
            set { _laborhours = value; }
        }
        public decimal getLaborCharge()
        {
            return _laborhours * 20;
        }
        public decimal getTax()
        {
            return 0.66m;
        }
        public decimal calculateTotal()
        {
            return 26.00m;
        }
    }
    public class OilChange : Calculator
    { 
        public OilChange()
        {
            _partname = "oil";
            _partprice = 11.00m;
            _laborhours = 0.75m;    //45 minutes
        }

    }
    public class LubeJob : Calculator
    {
        public LubeJob()
        {
            _partname = "grease";
            _partprice = 3.00m;
            _laborhours = 0.75m;    // 45 minutes
        }
    }
}
