using System.Drawing;
using System.Text;

namespace piz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lbSize.Text = "Small";
                return;
            }

            if (rbMoyen.Checked)
            {
                lbSize.Text = "Medium";
                return;
            }

            if (rbLarge.Checked)
            {
                lbSize.Text = "Large";
                return;
            }

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            StringBuilder sToppings = new StringBuilder();

            if (chkExtraSheese.Checked)
            {
                sToppings.Append("Extra Cheese");
            }

            if (chkOnion.Checked)
            {
                if (sToppings.Length > 0) sToppings.Append(", ");
                sToppings.Append("Onion");
            }

            if (chkMushrooms.Checked)
            {
                if (sToppings.Length > 0) sToppings.Append(", ");
                sToppings.Append("Mushrooms");
            }

            if (chkOlive.Checked)
            {
                if (sToppings.Length > 0) sToppings.Append(", ");
                sToppings.Append("Olives");
            }

            if (chkTomatoes.Checked)
            {
                if (sToppings.Length > 0) sToppings.Append(", ");
                sToppings.Append("Tomatoes");
            }

            if (chkGreenPaper.Checked)
            {
                if (sToppings.Length > 0) sToppings.Append(", ");
                sToppings.Append("Green Peppers");
            }

            lbToppings.Text = sToppings.Length > 0 ? sToppings.ToString() : "No Toppings";
        }





        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThinCrust.Checked)
            {
                lbCrusType.Text = "Thin Crust";
                return;
            }

            if (rbThinkCrust.Checked)
            {
                lbCrusType.Text = "Think Crust";
                return;
            }


        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
            {
                lbWhereToEat.Text = "Eat In.";
                return;
            }

            if (rbTakeOut.Checked)
            {
                lbWhereToEat.Text = "Take Out.";
                return;
            }

        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)

                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMoyen.Checked)

                return Convert.ToSingle(rbMoyen.Tag);

            else
                return Convert.ToSingle(rbLarge.Tag);

        }

        float CalculateToppingsPrice()
        {


            float ToppingsTotalPrice = 0;

            if (chkExtraSheese.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraSheese.Tag);
            }


            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlive.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlive.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }

            if (chkGreenPaper.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPaper.Tag);
            }



            return ToppingsTotalPrice;



        }

        float GetSelectedCrutPrice()
        {
            if (rbThinCrust.Checked)

                return Convert.ToSingle(rbThinCrust.Tag);

            else
                return Convert.ToSingle(rbThinkCrust.Tag);

        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrutPrice();
        }

        void UpdateTotalPrice()
        {

            lbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();

        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }

        void ResetForm()
        {

            //reset Groups
            gbSize.Enabled = true;
            gbTopping.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            //reset Size
            rbMoyen.Checked = true;

            //reset Toppings.
            chkExtraSheese.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkOlive.Checked = false;
            chkTomatoes.Checked = false;
            chkGreenPaper.Checked = false;

            //reset CrustType
            rbThinCrust.Checked = true;

            //reset Where to Eat
            rbEatIn.Checked = true;

            //Reset Order Button
            btOrderPizza.Enabled = true;

        }














        private void btOrderPizza_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbTopping.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;

            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

        private void rbEatIn_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThinCrust_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void chkGreenPaper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkExtraSheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbLarge_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMoyen_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }



    }
}
