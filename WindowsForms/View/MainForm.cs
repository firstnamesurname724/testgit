using System;
using System.Windows.Forms;
using CL;
using log4net;
using log4net.Config;

namespace WindowsForms
{
    public partial class MainForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(MainForm));

        public MainForm()
        {
            InitializeComponent();

            XmlConfigurator.Configure(new System.IO.FileInfo("logs.xml"));
            log.Info("Starting Application");
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            log.Info("Redirect to form CreateOrderForm");
            new CreateOrderForm() { Owner = this }.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshData();        
        }

        public void RefreshData()
        {
            log.Info("Refreshing Data");

            dgv.Columns.Clear();
            dgv.DataSource = null;
            dgv.DataSource = CL.ApplicationContext.Checks;

            dgv.Columns[1].Visible = false;
            dgv.Columns[2].Visible = false;
            dgv.Columns[3].Visible = false;

            dgv.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Подробнее",
                UseColumnTextForButtonValue = true
            });
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            log.Info("Redirect to form CheckInfoForm");
            if (e.ColumnIndex == 5)
            {
                Check check = dgv.SelectedRows[0].DataBoundItem as Check;
                new CheckInfoForm(check).ShowDialog();
            }
        }
    }
}