using ChapeauService;

namespace ChapeauUI.Forms
{
    public partial class Payingfrm : Form
    {
        PayingService ps = new PayingService();

        public Payingfrm()
        {
            InitializeComponent();
        }

        private void Payingfrm_Load(object sender, EventArgs e)
        {
            // TODO: Add code that loads the bill from the database
            ps.GetBill();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            // TODO: Add code that receives the complete bill and sends it to the database
        }

        private void btnAddTip_Click(object sender, EventArgs e)
        {
            // TODO: Add code that launches the tip form
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // TODO: Add code that returns to the previous form
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            // Nothing will happen here because the payment form is already open
        }

        private void btnMenus_Click(object sender, EventArgs e)
        {
            // TODO: Add code that launches the menu form

            
            
            this.Close();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            // TODO: Add code that launches the order status form

            

            this.Close();
        }
    }
}
