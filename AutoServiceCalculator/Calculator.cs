using System;

namespace AutoServiceCalculator
{
    public class Calculator
    {
        const decimal TAX = .06m;
        const decimal LABOR_RATE = 20.00m;
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
            return _laborhours * LABOR_RATE;
        }
        public decimal getTax()
        {
            return _partprice * TAX;
        }
        public decimal calculateTotal()
        {
            return Math.Round(this.Partprice + getTax() + getLaborCharge(), 2);
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
    public class RadiatorFlush : Calculator
    {
        public RadiatorFlush()
        {
            _partname = "radiator fluid";
            _partprice = 5.00m;
            _laborhours = 1.25m;
        }
    }
    public class TransmissionFlush : Calculator
    {
        public TransmissionFlush()
        {
            _partname = "transmission fluid";
            _partprice = 15.00m;
            _laborhours = 3.25m;
        }
    }
    public class MufflerReplacement : Calculator
    {
        public MufflerReplacement()
        {
            _partname = "muffler";
            _partprice = 60.00m;
            _laborhours = 2.0m;
        }
    }
}
