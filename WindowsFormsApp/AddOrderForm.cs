using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class AddOrderForm : Form
    {
        MainForm mf = new MainForm();
        public Order item = new Order();
        public AddOrderForm()
        {
            InitializeComponent();
            comboBoxClient.DataSource = mf.GetClients();
            comboBoxClient.DisplayMember = "clientName";
            comboBoxService.DataSource = mf.GetServices();
            comboBoxService.DisplayMember = "nameService";

        }

        public AddOrderForm(Order order)
        {

            InitializeComponent();
            //mf = Owner as MainForm;
            comboBoxClient.DataSource = mf.GetClients();
            comboBoxClient.DisplayMember = "clientName";
            comboBoxService.DataSource = mf.GetServices();
            comboBoxService.DisplayMember = "nameService";
            textBoxAdress.Text = order.lawnAdress;
            textBoxArea.Text = order.lawnArea.ToString();

            item = order;

        }

        private void buttonOrderSave_Click(object sender, EventArgs e)
        {
            item.lawnAdress = textBoxAdress.Text;
            item.lawnArea = Convert.ToInt32(textBoxArea.Text);
            item.idClient = ((Client)comboBoxClient.SelectedValue).idClient;
            item.nameService = comboBoxService.Text;
            this.Close();
        }
    }
}
