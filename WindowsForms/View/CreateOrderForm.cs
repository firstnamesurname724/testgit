using System;
using System.Linq;
using System.Windows.Forms;
using CL;

namespace WindowsForms
{
    public partial class CreateOrderForm : Form
    {
        public Check Check { get; set; }

        public CreateOrderForm()
        {
            InitializeComponent();
        }

        private void CreateOrderForm_Load(object sender, EventArgs e)
        {
            Check = new Check();
            saleDate.Value = DateTime.Now;
            cbEmp.DataSource = CL.ApplicationContext.Employees;
            cbEmp.DisplayMember = "SurName";
            cbBuyer.DataSource = CL.ApplicationContext.Buyers;
            cbBuyer.DisplayMember = "SurName";
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            using (var form = new CartEditorForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Cart cart = form.Cart;
                    Check.Cart = cart;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbBuyer.SelectedItem == null)
            {
                MessageBox.Show("Покупатель не выбран");
                return;
            }
            if (cbEmp.SelectedItem == null)
            {
                MessageBox.Show("Сотрудник не выбран");
                return;
            }
            if (Check.Cart == null)
            {
                MessageBox.Show("Корзина пуста");
                return;
            }

            Check.Number = CL.ApplicationContext.Checks.Max(c => c.Number) + 1;
            Check.Buyer = cbBuyer.SelectedItem as Buyer;
            Check.Employee = cbEmp.SelectedItem as Employee;
            Check.SaleDate = saleDate.Value;

            CL.ApplicationContext.Checks.Add(Check);
            ((MainForm)Owner).RefreshData();
            Close();
        }
    }
}