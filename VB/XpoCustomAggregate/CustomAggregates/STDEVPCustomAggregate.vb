Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

Namespace XpoCustomAggregate
	Friend Class STDEVPCustomAggregate
		Implements ICustomAggregate, ICustomAggregateQueryable, ICustomAggregateFormattable

		Private Shared ReadOnly instance As New STDEVPCustomAggregate()
		Public Shared Sub Register()
			CriteriaOperator.RegisterCustomAggregate(instance)
		End Sub
		Public Shared Sub Unregister()
			CriteriaOperator.UnregisterCustomAggregate(instance)
		End Sub
		Public ReadOnly Property Name() As String Implements ICustomAggregate.Name
			Get
                Return NameOf(STDEVP)
            End Get
		End Property
		Private Function ICustomAggregate_ResultType(ParamArray ByVal operands() As Type) As Type Implements ICustomAggregate.ResultType
			Return GetType(Decimal?)
		End Function
		Private Function ICustomAggregate_CreateEvaluationContext() As Object Implements ICustomAggregate.CreateEvaluationContext
			Return New CustomAggregateEvaluationContext(Of Context)()
		End Function
		Private Function ICustomAggregate_Process(ByVal context As Object, ByVal operands() As Object) As Boolean Implements ICustomAggregate.Process
			Dim ctx = DirectCast(context, CustomAggregateEvaluationContext(Of Context))
			ctx.ProcessValue(Function(v)
				If operands(0) IsNot Nothing Then
					v = New Context() With {
						.Count = v.Count + 1,
						.Sum = v.Sum + Convert.ToDouble(operands(0)),
						.SumOfSquares = Math.Pow(Convert.ToDouble(operands(0)), 2)
					}
				End If
				Return v
			End Function)
			Return False
		End Function
		Private Function ICustomAggregate_GetResult(ByVal context As Object) As Object Implements ICustomAggregate.GetResult
			Dim ctx = DirectCast(context, CustomAggregateEvaluationContext(Of Context))
            If ctx.Value.Count > 0 Then
                Return Convert.ToDecimal(Math.Sqrt(ctx.Value.SumOfSquares / ctx.Value.Count - Math.Pow(ctx.Value.Sum / ctx.Value.Count, 2)))
            End If
            Return Nothing
		End Function
		Private Function ICustomAggregateFormattable_Format(ByVal providerType As Type, ParamArray ByVal operands() As String) As String Implements ICustomAggregateFormattable.Format
			If GetType(DevExpress.Xpo.DB.MSSqlConnectionProvider).IsAssignableFrom(providerType) Then
				Return String.Format("STDEVP({0})", operands(0))
			End If
			Throw New NotSupportedException(String.Format("Provider {0} is not supported.", providerType.FullName))
		End Function
		Private Function ICustomAggregateQueryable_GetMethodInfo() As MethodInfo Implements ICustomAggregateQueryable.GetMethodInfo
			Return GetType(STDEVPCustomAggregate).GetMethod(Name)
		End Function
		Public Shared Function STDEVP(Of T)(ByVal collection As IEnumerable(Of T), ByVal arg As Expression(Of Func(Of T, Object))) As Object
			Throw New InvalidOperationException("This method should not be called explicitly.")
		End Function
		Private Structure Context
			Public Count As Integer
			Public Sum As Double
			Public SumOfSquares As Double
		End Structure
	End Class
End Namespace
