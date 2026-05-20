using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaAppProject
{
    public partial class frmReviewOrder : Form
    {

        string _PizzaSizeResult = "";
        string _PizzaToppingResult = "";
        string _WhereToEatResult = "";
        string _CrustResult = "";
        int _FinalPrice = 0;


        public frmReviewOrder(string PizzaSizeResult, string CrustResult, string PizzaToppingResult , string WhereToEatResult  ,int FinalPrice )
        {
            InitializeComponent();

            _PizzaSizeResult = PizzaSizeResult;
            _CrustResult = CrustResult;
            _PizzaToppingResult = PizzaToppingResult;
            _WhereToEatResult = WhereToEatResult;
            _FinalPrice = FinalPrice;

        }

        private void frmReviewOrder_Load(object sender, EventArgs e)
        {
            ShowPizzaDetails();
            gbtopping.MaximumSize = new Size(gbtopping.Width - 20, 0);
        }


        void ShowPizzaDetails()
        {
            lblSize.Text = _PizzaSizeResult;
            lblCrust.Text = _CrustResult;
            lblToping.Text = _PizzaToppingResult;
            lblWhereToEat.Text= _WhereToEatResult;

            lblPrice.Text =  _FinalPrice.ToString()+"$";
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Order Is Confirmed","Confirming Order",MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbSize.Enabled= false;
            gbCrust.Enabled = false;
            gbtopping.Enabled = false;
            gbwhereToEat.Enabled = false;
            gbTotalPrice.Enabled = false;
            btnOrderPizza.Enabled = false;
        }


        private void btnRsesetform_Click(object sender, EventArgs e)
        {
            gbSize.Enabled = true;
            gbCrust.Enabled = true;
            gbtopping.Enabled = true;
            gbwhereToEat.Enabled = true;
            gbTotalPrice.Enabled = true;
            btnOrderPizza.Enabled = true;
            Form Minform = new Form1();
            Minform.ShowDialog();

            this.Hide();
        }

        private void lblPrice_Click_1(object sender, EventArgs e)
        {

        }
    }
}
