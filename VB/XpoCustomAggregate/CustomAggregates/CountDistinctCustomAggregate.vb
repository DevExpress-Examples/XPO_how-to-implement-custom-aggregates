Imports DevExpress.Data.Filtering
Imports DevExpress.Data.Linq
Imports DevExpress.Xpo
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection

Namespace XpoCustomAggregate
	Friend Class CountDistinctCustomAggregate
		Implements ICustomAggregate, ICustomAggregateQueryable, ICustomAggregateFormattable, ICustomAggregateConvertibleToExpression

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

		Private Function ICustomAggregateConvertibleToExpression_Convert(ByVal converter As ICriteriaToExpressionConverter, ByVal collectionProperty As Expression, ByVal elementParameter As ParameterExpression, ParamArray ByVal operands() As Expression) As Expression Implements ICustomAggregateConvertibleToExpression.Convert
			Dim callFrom As Type
			If GetType(ParallelQuery).IsAssignableFrom(collectionProperty.Type) Then
				callFrom = GetType(ParallelEnumerable)
			Else
				callFrom = GetType(Enumerable)
			End If
			Dim lambda = Expression.Lambda(operands(0), elementParameter)
			Dim selectCall = Expression.Call(callFrom, "Select", New Type() { elementParameter.Type, operands(0).Type }, collectionProperty, lambda)
			Dim distinctCall = Expression.Call(callFrom, "Distinct", New Type() { operands(0).Type }, selectCall)
			Return Expression.Call(callFrom, "Count", New Type() { operands(0).Type }, distinctCall)
		End Function
	End Class
End Namespace
