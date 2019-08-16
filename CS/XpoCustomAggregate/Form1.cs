using DevExpress.Xpo;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace XpoCustomAggregate {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            //Register Custom Aggregates
            STDEVPCustomAggregate.Register();
            CountDistinctCustomAggregate.Register();
            
            //Load data using XPQuery
            dataGridView2.DataSource = new XPQuery<Customer>(session1)
                .Select(t => new {
                    ContactName = t.ContactName,
                    CountDistinct = CountDistinctCustomAggregate.CountDistinct(t.Orders, o => o.ProductName),
                    QuantityVariance = STDEVPCustomAggregate.STDEVP(t.Orders, o => o.Quantity),
                    PriceVariance = STDEVPCustomAggregate.STDEVP(t.Orders, o => o.Price),
                })
                .OrderBy(t => t.ContactName)
                .ToList();
        }
    }
}
