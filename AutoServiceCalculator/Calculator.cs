using System;

namespace AutoServiceCalculator
{
    public class Calculator
    {
        private const double TAX = .06;
        protected string _partname { get; set; }
        protected double _partprice { get; set; }
        protected double _laborhours { get; set; }

        public Calculator()
        {
            _partname = "No part";
            _partprice = 0.0;
            _laborhours = 0.0;
        }
        public string Partname
        {
            get { return _partname; }
            set { _partname = value; }
        }
        public double Partprice
        {
            get { return _partprice; }
            set { _partprice = value; }
        }
        public double Laborhours
        {
            get { return _laborhours; }
            set { _laborhours = value; }
        }
        public double getLaborCharge()
        {
            return 15.00;
        }
        public double getTax()
        {
            return _partprice * .06;
        }
        public double calculateTotal()
        {
            return this.Partprice + getLaborCharge() + getTax();
        }
    }
    public class OilChange : Calculator
    { 
        public OilChange()
        {
            _partname = "oil";
            _partprice = 11.00;
            _laborhours = 0.45;
        }

    }
    public class LubeJob : Calculator
    {
        public LubeJob()
        {
            _partname = "grease";
            _partprice = 3.00;
            _laborhours = 0.45;
        }
    }
}
