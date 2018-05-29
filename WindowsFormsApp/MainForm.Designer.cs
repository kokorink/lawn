namespace WindowsFormsApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.tabPageService = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonAddService = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewServices = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lawnAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lawnAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameServiceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            this.tabPageService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageOrder);
            this.tabControl1.Controls.Add(this.tabPageClient);
            this.tabControl1.Controls.Add(this.tabPageService);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1058, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.splitContainer3);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(1050, 424);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "Заказы";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.splitContainer2);
            this.tabPageClient.Location = new System.Drawing.Point(4, 22);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1159, 424);
            this.tabPageClient.TabIndex = 1;
            this.tabPageClient.Text = "Клиенты";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // tabPageService
            // 
            this.tabPageService.Controls.Add(this.splitContainer1);
            this.tabPageService.Location = new System.Drawing.Point(4, 22);
            this.tabPageService.Name = "tabPageService";
            this.tabPageService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageService.Size = new System.Drawing.Size(1159, 424);
            this.tabPageService.TabIndex = 2;
            this.tabPageService.Text = "Услуги";
            this.tabPageService.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dataGridViewOrders);
            this.splitContainer3.Size = new System.Drawing.Size(1044, 418);
            this.splitContainer3.SplitterDistance = 32;
            this.splitContainer3.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonAddClient);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridViewClients);
            this.splitContainer2.Size = new System.Drawing.Size(1153, 418);
            this.splitContainer2.SplitterDistance = 32;
            this.splitContainer2.TabIndex = 4;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddService);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridViewServices);
            this.splitContainer1.Size = new System.Drawing.Size(1153, 418);
            this.splitContainer1.SplitterDistance = 32;
            this.splitContainer1.TabIndex = 4;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddClient.Location = new System.Drawing.Point(0, 0);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(115, 32);
            this.buttonAddClient.TabIndex = 1;
            this.buttonAddClient.Text = "Добавить клиента";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonAddService
            // 
            this.buttonAddService.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAddService.Location = new System.Drawing.Point(0, 0);
            this.buttonAddService.Name = "buttonAddService";
            this.buttonAddService.Size = new System.Drawing.Size(105, 32);
            this.buttonAddService.TabIndex = 1;
            this.buttonAddService.Text = "Добавить услугу";
            this.buttonAddService.UseVisualStyleBackColor = true;
            this.buttonAddService.Click += new System.EventHandler(this.buttonAddService_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AllowUserToAddRows = false;
            this.dataGridViewOrders.AllowUserToDeleteRows = false;
            this.dataGridViewOrders.AutoGenerateColumns = false;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrderDataGridViewTextBoxColumn,
            this.lawnAdressDataGridViewTextBoxColumn,
            this.lawnAreaDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn1,
            this.nameServiceDataGridViewTextBoxColumn1,
            this.Column5,
            this.Column6});
            this.dataGridViewOrders.DataSource = this.orderBindingSource;
            this.dataGridViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrders.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            this.dataGridViewOrders.ReadOnly = true;
            this.dataGridViewOrders.RowHeadersVisible = false;
            this.dataGridViewOrders.Size = new System.Drawing.Size(1044, 382);
            this.dataGridViewOrders.TabIndex = 0;
            // 
            // dataGridViewClients
            // 
            this.dataGridViewClients.AllowUserToAddRows = false;
            this.dataGridViewClients.AllowUserToDeleteRows = false;
            this.dataGridViewClients.AutoGenerateColumns = false;
            this.dataGridViewClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientPhoneDataGridViewTextBoxColumn,
            this.Column1,
            this.Column2});
            this.dataGridViewClients.DataSource = this.clientBindingSource;
            this.dataGridViewClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClients.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClients.Name = "dataGridViewClients";
            this.dataGridViewClients.ReadOnly = true;
            this.dataGridViewClients.RowHeadersVisible = false;
            this.dataGridViewClients.Size = new System.Drawing.Size(1153, 382);
            this.dataGridViewClients.TabIndex = 1;
            this.dataGridViewClients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClients_CellContentClick);
            // 
            // dataGridViewServices
            // 
            this.dataGridViewServices.AllowUserToAddRows = false;
            this.dataGridViewServices.AllowUserToDeleteRows = false;
            this.dataGridViewServices.AutoGenerateColumns = false;
            this.dataGridViewServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewServices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameServiceDataGridViewTextBoxColumn,
            this.priceServiceDataGridViewTextBoxColumn,
            this.Column3,
            this.Column4});
            this.dataGridViewServices.DataSource = this.serviceBindingSource;
            this.dataGridViewServices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewServices.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewServices.Name = "dataGridViewServices";
            this.dataGridViewServices.ReadOnly = true;
            this.dataGridViewServices.RowHeadersVisible = false;
            this.dataGridViewServices.Size = new System.Drawing.Size(1153, 382);
            this.dataGridViewServices.TabIndex = 1;
            this.dataGridViewServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewServices_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Text = "Изменить";
            this.Column3.UseColumnTextForButtonValue = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Text = "Удалить";
            this.Column4.UseColumnTextForButtonValue = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Изменить";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Text = "Удалить";
            this.Column2.UseColumnTextForButtonValue = true;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(WindowsFormsApp.Order);
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "clientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "Имя клиента";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientPhoneDataGridViewTextBoxColumn
            // 
            this.clientPhoneDataGridViewTextBoxColumn.DataPropertyName = "clientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.HeaderText = "Телефон клиента";
            this.clientPhoneDataGridViewTextBoxColumn.Name = "clientPhoneDataGridViewTextBoxColumn";
            this.clientPhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientPhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(WindowsFormsApp.Client);
            // 
            // nameServiceDataGridViewTextBoxColumn
            // 
            this.nameServiceDataGridViewTextBoxColumn.DataPropertyName = "nameService";
            this.nameServiceDataGridViewTextBoxColumn.HeaderText = "Название услуги";
            this.nameServiceDataGridViewTextBoxColumn.Name = "nameServiceDataGridViewTextBoxColumn";
            this.nameServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameServiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceServiceDataGridViewTextBoxColumn
            // 
            this.priceServiceDataGridViewTextBoxColumn.DataPropertyName = "priceService";
            this.priceServiceDataGridViewTextBoxColumn.HeaderText = "Стоимость услуги";
            this.priceServiceDataGridViewTextBoxColumn.Name = "priceServiceDataGridViewTextBoxColumn";
            this.priceServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceServiceDataGridViewTextBoxColumn.Width = 150;
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(WindowsFormsApp.Service);
            // 
            // idOrderDataGridViewTextBoxColumn
            // 
            this.idOrderDataGridViewTextBoxColumn.DataPropertyName = "idOrder";
            this.idOrderDataGridViewTextBoxColumn.HeaderText = "Номер заказа";
            this.idOrderDataGridViewTextBoxColumn.Name = "idOrderDataGridViewTextBoxColumn";
            this.idOrderDataGridViewTextBoxColumn.ReadOnly = true;
            this.idOrderDataGridViewTextBoxColumn.Width = 110;
            // 
            // lawnAdressDataGridViewTextBoxColumn
            // 
            this.lawnAdressDataGridViewTextBoxColumn.DataPropertyName = "lawnAdress";
            this.lawnAdressDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.lawnAdressDataGridViewTextBoxColumn.Name = "lawnAdressDataGridViewTextBoxColumn";
            this.lawnAdressDataGridViewTextBoxColumn.ReadOnly = true;
            this.lawnAdressDataGridViewTextBoxColumn.Width = 150;
            // 
            // lawnAreaDataGridViewTextBoxColumn
            // 
            this.lawnAreaDataGridViewTextBoxColumn.DataPropertyName = "lawnArea";
            this.lawnAreaDataGridViewTextBoxColumn.HeaderText = "Площадь газона";
            this.lawnAreaDataGridViewTextBoxColumn.Name = "lawnAreaDataGridViewTextBoxColumn";
            this.lawnAreaDataGridViewTextBoxColumn.ReadOnly = true;
            this.lawnAreaDataGridViewTextBoxColumn.Width = 120;
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "totalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "Сумма заказа";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            this.totalCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCostDataGridViewTextBoxColumn.Width = 110;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "orderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "Время заказа";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderTimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // idClientDataGridViewTextBoxColumn1
            // 
            this.idClientDataGridViewTextBoxColumn1.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn1.HeaderText = "ID Клиента";
            this.idClientDataGridViewTextBoxColumn1.Name = "idClientDataGridViewTextBoxColumn1";
            this.idClientDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameServiceDataGridViewTextBoxColumn1
            // 
            this.nameServiceDataGridViewTextBoxColumn1.DataPropertyName = "nameService";
            this.nameServiceDataGridViewTextBoxColumn1.HeaderText = "Услуга";
            this.nameServiceDataGridViewTextBoxColumn1.Name = "nameServiceDataGridViewTextBoxColumn1";
            this.nameServiceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Text = "Изменить";
            this.Column5.UseColumnTextForButtonValue = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Удалить";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Журнал заказа услуги полива и стрижки газона с ценой и площадью";
            this.tabControl1.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            this.tabPageClient.ResumeLayout(false);
            this.tabPageService.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOrder;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TabPage tabPageClient;
        private System.Windows.Forms.TabPage tabPageService;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonAddService;
        private System.Windows.Forms.DataGridView dataGridViewClients;
        private System.Windows.Forms.DataGridView dataGridViewServices;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lawnAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lawnAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameServiceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}

