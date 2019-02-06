using Factory;
using InterfaceCustomer;
using System;
using System.Windows.Forms;

namespace DesignPattern
{
    public partial class Form1 : Form
    {
        ICustomer cust = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Cmb_custType_SelectedIndexChanged(object sender, EventArgs e)
        {
                cust = CustomerFactoryUsingUnity.CreateObject(cmb_custType.Text);
            txt_date.Text = cust.BillDate.ToString("MM/dd/yyyy");
        }
        private void SetCustomer()
        {
            cust.CustomerName = txt_name.Text;
            cust.Address = txt_address.Text;
            cust.Amount = Convert.ToDecimal(txt_amount.Text);
            cust.BillDate = Convert.ToDateTime(txt_date.Text);
            cust.PhoneNumber = txt_phone.Text;
        }
        private void Btn_Validate_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
