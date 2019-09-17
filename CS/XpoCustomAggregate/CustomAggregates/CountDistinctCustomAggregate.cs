using DevExpress.Data.Filtering;
using DevExpress.Data.Linq;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace XpoCustomAggregate {
    class CountDistinctCustomAggregate : ICustomAggregate, ICustomAggregateQueryable, ICustomAggregateFormattable, ICustomAggregateConvertibleToExpression {
        static readonly CountDistinctCustomAggregate instance = new CountDistinctCustomAggregate();
        public static void Register() {
            CriteriaOperator.RegisterCustomAggregate(instance);
        }
        public static void Unregister() {
            CriteriaOperator.UnregisterCustomAggregate(instance);
        }
        public string Name { get { return nameof(CountDistinct); } }
        Type ICustomAggregate.ResultType(params Type[] operands) {
            return typeof(int);
        }
        object ICustomAggregate.CreateEvaluationContext() {
            return new HashSet<object>();
        }
        bool ICustomAggregate.Process(object context, object[] operands) {
            var ctx = (HashSet<object>)context;
            ctx.Add(operands[0]);
            return false;
        }
        object ICustomAggregate.GetResult(object context) {
            var ctx = (HashSet<object>)context;
            return ctx.Count;
        }
        string ICustomAggregateFormattable.Format(Type providerType, params string[] operands) {
            return string.Format("COUNT(distinct {0})", operands[0]);
        }
        MethodInfo ICustomAggregateQueryable.GetMethodInfo() {
            return typeof(CountDistinctCustomAggregate).GetMethod(Name);
        }
        public static object CountDistinct<T>(IEnumerable<T> collection, Expression<Func<T, object>> arg) {
            throw new InvalidOperationException("This method should not be called explicitly.");
        }

        Expression ICustomAggregateConvertibleToExpression.Convert(ICriteriaToExpressionConverter converter, Expression collectionProperty, ParameterExpression elementParameter, params Expression[] operands) {
            Type callFrom;
            if(typeof(ParallelQuery).IsAssignableFrom(collectionProperty.Type)) {
                callFrom = typeof(ParallelEnumerable);
            } else {
                callFrom = typeof(Enumerable);
            }
            var lambda = Expression.Lambda(operands[0], elementParameter);
            var selectCall = Expression.Call(callFrom, "Select", new Type[] { elementParameter.Type, operands[0].Type }, collectionProperty, lambda);
            var distinctCall = Expression.Call(callFrom, "Distinct", new Type[] { operands[0].Type }, selectCall);
            return Expression.Call(callFrom, "Count", new Type[] { operands[0].Type }, distinctCall);
        }
    }
}
