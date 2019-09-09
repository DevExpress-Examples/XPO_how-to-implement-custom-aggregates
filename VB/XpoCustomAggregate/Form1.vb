Imports DevExpress.Xpo
Imports System
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms

Namespace XpoCustomAggregate
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()

			'Register Custom Aggregates
			STDEVPCustomAggregate.Register()
			CountDistinctCustomAggregate.Register()

			'Load data using XPQuery
			gridControl2.DataSource = (New XPQuery(Of Customer)(session1)).Select(Function(t) New With {
				Key .ContactName = t.ContactName,
				Key .CountDistinct = CountDistinctCustomAggregate.CountDistinct(t.Orders, Function(o) o.ProductName),
				Key .QuantityVariance = STDEVPCustomAggregate.STDEVP(t.Orders, Function(o) o.Quantity),
				Key .PriceVariance = STDEVPCustomAggregate.STDEVP(t.Orders, Function(o) o.Price)
			}).OrderBy(Function(t) t.ContactName).ToList()
		End Sub
	End Class
End Namespace
