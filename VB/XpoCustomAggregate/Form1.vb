Imports DevExpress.Data.Filtering
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

			'Load data with XPView
			Dim xpView As New XPView(session1, GetType(Customer))
			xpView.AddProperty("ContactName", CriteriaOperator.Parse("[FirstName] + ' ' + [LastName]"))
			xpView.AddProperty("DistinctProducts", CriteriaOperator.Parse("[Orders][].CountDistinct([ProductName])"))
			xpView.AddProperty("QuantityVariance", CriteriaOperator.Parse("[Orders][].STDEVP([Quantity])"))
			xpView.AddProperty("PriceVariance", CriteriaOperator.Parse("[Orders][].STDEVP([Price])"))
			xpView.Sorting.Add(New SortProperty("ContactName", DevExpress.Xpo.DB.SortingDirection.Ascending))
			gridControl1.DataSource = xpView

			'Load data using XPQuery
			gridControl2.DataSource = (New XPQuery(Of Customer)(session1)).Select(Function(t) New With {
				Key .ContactName = t.ContactName,
				Key .DistinctProducts = DirectCast(CountDistinctCustomAggregate.CountDistinct(t.Orders, Function(o) o.ProductName), Integer),
				Key .QuantityVariance = DirectCast(STDEVPCustomAggregate.STDEVP(t.Orders, Function(o) o.Quantity), Double?),
				Key .PriceVariance = DirectCast(STDEVPCustomAggregate.STDEVP(t.Orders, Function(o) o.Price), Double?)
			}).OrderBy(Function(t) t.ContactName).ToList()
		End Sub
	End Class
End Namespace
