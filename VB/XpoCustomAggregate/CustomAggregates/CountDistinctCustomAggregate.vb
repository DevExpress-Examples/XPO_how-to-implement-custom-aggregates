Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports System
Imports System.Collections.Generic
Imports System.Linq.Expressions
Imports System.Reflection

Namespace XpoCustomAggregate
	Friend Class CountDistinctCustomAggregate
		Implements ICustomAggregate, ICustomAggregateQueryable, ICustomAggregateFormattable

		Private Shared ReadOnly instance As New CountDistinctCustomAggregate()
		Public Shared Sub Register()
			CriteriaOperator.RegisterCustomAggregate(instance)
		End Sub
		Public Shared Sub Unregister()
			CriteriaOperator.UnregisterCustomAggregate(instance)
		End Sub
		Public ReadOnly Property Name() As String Implements ICustomAggregate.Name
			Get
                Return NameOf(CountDistinct)
            End Get
		End Property
		Private Function ICustomAggregate_ResultType(ParamArray ByVal operands() As Type) As Type Implements ICustomAggregate.ResultType
			Return GetType(Integer)
		End Function
		Private Function ICustomAggregate_CreateEvaluationContext() As Object Implements ICustomAggregate.CreateEvaluationContext
			Return New HashSet(Of Object)()
		End Function
		Private Function ICustomAggregate_Process(ByVal context As Object, ByVal operands() As Object) As Boolean Implements ICustomAggregate.Process
			Dim ctx = DirectCast(context, HashSet(Of Object))
			ctx.Add(operands(0))
			Return False
		End Function
		Private Function ICustomAggregate_GetResult(ByVal context As Object) As Object Implements ICustomAggregate.GetResult
			Dim ctx = DirectCast(context, HashSet(Of Object))
			Return ctx.Count
		End Function
		Private Function ICustomAggregateFormattable_Format(ByVal providerType As Type, ParamArray ByVal operands() As String) As String Implements ICustomAggregateFormattable.Format
			Return String.Format("COUNT(distinct {0})", operands(0))
		End Function
		Private Function ICustomAggregateQueryable_GetMethodInfo() As MethodInfo Implements ICustomAggregateQueryable.GetMethodInfo
			Return GetType(CountDistinctCustomAggregate).GetMethod(Name)
		End Function
		Public Shared Function CountDistinct(Of T)(ByVal collection As IEnumerable(Of T), ByVal arg As Expression(Of Func(Of T, Object))) As Object
			Throw New InvalidOperationException("This method should not be called explicitly.")
		End Function
	End Class
End Namespace
