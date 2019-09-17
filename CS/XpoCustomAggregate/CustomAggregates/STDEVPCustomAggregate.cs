using DevExpress.Data.Filtering;
using DevExpress.Data.Linq;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace XpoCustomAggregate {
    class STDEVPCustomAggregate : ICustomAggregate, ICustomAggregateQueryable, ICustomAggregateFormattable, ICustomAggregateConvertibleToExpression {
        static readonly STDEVPCustomAggregate instance = new STDEVPCustomAggregate();
        public static void Register() {
            CriteriaOperator.RegisterCustomAggregate(instance);
        }
        public static void Unregister() {
            CriteriaOperator.UnregisterCustomAggregate(instance);
        }
        public string Name { get { return nameof(STDEVP); } }
        Type ICustomAggregate.ResultType(params Type[] operands) {
            return typeof(decimal?);
        }
        object ICustomAggregate.CreateEvaluationContext() {
            return new Context();
        }
        bool ICustomAggregate.Process(object context, object[] operands) {
            var ctx = (Context)context;
            if(operands[0] != null) {
                ctx.Count++;
                ctx.Sum += Convert.ToDouble(operands[0]);
                ctx.SumOfSquares += Math.Pow(Convert.ToDouble(operands[0]), 2);
            }
            return false;
        }
        object ICustomAggregate.GetResult(object context) {
            var ctx = (Context)context;
            if(ctx.Count > 0) {
                return Convert.ToDecimal(Math.Sqrt(ctx.SumOfSquares / ctx.Count - Math.Pow(ctx.Sum / ctx.Count, 2)));
            }
            return null;
        }
        string ICustomAggregateFormattable.Format(Type providerType, params string[] operands) {
            if(typeof(DevExpress.Xpo.DB.MSSqlConnectionProvider).IsAssignableFrom(providerType)) {
                return string.Format("STDEVP({0})", operands[0]);
            }
            throw new NotSupportedException(string.Format("Provider {0} is not supported.", providerType.FullName));
        }
        MethodInfo ICustomAggregateQueryable.GetMethodInfo() {
            return typeof(STDEVPCustomAggregate).GetMethod(Name);
        }
        public static object STDEVP<T>(IEnumerable<T> collection, Expression<Func<T, object>> arg) {
            throw new InvalidOperationException("This method should not be called explicitly.");
        }

        Expression ICustomAggregateConvertibleToExpression.Convert(ICriteriaToExpressionConverter converter, Expression collectionProperty, ParameterExpression elementParameter, params Expression[] operands) {
            Type callFrom;
            if(typeof(ParallelQuery).IsAssignableFrom(collectionProperty.Type)) {
                callFrom = typeof(ParallelEnumerable);
            } else {
                callFrom = typeof(Enumerable);
            }
            Expression operand = Expression.Convert(operands[0], typeof(double));
            Expression operandPower2 = Expression.Call(typeof(Math), "Pow", new Type[] { }, operand, Expression.Constant(2.0));
            Expression sumOfSquares = Expression.Call(callFrom, "Sum", new Type[] { elementParameter.Type }, collectionProperty, Expression.Lambda(operandPower2, elementParameter));
            Expression sum = Expression.Call(callFrom, "Sum", new Type[] { elementParameter.Type }, collectionProperty, Expression.Lambda(operand, elementParameter));
            Expression count = Expression.Call(callFrom, "Count", new Type[] { elementParameter.Type }, collectionProperty);
            count = Expression.Convert(count, typeof(double));
            Expression sumOfSquaresDivide2 = Expression.Divide(sumOfSquares, count);
            Expression sumDivideCountPower2 = Expression.Call(typeof(Math), "Pow", new Type[] { }, Expression.Divide(sum, count), Expression.Constant(2.0));
            Expression subtract = Expression.Subtract(sumOfSquaresDivide2, sumDivideCountPower2);
            return Expression.Call(typeof(Math), "Sqrt", new Type[] { }, subtract);
        }

        class Context {
            public int Count;
            public double Sum;
            public double SumOfSquares;
        }
    }
}
