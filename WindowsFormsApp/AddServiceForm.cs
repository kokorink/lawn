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
    public partial class AddServiceForm : Form
    {
        public Service item = new Service();
        public AddServiceForm()
        {
            InitializeComponent();
        }

        public AddServiceForm(Service service)
        {
            InitializeComponent();
            item = service;
            textBoxServiceName.Text = service.nameService;
            textBoxServicePrice.Text = service.priceService.ToString();
        }



        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            item.nameService = textBoxServiceName.Text;
            item.priceService= (float)Convert.ToDouble(textBoxServicePrice.Text);

            this.Close();
        }
    }
}
