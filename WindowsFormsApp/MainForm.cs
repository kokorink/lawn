using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{

    public partial class MainForm : Form
    {
        Client clients = new Client();
        Order orders = new Order();
        Service services = new Service();
        private string App_path = "http://localhost:38281/";
        public MainForm()
        {
            InitializeComponent();
            var clients = GetClients();
            dataGridViewClients.DataSource = clients;
            var services = GetServices();
            dataGridViewServices.DataSource = services;
            var orders = GetOrders();
            dataGridViewOrders.DataSource = orders;

        }

        public IEnumerable<Order> GetOrders()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(App_path + "api/OrderAPI/").Result;
                return JsonConvert.DeserializeObject<IEnumerable<Order>>(response.Content.ReadAsStringAsync().Result);
            }

        }


        public IEnumerable<Client> GetClients()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(App_path + "api/ClientAPI/").Result;
                return JsonConvert.DeserializeObject<IEnumerable<Client>>(response.Content.ReadAsStringAsync().Result);
            }

        }
        public IEnumerable<Service> GetServices()
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(App_path + "api/ServiceTypeAPI/").Result;
                return JsonConvert.DeserializeObject<IEnumerable<Service>>(response.Content.ReadAsStringAsync().Result);
            }

        }

        private void dataGridViewServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var indexItem = senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var but = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (but.Text == "Изменить")
                {
                    services = GetIdService(indexItem);
                    AddServiceForm f = new AddServiceForm(services);
                    f.ShowDialog();
                    EditService(f.item);
                }

                else
                {
                    DeleteService(indexItem);

                }

                var items = GetServices();
                dataGridViewServices.DataSource = items;

            }
        }

        public void EditService(Service service)
        {
            using (var httpclient = new HttpClient())
            {
                var response = httpclient.PutAsJsonAsync(App_path + "/api/ServiceTypeAPI/", service).Result;
            }
        }

        public Service GetIdService(string id)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(App_path + "api/ServiceTypeAPI/" + id).Result;
                return JsonConvert.DeserializeObject<Service>(response.Content.ReadAsStringAsync().Result);
            }
        }


        public void DeleteService(string id)
        {
            using (var service = new HttpClient())
            {
                var response = service.DeleteAsync(App_path + "/api/ServiceTypeAPI/" + id).Result;
            }
        }

        private void dataGridViewClients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var indexItem = Convert.ToInt16(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var but = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (but.Text == "Изменить")
                {
                    clients = GetIdClient(indexItem);
                    AddClientForm f = new AddClientForm(clients);
                    f.ShowDialog();
                    EditClient(f.item);
                }

                else
                {
                    DeleteClient(indexItem);

                }

                var items = GetClients();
                dataGridViewClients.DataSource = items;

            }

        }
        
        public Client GetIdClient(int id)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(App_path + "api/ClientAPI/" + id).Result;
                return JsonConvert.DeserializeObject<Client>(response.Content.ReadAsStringAsync().Result);
            }
        }

        public Order GetIdOrder(int id)
        {
            using (var client = new HttpClient())
            {
                var response = client.GetAsync(App_path + "api/OrderAPI/" + id).Result;
                return JsonConvert.DeserializeObject<Order>(response.Content.ReadAsStringAsync().Result);
            }
        }

        public void DeleteClient(int id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(App_path + "/api/ClientAPI/" + id).Result;
            }
        }

        public void DeleteOrder(int id)
        {
            using (var client = new HttpClient())
            {
                var response = client.DeleteAsync(App_path + "/api/OrderAPI/" + id).Result;
            }
        }


        public void EditClient(Client client)
        {
            using (var httpclient = new HttpClient())
            {
                var response = httpclient.PutAsJsonAsync(App_path + "/api/ClientAPI/", client).Result;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddClientForm f = new AddClientForm();
            f.ShowDialog();
            AddClient(f.item);

            var items = GetClients();
            dataGridViewClients.DataSource = items;
        }

        public void AddClient(Client client)
        {
            using (var httpclient = new HttpClient())
            {
                var response = httpclient.PostAsJsonAsync(App_path + "/api/ClientAPI/", client).Result;
            }
        }

        public void AddOrder(Order order)
        {
            using (var httpclient = new HttpClient())
            {
                var response = httpclient.PostAsJsonAsync(App_path + "/api/OrderAPI/", order).Result;
            }
        }


        private void buttonAddService_Click(object sender, EventArgs e)
        {
            AddServiceForm f = new AddServiceForm();
            f.ShowDialog();
            AddService(f.item);

            var items = GetServices();
            dataGridViewServices.DataSource = items;
        }

        public void AddService(Service service)
        {
            using (var client = new HttpClient())
            {
                var response = client.PostAsJsonAsync(App_path + "/api/ServiceTypeAPI/", service).Result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddOrderForm f = new AddOrderForm();
            f.ShowDialog();
            AddOrder(f.item);

            var items = GetOrders();
            dataGridViewOrders.DataSource = items;
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            var indexItem = Convert.ToInt16(senderGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                var but = (DataGridViewButtonColumn)senderGrid.Columns[e.ColumnIndex];
                if (but.Text == "Изменить")
                {
                    orders = GetIdOrder(indexItem);
                    AddOrderForm f = new AddOrderForm(orders);
                    f.ShowDialog();
                    EditOrder(f.item);
                }

                else
                {
                    DeleteOrder(indexItem);

                }

                var items = GetOrders();
                dataGridViewOrders.DataSource = items;

            }

        }

        public void EditOrder(Order order)
        {
            using (var client = new HttpClient())
            {
                var response = client.PutAsJsonAsync(App_path + "/api/OrderAPI/", order).Result;
            }
        }

        

    }
}
