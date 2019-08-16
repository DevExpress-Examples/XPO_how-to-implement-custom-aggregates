namespace XpoCustomAggregate {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.session1 = new DevExpress.Xpo.Session(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.contactNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xpView1 = new DevExpress.Xpo.XPView(this.components);
            this.contactNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.session1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Load data with XPView:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Load data with XPQuery:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contactNameDataGridViewTextBoxColumn1,
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1,
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1,
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.xpView1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(719, 235);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView2.Location = new System.Drawing.Point(12, 295);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(719, 236);
            this.dataGridView2.TabIndex = 3;
            // 
            // contactNameDataGridViewTextBoxColumn
            // 
            this.contactNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactNameDataGridViewTextBoxColumn.DataPropertyName = "Contact Name";
            this.contactNameDataGridViewTextBoxColumn.HeaderText = "Contact Name";
            this.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn";
            this.contactNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countdistinctOrderProductNameDataGridViewTextBoxColumn
            // 
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn.DataPropertyName = "Count (distinct Order.ProductName)";
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn.HeaderText = "Count (distinct Order.ProductName)";
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn.Name = "countdistinctOrderProductNameDataGridViewTextBoxColumn";
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn.Width = 181;
            // 
            // sTDEVPOrderQuantityDataGridViewTextBoxColumn
            // 
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "STDEVP(Order.Quantity)";
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn.HeaderText = "STDEVP(Order.Quantity)";
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn.Name = "sTDEVPOrderQuantityDataGridViewTextBoxColumn";
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn.Width = 149;
            // 
            // xpView1
            // 
            this.xpView1.ObjectType = typeof(XpoCustomAggregate.Customer);
            this.xpView1.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Contact Name", DevExpress.Xpo.SortDirection.None, "[FirstName] + \' \' + [LastName]", false, true),
            new DevExpress.Xpo.ViewProperty("Count (distinct Order.ProductName)", DevExpress.Xpo.SortDirection.None, "[Orders][].CountDistinct([ProductName])", false, true),
            new DevExpress.Xpo.ViewProperty("STDEVP(Order.Quantity)", DevExpress.Xpo.SortDirection.None, "[Orders][].STDEVP([Quantity])", false, true),
            new DevExpress.Xpo.ViewProperty("STDEVP(Order.Price)", DevExpress.Xpo.SortDirection.None, "[Orders][].STDEVP([Price])", false, true)});
            this.xpView1.Session = this.session1;
            this.xpView1.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[Contact Name]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // contactNameDataGridViewTextBoxColumn1
            // 
            this.contactNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.contactNameDataGridViewTextBoxColumn1.DataPropertyName = "Contact Name";
            this.contactNameDataGridViewTextBoxColumn1.HeaderText = "Contact Name";
            this.contactNameDataGridViewTextBoxColumn1.Name = "contactNameDataGridViewTextBoxColumn1";
            this.contactNameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // countdistinctOrderProductNameDataGridViewTextBoxColumn1
            // 
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1.DataPropertyName = "Count (distinct Order.ProductName)";
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1.HeaderText = "COUNT (DISTINCT Order.ProductName)";
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1.Name = "countdistinctOrderProductNameDataGridViewTextBoxColumn1";
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countdistinctOrderProductNameDataGridViewTextBoxColumn1.Width = 205;
            // 
            // sTDEVPOrderQuantityDataGridViewTextBoxColumn1
            // 
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.DataPropertyName = "STDEVP(Order.Quantity)";
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.HeaderText = "STDEVP(Order.Quantity)";
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.Name = "sTDEVPOrderQuantityDataGridViewTextBoxColumn1";
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.Width = 149;
            // 
            // sTDEVPOrderPriceDataGridViewTextBoxColumn
            // 
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn.DataPropertyName = "STDEVP(Order.Price)";
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn.HeaderText = "STDEVP(Order.Price)";
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn.Name = "sTDEVPOrderPriceDataGridViewTextBoxColumn";
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTDEVPOrderPriceDataGridViewTextBoxColumn.Width = 134;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ContactName";
            this.Column1.HeaderText = "Contact Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CountDistinct";
            this.Column2.HeaderText = "COUNT (DISTINCT Order.ProductName)";
            this.Column2.Name = "Column2";
            this.Column2.Width = 205;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "QuantityVariance";
            this.Column3.HeaderText = "STDEVP(Order.Quantity)";
            this.Column3.Name = "Column3";
            this.Column3.Width = 149;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PriceVariance";
            this.Column4.HeaderText = "STDEVP(Order.Price)";
            this.Column4.Name = "Column4";
            this.Column4.Width = 134;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 551);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "XPO Custom Aggregate Functions Demo";
            ((System.ComponentModel.ISupportInitialize)(this.session1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Xpo.XPView xpView1;
        private DevExpress.Xpo.Session session1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countdistinctOrderProductNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEVPOrderQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countdistinctOrderProductNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEVPOrderQuantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTDEVPOrderPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

