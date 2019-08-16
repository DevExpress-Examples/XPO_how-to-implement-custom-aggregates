Imports DevExpress.Xpo
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace XpoCustomAggregate
	Public Module DemoDataHelper
		Private firstNames() As String = { "Peter", "Ryan", "Richard", "Tom", "Mark"}
		Private lastNames() As String = { "Dolan", "Fischer", "Hamlett", "Hamilton", "Lee", "Lewis" }
		Private productNames() As String = { "Chai", "Chang", "Aniseed Syrup", "Chef Anton's Cajun Seasoning", "Chef Anton's Gumbo Mix", "Grandma's Boysenberry Spread", "Uncle Bob's Organic Dried Pears", "Northwoods Cranberry Sauce", "Mishi Kobe Niku", "Ikura", "Queso Cabrales", "Queso Manchego La Pastora", "Konbu", "Tofu", "Genen Shouyu", "Pavlova", "Alice Mutton"}
		Private Random As New Random(0)

		Public Sub Seed()
			Using uow As New UnitOfWork(XpoDefault.DataLayer)
				If uow.Query(Of Customer)().Count() > 0 Then
					Return
				End If
				Dim customers As New List(Of Customer)()
				For i As Integer = 0 To firstNames.Length - 1
					For j As Integer = 0 To lastNames.Length - 1
						customers.Add(New Customer(uow) With {
							.FirstName = firstNames(i),
							.LastName = lastNames(j)
						})
					Next j
				Next i
				Const recordsCount As Integer = 500
				For i As Integer = 0 To recordsCount - 1
					Dim order As New Order(uow)
					order.ProductName = productNames(Random.Next(productNames.Length))
					order.OrderDate = New Date(Random.Next(2014, 2024), Random.Next(1, 12), Random.Next(1, 28))
					order.Price = 1 + Random.Next(10000) / 100D
					order.Quantity = 1 + Random.Next(100)
					order.Customer = customers(Random.Next(customers.Count))
				Next i
				uow.CommitChanges()
			End Using
		End Sub
	End Module
End Namespace