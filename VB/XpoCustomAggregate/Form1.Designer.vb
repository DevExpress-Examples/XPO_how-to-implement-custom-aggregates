Namespace XpoCustomAggregate
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.session1 = New DevExpress.Xpo.Session(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.dataGridView2 = New System.Windows.Forms.DataGridView()
			Me.contactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.xpView1 = New DevExpress.Xpo.XPView(Me.components)
			Me.contactNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.sTDEVPOrderPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(120, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Load data with XPView:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(12, 276)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(125, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Load data with XPQuery:"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView1.AutoGenerateColumns = False
			Me.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.contactNameDataGridViewTextBoxColumn1, Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1, Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1, Me.sTDEVPOrderPriceDataGridViewTextBoxColumn})
			Me.dataGridView1.DataSource = Me.xpView1
			Me.dataGridView1.Location = New System.Drawing.Point(12, 29)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(719, 235)
			Me.dataGridView1.TabIndex = 2
			' 
			' dataGridView2
			' 
			Me.dataGridView2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
			Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.Column1, Me.Column2, Me.Column3, Me.Column4})
			Me.dataGridView2.Location = New System.Drawing.Point(12, 295)
			Me.dataGridView2.Name = "dataGridView2"
			Me.dataGridView2.Size = New System.Drawing.Size(719, 236)
			Me.dataGridView2.TabIndex = 3
			' 
			' contactNameDataGridViewTextBoxColumn
			' 
			Me.contactNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.contactNameDataGridViewTextBoxColumn.DataPropertyName = "Contact Name"
			Me.contactNameDataGridViewTextBoxColumn.HeaderText = "Contact Name"
			Me.contactNameDataGridViewTextBoxColumn.Name = "contactNameDataGridViewTextBoxColumn"
			Me.contactNameDataGridViewTextBoxColumn.ReadOnly = True
			' 
			' countdistinctOrderProductNameDataGridViewTextBoxColumn
			' 
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn.DataPropertyName = "Count (distinct Order.ProductName)"
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn.HeaderText = "Count (distinct Order.ProductName)"
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn.Name = "countdistinctOrderProductNameDataGridViewTextBoxColumn"
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn.ReadOnly = True
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn.Width = 181
			' 
			' sTDEVPOrderQuantityDataGridViewTextBoxColumn
			' 
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn.DataPropertyName = "STDEVP(Order.Quantity)"
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn.HeaderText = "STDEVP(Order.Quantity)"
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn.Name = "sTDEVPOrderQuantityDataGridViewTextBoxColumn"
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn.ReadOnly = True
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn.Width = 149
			' 
			' xpView1
			' 
			Me.xpView1.ObjectType = GetType(XpoCustomAggregate.Customer)
			Me.xpView1.Properties.AddRange(New DevExpress.Xpo.ViewProperty() {
				New DevExpress.Xpo.ViewProperty("Contact Name", DevExpress.Xpo.SortDirection.None, "[FirstName] + ' ' + [LastName]", False, True),
				New DevExpress.Xpo.ViewProperty("Count (distinct Order.ProductName)", DevExpress.Xpo.SortDirection.None, "[Orders][].CountDistinct([ProductName])", False, True),
				New DevExpress.Xpo.ViewProperty("STDEVP(Order.Quantity)", DevExpress.Xpo.SortDirection.None, "[Orders][].STDEVP([Quantity])", False, True),
				New DevExpress.Xpo.ViewProperty("STDEVP(Order.Price)", DevExpress.Xpo.SortDirection.None, "[Orders][].STDEVP([Price])", False, True)
			})
			Me.xpView1.Session = Me.session1
			Me.xpView1.Sorting.AddRange(New DevExpress.Xpo.SortProperty() { New DevExpress.Xpo.SortProperty("[Contact Name]", DevExpress.Xpo.DB.SortingDirection.Ascending)})
			' 
			' contactNameDataGridViewTextBoxColumn1
			' 
			Me.contactNameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.contactNameDataGridViewTextBoxColumn1.DataPropertyName = "Contact Name"
			Me.contactNameDataGridViewTextBoxColumn1.HeaderText = "Contact Name"
			Me.contactNameDataGridViewTextBoxColumn1.Name = "contactNameDataGridViewTextBoxColumn1"
			Me.contactNameDataGridViewTextBoxColumn1.ReadOnly = True
			' 
			' countdistinctOrderProductNameDataGridViewTextBoxColumn1
			' 
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1.DataPropertyName = "Count (distinct Order.ProductName)"
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1.HeaderText = "COUNT (DISTINCT Order.ProductName)"
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1.Name = "countdistinctOrderProductNameDataGridViewTextBoxColumn1"
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1.ReadOnly = True
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn1.Width = 205
			' 
			' sTDEVPOrderQuantityDataGridViewTextBoxColumn1
			' 
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.DataPropertyName = "STDEVP(Order.Quantity)"
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.HeaderText = "STDEVP(Order.Quantity)"
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.Name = "sTDEVPOrderQuantityDataGridViewTextBoxColumn1"
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.ReadOnly = True
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn1.Width = 149
			' 
			' sTDEVPOrderPriceDataGridViewTextBoxColumn
			' 
			Me.sTDEVPOrderPriceDataGridViewTextBoxColumn.DataPropertyName = "STDEVP(Order.Price)"
			Me.sTDEVPOrderPriceDataGridViewTextBoxColumn.HeaderText = "STDEVP(Order.Price)"
			Me.sTDEVPOrderPriceDataGridViewTextBoxColumn.Name = "sTDEVPOrderPriceDataGridViewTextBoxColumn"
			Me.sTDEVPOrderPriceDataGridViewTextBoxColumn.ReadOnly = True
			Me.sTDEVPOrderPriceDataGridViewTextBoxColumn.Width = 134
			' 
			' Column1
			' 
			Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
			Me.Column1.DataPropertyName = "ContactName"
			Me.Column1.HeaderText = "Contact Name"
			Me.Column1.Name = "Column1"
			' 
			' Column2
			' 
			Me.Column2.DataPropertyName = "CountDistinct"
			Me.Column2.HeaderText = "COUNT (DISTINCT Order.ProductName)"
			Me.Column2.Name = "Column2"
			Me.Column2.Width = 205
			' 
			' Column3
			' 
			Me.Column3.DataPropertyName = "QuantityVariance"
			Me.Column3.HeaderText = "STDEVP(Order.Quantity)"
			Me.Column3.Name = "Column3"
			Me.Column3.Width = 149
			' 
			' Column4
			' 
			Me.Column4.DataPropertyName = "PriceVariance"
			Me.Column4.HeaderText = "STDEVP(Order.Price)"
			Me.Column4.Name = "Column4"
			Me.Column4.Width = 134
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(745, 551)
			Me.Controls.Add(Me.dataGridView2)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "Form1"
			Me.Text = "XPO Custom Aggregate Functions Demo"
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private xpView1 As DevExpress.Xpo.XPView
		Private session1 As DevExpress.Xpo.Session
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private dataGridView2 As System.Windows.Forms.DataGridView
		Private contactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private countdistinctOrderProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private sTDEVPOrderQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private contactNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private countdistinctOrderProductNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private sTDEVPOrderQuantityDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private sTDEVPOrderPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
	End Class
End Namespace

