Imports DevExpress.Xpo
Imports System

Namespace XpoCustomAggregate

	Public Class Order
		Inherits XPObject

		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Property ProductName() As String
			Get
				Return GetPropertyValue(Of String)(NameOf(ProductName))
			End Get
			Set(ByVal value As String)
				SetPropertyValue(NameOf(ProductName), value)
			End Set
		End Property
		Public Property OrderDate() As Date
			Get
				Return GetPropertyValue(Of Date)(NameOf(OrderDate))
			End Get
			Set(ByVal value As Date)
				SetPropertyValue(NameOf(OrderDate), value)
			End Set
		End Property
		Public Property Price() As Decimal
			Get
				Return GetPropertyValue(Of Decimal)(NameOf(Price))
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(NameOf(Price), value)
			End Set
		End Property
		Public Property Quantity() As Decimal
			Get
				Return GetPropertyValue(Of Decimal)(NameOf(Quantity))
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(NameOf(Quantity), value)
			End Set
		End Property
		<Association("CustomerOrders")>
		Public Property Customer() As Customer
			Get
				Return GetPropertyValue(Of Customer)(NameOf(Customer))
			End Get
			Set(ByVal value As Customer)
				SetPropertyValue(NameOf(Customer), value)
			End Set
		End Property
	End Class
End Namespace
