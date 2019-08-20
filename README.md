<!-- default file list -->
*Files to look at*:
* [Form1.cs](./CS/XpoCustomAggregate/Form1.cs) (VB: [Form1.vb](./VB/XpoCustomAggregate/Form1.vb))
* [Form1.Designer.cs](./CS/XpoCustomAggregate/Form1.Designer.cs) (VB: [Form1.Designer.vb](./VB/XpoCustomAggregate/Form1.Designer.vb))
* [CustomAggregates](./CS/XpoCustomAggregate/CustomAggregates) (VB: [CustomAggregates](./VB/XpoCustomAggregate/CustomAggregates))
* [DataAccess](./CS/XpoCustomAggregate/DataAccess) (VB: [DataAccess](./VB/XpoCustomAggregate/DataAccess))
<!-- default file list end -->

# XPO - How To Implement Custom Aggregates for Collections of Persistent Objects

In addition to predefined [aggregates](https://docs.devexpress.com/CoreLibraries/DevExpress.Data.Filtering.Aggregate) (Sum, Count, Min, Max, Avg, Single, Exists), XPO users can now implement custom aggregates. At this stage, you can use them to query data with XPO using XPQuery and with data sources that support CriteriaOperator (server mode collections are not yet supported).

This example illustrates how to use the CountDistinct and STDEVP custom aggregates with XPView and XPQuery (research the Form1 code behind and designer files).
``` csharp
// Criteria string for a custom aggregate with a detail collection property or Free Joins.
YourCollection.YourCustomAggregate(YourNestedProperty)

// Specific criteria string examples for the Orders collection and the CountDistinct and STDEVP custom aggregates.
[Orders][].CountDistinct([ProductName]) and [Orders][].STDEVP([Price])

// Criteria string for a custom aggregate with a top-level collection of persistent objects.
[].CUSTOM_AGGREGATE('YourCustomAggregate', YourNestedProperty)

// LINQ to XPO usage of custom aggregates (CountDistinct and STDEVP) with a detail collection property.
new XPQuery<Customer>(theSession)
    .Select(t => new {
        ContactName = t.ContactName,
        CountDistinct = CountDistinctCustomAggregate.CountDistinct(
            t.Orders, o => o.ProductName
        ),
        QuantityVariance = STDEVPCustomAggregate.STDEVP(
            t.Orders, o => o.Quantity
        ),
        PriceVariance = STDEVPCustomAggregate.STDEVP(
            t.Orders, o => o.Price
        ),
     }).OrderBy(t => t.ContactName).ToList();
```

To create a custom aggregate, implement the following interfaces: `ICustomAggregate`, `ICustomAggregateQueryable`, `ICustomAggregateFormattable`.
For more information, research the `CountDistinctCustomAggregate` and `STDEVPCustomAggregate` classes in the *XpoCustomAggregate/CustomAggregates* folder.
To register a custom aggregate, use the `CriteriaOperator.RegisterCustomAggregate` method (see the Form1 constructor).
