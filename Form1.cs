using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrdersProject
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        double SizeCost = 0;
        double CrustCost = 0;
        double ToppingsCost = 0;
        double PlaceCost = 0;


        double Calculate_TotalPrice()
        {
            return SizeCost + CrustCost + ToppingsCost + PlaceCost;
        }

        private void Frm1_Load(object sender, EventArgs e)
        {
            rdThinCrust.Checked = true;
            rdEatIn.Checked = true;
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            lbSizeSummary.Text = "Small";
            SizeCost = Convert.ToDouble(rdSmall.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void rdMedium_CheckedChanged(object sender, EventArgs e)
        {
            lbSizeSummary.Text = "Medium";
            SizeCost = Convert.ToDouble(rdMedium.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void rdLarge_CheckedChanged(object sender, EventArgs e)
        {
            lbSizeSummary.Text = "Large";
            SizeCost = Convert.ToDouble(rdLarge.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            labCrustTypeSummary.Text = "Thin Crust";
            CrustCost = Convert.ToDouble(rdThinCrust.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void rdThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            labCrustTypeSummary.Text = "Thick Crust";
            CrustCost = Convert.ToDouble(rdThickCrust.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        void UpdateToppingsSummary()
        {
            string Toppings = "";

            if (chkExtraChees.Checked)
                Toppings = "Extra Chees";

            if (chkOnion.Checked)
                Toppings += ", Onion";

            if (chkMushrooms.Checked)
                Toppings += ", Mushrooms";

            if (chkOlives.Checked)
                Toppings += ", Olives";

            if (chkTomatoes.Checked)
                Toppings += ", Tomatoes";

            if (chkGreenPeppers.Checked)
                Toppings += ", Green Peppers";

            if (Toppings.StartsWith(","))
                Toppings = Toppings.Substring(2, Toppings.Length - 2);

            if (Toppings == "")
                Toppings = "No Toppings";

            lbToppingsSummary.Text = Toppings;
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();

            if (chkExtraChees.Checked)
                ToppingsCost += Convert.ToDouble(chkExtraChees.Tag);
            else
                ToppingsCost -= Convert.ToDouble(chkExtraChees.Tag);

            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();

            if (chkOnion.Checked)
                ToppingsCost += Convert.ToDouble(chkOnion.Tag);
            else
                ToppingsCost -= Convert.ToDouble(chkOnion.Tag);

            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();

            if (chkMushrooms.Checked)
                ToppingsCost += Convert.ToDouble(chkMushrooms.Tag);
            else
                ToppingsCost -= Convert.ToDouble(chkMushrooms.Tag);

            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();

            if (chkOlives.Checked)
                ToppingsCost += Convert.ToDouble(chkOlives.Tag);
            else
                ToppingsCost -= Convert.ToDouble(chkOlives.Tag);

            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();

            if (chkTomatoes.Checked)
                ToppingsCost += Convert.ToDouble(chkTomatoes.Tag);
            else
                ToppingsCost -= Convert.ToDouble(chkTomatoes.Tag);

            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsSummary();

            if (chkGreenPeppers.Checked)
                ToppingsCost += Convert.ToDouble(chkGreenPeppers.Tag);
            else
                ToppingsCost -= Convert.ToDouble(chkGreenPeppers.Tag);

            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void rdEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEatSummary.Text = "Eat In";
            PlaceCost = Convert.ToDouble(rdEatIn.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lbWhereToEatSummary.Text = "Take Out";
            PlaceCost = Convert.ToDouble(rdTakeOut.Tag);
            lbTotalPrice.Text = Calculate_TotalPrice().ToString();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm order", "Confirm",MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order placed successfully", "Done");

                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }
        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rdSmall.Checked = true;
            rdThinCrust.Checked = true;
            rdEatIn.Checked = true;

            chkExtraChees.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPeppers.Checked = false;
        }
    }
}