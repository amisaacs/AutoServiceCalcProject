using System;

namespace AutoServiceCalculator
{
    public class Calculator
    {
        protected string _partname { get; set; }
        protected decimal _partprice { get; set; }

        public Calculator()
        {
            _partname = "No part";
            _partprice = 0.0m;
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
        /*
        public string getOilChangePartName()
        {
            return partname;
        }

        public decimal getOilChangePartPrice()
        {
            return partprice;
        }

        public string getLubeJobPartPrice()
        {
            return partname;
        }
        */
    }
    public class OilChange : Calculator
    { 
        public OilChange()
        {
            _partname = "oil";
            _partprice = 11.00m;
        }
    }
    public class LubeJob : Calculator
    {
        public LubeJob()
        {
            _partname = "grease";
            _partprice = 3.00m;
        }
    }
}
