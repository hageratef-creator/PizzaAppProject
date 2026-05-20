using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PizzaAppProject
{
    public partial class frmMakeOrder : Form
    {
        public frmMakeOrder()
        {
            InitializeComponent();
        }

        int TotalPrice = 0;

        private void rbsmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbsmall.Checked)
            {
                TotalPrice = Convert.ToInt32(rbsmall.Tag.ToString());
            }
            Update_Price();
        }
        private void btnReviewOrder_Click(object sender, EventArgs e)
        {
            string PizzaSizeResult = grpPizzaSizeResult();
            string PizzaToppingResult = grpPizzaToppingResult();
            string WhereToEatResult = grpWheretoeatResult();
            string CrustResult = grbcrustResult();
            int FinalPrice = Convert.ToInt32(TotalPrice);

            frmReviewOrder ReviewOrderForm = new frmReviewOrder(PizzaSizeResult, CrustResult,PizzaToppingResult, WhereToEatResult, FinalPrice);
            ReviewOrderForm.Show();

         
            this.Hide();
        }
       
        private void rbmeduim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbmeduim.Checked)
            {
                TotalPrice = Convert.ToInt32(rbmeduim.Tag.ToString());
            }
            Update_Price();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarge.Checked)
            {
                TotalPrice = Convert.ToInt32(rbLarge.Tag.ToString());
            }

            Update_Price();
        }
        void Update_Price()
        {
            lblTotalPrice.Text = TotalPrice.ToString() + "$";
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOnion.Checked)
            {
                TotalPrice += Convert.ToInt32(chkOnion.Tag.ToString());
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkOnion.Tag.ToString());
            }
            Update_Price();
        }
        private void chkExtracheese_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExtracheese.Checked)
            {
                TotalPrice += Convert.ToInt32(chkExtracheese.Tag.ToString());
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkExtracheese.Tag.ToString());
            }
            Update_Price();
        }
        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMushrooms.Checked)
            {
                TotalPrice += Convert.ToInt32(chkMushrooms.Tag.ToString());
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkMushrooms.Tag.ToString());
            }
            Update_Price();

        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTomatoes.Checked)
            {
                TotalPrice += Convert.ToInt32(chkTomatoes.Tag.ToString());
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkTomatoes.Tag.ToString());
            }
            Update_Price();

        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOlives.Checked)
            {
                TotalPrice += Convert.ToInt32(chkOlives.Tag.ToString());
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkOlives.Tag.ToString());
            }
            Update_Price();

        }
        private void chkChiliPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChiliPepper.Checked)
            {
                TotalPrice += Convert.ToInt32(chkChiliPepper.Tag.ToString());
            }
            else
            {
                TotalPrice -= Convert.ToInt32(chkChiliPepper.Tag.ToString());
            }
            Update_Price();

        }
       
        private string grpPizzaSizeResult()
        {
            string SizeResult = "";

            if (rbsmall.Checked)
            {
                SizeResult = rbsmall.Text;
            }
            else if(rbmeduim.Checked)
            {
                SizeResult = rbmeduim.Text;
            }
            else
            {
                SizeResult = rbLarge.Text;
            }

            return SizeResult;
        }
        private string grpPizzaToppingResult()
        {
            List <string> Topping1 = new List<string>();
            List<string> Topping2 = new List<string>();

            if (chkExtracheese.Checked)
            {
                Topping1.Add(chkExtracheese.Text);
            }
             if (chkMushrooms.Checked)
            {
                Topping1.Add(chkMushrooms.Text);
            }
             if (chkTomatoes.Checked)
            {
                Topping1.Add(chkTomatoes.Text) ;
            }
             if (chkOnion.Checked)
            {
                Topping2.Add(chkOnion.Text) ;
            }
            if (chkOlives.Checked)
            {
                Topping2.Add(chkOlives.Text);
            }
            if (chkChiliPepper.Checked)
            {
                Topping2.Add(chkChiliPepper.Text);
            }


            return string.Join(",", Topping1) + "\n" + string.Join(",", Topping2);
        }

        private string grpWheretoeatResult()
        {
            string Wheretoeat = "";

            if (rbEatin.Checked)
            {
                Wheretoeat = rbEatin.Text;
            }
            else
            {
                Wheretoeat = rbTakeaway.Text;
            }

            return Wheretoeat;

        }
        private string grbcrustResult()
        {
            string crust = "";

            if (rbthin.Checked)
            {
                crust = rbthin.Text;
            }
            else
            {
                crust = rbThick.Text;
            }

            return crust;



        }

    }
}








