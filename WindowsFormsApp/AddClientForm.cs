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
    public partial class AddClientForm : Form
    {
        public Client item = new Client();
        public AddClientForm(Client client)
        {
            InitializeComponent();
            item = client;
            textBoxClientName.Text = client.clientName;
            textBoxClientPhone.Text = client.clientPhone;
        }
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            item.clientName = textBoxClientName.Text;
            item.clientPhone = textBoxClientPhone.Text;

            this.Close();

        }
    }
}
