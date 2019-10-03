using DevExpress.Data.Filtering;
using DevExpress.Xpo;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace XpoCustomAggregate {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1() {
            InitializeComponent();

            //Register Custom Aggregates
            STDEVPCustomAggregate.Register();
            CountDistinctCustomAggregate.Register();

            //Load data with XPView
            XPView xpView = new XPView(session1, typeof(Customer));
            xpView.AddProperty("ContactName", CriteriaOperator.Parse("[FirstName] + ' ' + [LastName]"));
            xpView.AddProperty("DistinctProducts", CriteriaOperator.Parse("[Orders][].CountDistinct([ProductName])"));
            xpView.AddProperty("QuantityVariance", CriteriaOperator.Parse("[Orders][].STDEVP([Quantity])"));
            xpView.AddProperty("PriceVariance", CriteriaOperator.Parse("[Orders][].STDEVP([Price])"));
            xpView.Sorting.Add(new SortProperty("ContactName", DevExpress.Xpo.DB.SortingDirection.Ascending));
            gridControl1.DataSource = xpView;

            //Load data using XPQuery
            gridControl2.DataSource = new XPQuery<Customer>(session1)
                .Select(t => new {
                    ContactName = t.ContactName,
                    DistinctProducts = (int)CountDistinctCustomAggregate.CountDistinct(t.Orders, o => o.ProductName),
                    QuantityVariance = (double?)STDEVPCustomAggregate.STDEVP(t.Orders, o => o.Quantity),
                    PriceVariance = (double?)STDEVPCustomAggregate.STDEVP(t.Orders, o => o.Price),
                })
                .OrderBy(t => t.ContactName)
                .ToList();
        }
    }
}
