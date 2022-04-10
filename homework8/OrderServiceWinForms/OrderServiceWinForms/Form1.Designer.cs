namespace OrderServiceWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.orderListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchInform = new System.Windows.Forms.TextBox();
            this.searchCbx = new System.Windows.Forms.ComboBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.OrderdetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnChangeOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfGoodsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdetailBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderListBindingSource
            // 
            this.orderListBindingSource.AllowNew = false;
            this.orderListBindingSource.DataMember = "Orders";
            this.orderListBindingSource.DataSource = typeof(OrderTest.OrderService);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearchInform);
            this.panel1.Controls.Add(this.searchCbx);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 60);
            this.panel1.TabIndex = 0;
            // 
            // txtSearchInform
            // 
            this.txtSearchInform.Location = new System.Drawing.Point(169, 15);
            this.txtSearchInform.Name = "txtSearchInform";
            this.txtSearchInform.Size = new System.Drawing.Size(265, 27);
            this.txtSearchInform.TabIndex = 2;
            // 
            // searchCbx
            // 
            this.searchCbx.AutoCompleteCustomSource.AddRange(new string[] {
            "通过订单号查找",
            "通过用户名查找"});
            this.searchCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCbx.FormattingEnabled = true;
            this.searchCbx.Items.AddRange(new object[] {
            "按ID号查询",
            "按客户名查询",
            "展示所有"});
            this.searchCbx.Location = new System.Drawing.Point(12, 14);
            this.searchCbx.Name = "searchCbx";
            this.searchCbx.Size = new System.Drawing.Size(151, 28);
            this.searchCbx.TabIndex = 1;
            this.searchCbx.SelectedIndexChanged += new System.EventHandler(this.searchCbx_SelectedIndexChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(440, 15);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(94, 29);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "查询";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // OrderdetailBindingSource
            // 
            this.OrderdetailBindingSource.DataMember = "OrderDetails";
            this.OrderdetailBindingSource.DataSource = this.orderListBindingSource;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnChangeOrder);
            this.panel2.Controls.Add(this.btnAddOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(403, 16);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 29);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(303, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(94, 29);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(203, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "删除订单";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnChangeOrder
            // 
            this.btnChangeOrder.Location = new System.Drawing.Point(103, 16);
            this.btnChangeOrder.Name = "btnChangeOrder";
            this.btnChangeOrder.Size = new System.Drawing.Size(94, 29);
            this.btnChangeOrder.TabIndex = 1;
            this.btnChangeOrder.Text = "修改订单";
            this.btnChangeOrder.UseVisualStyleBackColor = true;
            this.btnChangeOrder.Click += new System.EventHandler(this.btnChangeOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(3, 16);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(94, 29);
            this.btnAddOrder.TabIndex = 0;
            this.btnAddOrder.Text = "添加订单";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 121);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(730, 263);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsNameDataGridViewTextBoxColumn,
            this.goodsPriceDataGridViewTextBoxColumn,
            this.numOfGoodsDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.OrderdetailBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(300, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(430, 263);
            this.dataGridView2.TabIndex = 1;
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            this.goodsNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodsPriceDataGridViewTextBoxColumn
            // 
            this.goodsPriceDataGridViewTextBoxColumn.DataPropertyName = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.HeaderText = "GoodsPrice";
            this.goodsPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodsPriceDataGridViewTextBoxColumn.Name = "goodsPriceDataGridViewTextBoxColumn";
            this.goodsPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodsPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // numOfGoodsDataGridViewTextBoxColumn1
            // 
            this.numOfGoodsDataGridViewTextBoxColumn1.DataPropertyName = "NumOfGoods";
            this.numOfGoodsDataGridViewTextBoxColumn1.HeaderText = "NumOfGoods";
            this.numOfGoodsDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.numOfGoodsDataGridViewTextBoxColumn1.Name = "numOfGoodsDataGridViewTextBoxColumn1";
            this.numOfGoodsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numOfGoodsDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orderListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // numOfGoodsDataGridViewTextBoxColumn
            // 
            this.numOfGoodsDataGridViewTextBoxColumn.DataPropertyName = "NumOfGoods";
            this.numOfGoodsDataGridViewTextBoxColumn.HeaderText = "NumOfGoods";
            this.numOfGoodsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numOfGoodsDataGridViewTextBoxColumn.Name = "numOfGoodsDataGridViewTextBoxColumn";
            this.numOfGoodsDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GoodsPrice";
            this.dataGridViewTextBoxColumn1.HeaderText = "GoodsPrice";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 384);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderListBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderdetailBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BindingSource orderListBindingSource;
        private Panel panel1;
        private BindingSource OrderdetailBindingSource;
        private TextBox txtSearchInform;
        private ComboBox searchCbx;
        private Button searchBtn;
        private Panel panel2;
        private Button btnExport;
        private Button btnImport;
        private Button btnDelete;
        private Button btnChangeOrder;
        private Button btnAddOrder;
        private Panel panel3;
        private DataGridViewTextBoxColumn numOfGoodsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn goodsPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numOfGoodsDataGridViewTextBoxColumn1;
    }
}