using System;
using System.Linq;
using System.Windows.Forms;
using CL;

namespace WindowsForms
{
    public partial class CheckInfoForm : Form
    {
        private Check _check;

        public CheckInfoForm(Check check)
        {
            InitializeComponent();

            _check = check;
        }

        private void CheckInfoForm_Load(object sender, EventArgs e)
        {
            lNumber.Text = $"Чек № {_check.Number} на сумму {_check.GetCheckSum()} руб.";
            lBuyer.Text = $"Покупатель: {_check.Buyer.SurName} {_check.Buyer.FirstName}";
            lEmp.Text = $"{_check.Employee.Position}: {_check.Employee.SurName} {_check.Employee.FirstName}";
            lDate.Text = $"Дата: {_check.SaleDate.ToShortDateString()}";
            dgv.DataSource = (from c in _check.Cart.Items
                              select new
                              {
                                  GoodsName = c.Goods.Name,
                                  GoodsCost = c.Goods.Cost,
                                  c.GoodsCount
                              }).ToList();
        }
    }
}