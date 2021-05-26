using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{
    class CarInfo
    {
        string vehicleRegNo;
        string make;
        string EngineSize;
        double rentalcost;
        int available;
        DateTime DateRegistered;

        public CarInfo(string vehicleRegNo, string make, string engineSize, double rentalcost, int available, DateTime dateRegistered)
        {
            this.vehicleRegNo = vehicleRegNo;
            this.make = make;
            this.EngineSize = engineSize;
            this.rentalcost = rentalcost;
            this.available = available;
            this.DateRegistered = dateRegistered;
        }

        public string VehicleRegNo { get => vehicleRegNo; set => vehicleRegNo = value; }
        public string Make { get => make; set => make = value; }
        public string Engine_Size { get => EngineSize; set => EngineSize = value; }
        public double Rentalcost { get => rentalcost; set => rentalcost = value; }
        public int Available { get => available; set => available = value; }
        public DateTime Date_Registered { get => DateRegistered; set => DateRegistered = value; }
        
        public override string ToString()
        {
            string desc = this.vehicleRegNo.PadRight(12);
            desc += this.make.PadRight(20);
            desc += this.EngineSize.PadRight(6);
            
            desc += $"{this.Date_Registered:yyyy-MM-dd}".PadRight(12);
            desc += $"€{this.rentalcost:n2}".PadRight(10);
            if (this.available == 1)
            {
                desc += "Yes";
            }
            else
                desc += "No";
            return desc;
        }
    }
}
