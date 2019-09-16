using System;
using System.Collections.Generic;

namespace AutoServiceCalculator
{
    public class RepairBill
    {
        private const decimal LABOR_RATE = 20.00M;
        private const decimal TAX_RATE = .06m;
        protected List<Service> _servicesList { get; set; }
        protected decimal _partTotal { get; set; }

        public RepairBill()
        {
            _servicesList = new List<Service>();
        }
        public List<Service> setServices(Service s1, Service s2)
        {
            List<Service> list = new List<Service>{ s1,s2 };
            return list;
        }
        public List<Service> getServices()
        {
            return _servicesList;
        }
        public void addService(Service s1)
        {
            _servicesList.Add(s1);
        }
        public void removeService(Service service)
        {
            
        }
        public decimal getPartTotal()
        {
            decimal total = 0.0m;
            foreach (Service s in _servicesList)
            {
                total += s.Partprice;
            }
            return Math.Round(total,2);
        }
        public decimal getLaborhoursTotal()
        {
            decimal total = 0.0m;
            foreach(Service s in _servicesList)
            {
                total += s.Laborhours;
            }
            return Math.Round(total,2);
        }

        public decimal getLaborChargeTotal()
        {
            decimal total = 0.0m;
            foreach (Service s in _servicesList)
            {
                total += s.Laborhours;
            }
            return Math.Round(total * LABOR_RATE,2);

        }

        public decimal getTaxTotal()
        {
            decimal total = 0.0m;
            foreach (Service s in _servicesList)
            {
                total += s.Partprice;
            }
            return Math.Round(total * TAX_RATE,2);
        }
       

    }

    public class Service
    {
        protected string _partname { get; set; }
        protected decimal _partprice { get; set; }
        protected decimal _laborhours { get; set; }

        public Service()
        {
            _partname = "No part";
            _partprice = 0.00m;
            _laborhours = 0.00m;
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
        /*
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
        */
        public override bool Equals(object obj)
        {
            var other = obj as Service;

            if (other == null)
                return false;

            if (_partname != other.Partname || _partprice != other.Partprice)
                return false;

            return true;
        }
    }
    public class OilChange : Service
    {
        public OilChange()
        {
            _partname = "oil";
            _partprice = 11.00m;
            _laborhours = 0.75m;    //45 minutes
        }

    }
    public class LubeJob : Service
    {
        public LubeJob()
        {
            _partname = "grease";
            _partprice = 3.00m;
            _laborhours = 0.75m;    // 45 minutes
        }
    }
    public class RadiatorFlush : Service
    {
        public RadiatorFlush()
        {
            _partname = "radiator fluid";
            _partprice = 5.00m;
            _laborhours = 1.25m;
        }
    }
    public class TransmissionFlush : Service
    {
        public TransmissionFlush()
        {
            _partname = "transmission fluid";
            _partprice = 15.00m;
            _laborhours = 3.25m;
        }
    }
    public class MufflerReplacement : Service
    {
        public MufflerReplacement()
        {
            _partname = "muffler";
            _partprice = 60.00m;
            _laborhours = 2.0m;
        }
    }
    public class Inspection : Service
    {
        public Inspection()
        {
            _partname = "none";
            _partprice = 0.00m;
            _laborhours = 0.75m;
        }
    }
    public class TireRotation : Service
    {
        public TireRotation()
        {
            _partname = "none";
            _partprice = 0.00m;
            _laborhours = 1.0m;
        }
    }
}
