using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagement
{
    public partial class Form1 : Form
    {
        private List<Truck> trucks = new List<Truck>();
        public Form1()
        {
            InitializeComponent();
        }

        private void trucksListBoxInfo()
        {
            lbShow.Items.Clear();

            foreach (Truck i in trucks)
            {
                lbShow.Items.Add(i.GetInfo());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string truckname = tbTruckName.Text;
            tbTruckName.Clear();
            int noOfPallets = Convert.ToInt32(tbMaxNoOfPallets.Text);
            tbMaxNoOfPallets.Clear();
            int noOfBoxes = Convert.ToInt32(tbMaxNoOfBoxesPerPallets.Text);
            tbMaxNoOfBoxesPerPallets.Clear();
            double costOfPallets = Convert.ToDouble(tbCostPerFullPallets.Text);
            tbCostPerFullPallets.Clear();
            double costOfBoxes = Convert.ToDouble(tbCostPerRemainingBox.Text);
            tbCostPerRemainingBox.Clear();

            Truck newTruck = new Truck(truckname, noOfPallets, noOfBoxes, costOfPallets, costOfBoxes);

            trucks.Add(newTruck);

            cbTruckList.Items.Add(newTruck.GetTruckName());

            trucksListBoxInfo();


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lbShow.SelectedIndex;
            //int index2 = cbTruckList.SelectedIndex;

            if (lbShow.SelectedIndex >= 0 /*&& cbTruckList.SelectedIndex >= 0*/)
            {
                lbShow.Items.RemoveAt(index);
                //cbTruckList.Items.RemoveAt(index2);
            }
        }

        private void btnRemovePlaceOrder_Click(object sender, EventArgs e)
        {
            int index = cbTruckList.SelectedIndex;

            if (cbTruckList.SelectedIndex >= 0)
            {
                cbTruckList.Items.RemoveAt(index);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Truck truck = TruckInfo(cbTruckList.Text);
            int boxes = Convert.ToInt32(tbToBeShipped.Text);

            lblResult.Text = ("The Total cost is € " + truck.CalculateCost(boxes));

        }

        private Truck TruckInfo(string name)
        {
            foreach (Truck truck in trucks)
            {
                if (truck.GetTruckName() == name)
                {
                    return truck;
                }
            }
            return null;


        }


    
    }
}
