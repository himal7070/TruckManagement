using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TruckManagement
{
    class Truck
    {
        private string truckName;
        private int noOfPallets;
        private int noOfBoxes;
        private double costOfPallets;
        private double costOfBoxes;


        public Truck(string truckname, int noOfPallets, int noOfBoxes, double costOfPallets, double costOfBoxes)
        {
            this.truckName = truckname;
            this.noOfPallets = noOfPallets;
            this.noOfBoxes = noOfBoxes;
            this.costOfPallets = costOfPallets;
            this.costOfBoxes = costOfBoxes;

        }

        public string GetTruckName()
        {
            return this.truckName;
        }


        public string GetInfo()
        {
            return $"Truck Name:{truckName} have capacity of Carrying {noOfPallets} pallets and {noOfBoxes} boxes ";
        }

        public double CalculateCost(int boxesToBeShipped)
        {
            int fullPallets = boxesToBeShipped / noOfBoxes;
            int RemainingBoxes = boxesToBeShipped % noOfBoxes;

            double totalCost = (fullPallets * costOfPallets) + (RemainingBoxes * costOfBoxes);

            return totalCost;



        }




    }
}
