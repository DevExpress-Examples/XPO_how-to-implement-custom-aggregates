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
			Me.contactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.countdistinctOrderProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.sTDEVPOrderQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.session1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(12, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(119, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Load data with XPView:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(12, 276)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(127, 13)
			Me.label2.TabIndex = 1
			Me.label2.Text = "Load data with XPQuery:"
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
			' gridControl1
			' 
			Me.gridControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl1.Location = New System.Drawing.Point(12, 25)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(718, 236)
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colContactName, Me.gridColumn1, Me.gridColumn2, Me.gridColumn3})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colContactName
			' 
			Me.colContactName.FieldName = "ContactName"
			Me.colContactName.Name = "colContactName"
			Me.colContactName.Visible = True
			Me.colContactName.VisibleIndex = 0
			' 
			' gridColumn1
			' 
			Me.gridColumn1.Caption = "COUNT (DISTINCT Order.ProductName)"
			Me.gridColumn1.FieldName = "DistinctProducts"
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 1
			' 
			' gridColumn2
			' 
			Me.gridColumn2.Caption = "STDEVP(Order.Quantity)"
			Me.gridColumn2.FieldName = "QuantityVariance"
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 2
			' 
			' gridColumn3
			' 
			Me.gridColumn3.Caption = "STDEVP(Order.Price)"
			Me.gridColumn3.FieldName = "PriceVariance"
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 3
			' 
			' gridControl2
			' 
			Me.gridControl2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.gridControl2.Location = New System.Drawing.Point(12, 292)
			Me.gridControl2.MainView = Me.gridView2
			Me.gridControl2.Name = "gridControl2"
			Me.gridControl2.Size = New System.Drawing.Size(718, 236)
			Me.gridControl2.TabIndex = 5
			Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView2})
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7})
			Me.gridView2.GridControl = Me.gridControl2
			Me.gridView2.Name = "gridView2"
			' 
			' gridColumn4
			' 
			Me.gridColumn4.Caption = "Contact Name"
			Me.gridColumn4.FieldName = "ContactName"
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 0
			' 
			' gridColumn5
			' 
			Me.gridColumn5.Caption = "COUNT (DISTINCT Order.ProductName)"
			Me.gridColumn5.FieldName = "DistinctProducts"
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.UnboundType = DevExpress.Data.UnboundColumnType.Integer
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 1
			' 
			' gridColumn6
			' 
			Me.gridColumn6.Caption = "STDEVP(Order.Quantity)"
			Me.gridColumn6.FieldName = "QuantityVariance"
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 2
			' 
			' gridColumn7
			' 
			Me.gridColumn7.Caption = "STDEVP(Order.Price)"
			Me.gridColumn7.FieldName = "PriceVariance"
			Me.gridColumn7.Name = "gridColumn7"
			Me.gridColumn7.Visible = True
			Me.gridColumn7.VisibleIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(742, 548)
			Me.Controls.Add(Me.gridControl2)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Name = "Form1"
			Me.Text = "XPO Custom Aggregate Functions Demo"
			CType(Me.session1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region
		Private session1 As DevExpress.Xpo.Session
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private contactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private countdistinctOrderProductNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private sTDEVPOrderQuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colContactName As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridControl2 As DevExpress.XtraGrid.GridControl
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace

