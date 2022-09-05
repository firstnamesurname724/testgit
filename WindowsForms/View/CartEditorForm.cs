using System;
using System.ComponentModel;
using System.Windows.Forms;
using CL;

namespace WindowsForms
{
    public partial class CartEditorForm : Form
    {
        private BindingList<Goods> ds;
        public Cart Cart { get; set; }

        public CartEditorForm()
        {
            InitializeComponent();
        }

        private void CartEditorForm_Load(object sender, EventArgs e)
        {
            cbGoods.DataSource = CL.ApplicationContext.Goods;
            cbGoods.DisplayMember = "Name";
            cbGoods.SelectedIndexChanged += CbGoods_SelectedIndexChanged;

            ds = new BindingList<Goods>();
            dgvGoods.DataSource = ds;
            dgvGoods.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Удалить",
                UseColumnTextForButtonValue = true
            });
        }

        private void CbGoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            Goods goods = cbGoods.SelectedItem as Goods;

            foreach (DataGridViewRow row in dgvGoods.Rows)
            {
                Goods old = row.DataBoundItem as Goods;
                if (old.Equals(goods))
                {
                    MessageBox.Show("Товар уже есть в корзине");
                    return;
                }
            }

            ds.Add(goods);
        }

        private void dgvGoods_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            dgvGoodsCount.Rows.RemoveAt(e.RowIndex);
        }

        private void dgvGoods_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgvGoodsCount.Rows.Add("0");
        }

        private void dgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGoods.ColumnCount - 1)
            {
                dgvGoods.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvGoodsCount.RowCount; i++)
            {
                if (dgvGoodsCount[0, i].Value.ToString() == "0")
                {
                    MessageBox.Show("Товар в корзине не может находиться в заданном кол-ве: 0");
                    return;
                }
            }

            Cart = new Cart();
            for (int i = 0; i < dgvGoods.RowCount; i++)
            {
                Goods goods = dgvGoods.Rows[i].DataBoundItem as Goods;
                Cart.Items.Add(new CartItem
                {
                    Goods = goods,
                    GoodsCount = Convert.ToInt32(dgvGoodsCount[0, i].Value)
                });
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}