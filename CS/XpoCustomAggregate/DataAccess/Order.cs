using DevExpress.Xpo;
using System;

namespace XpoCustomAggregate {

    public class Order :XPObject {
        public Order(Session session) : base(session) { }
        public string ProductName {
            get { return GetPropertyValue<string>(nameof(ProductName)); }
            set { SetPropertyValue(nameof(ProductName), value); }
        }
        public DateTime OrderDate {
            get { return GetPropertyValue<DateTime>(nameof(OrderDate)); }
            set { SetPropertyValue(nameof(OrderDate), value); }
        }
        public decimal Price {
            get { return GetPropertyValue<decimal>(nameof(Price)); }
            set { SetPropertyValue(nameof(Price), value); }
        }
        public decimal Quantity {
            get { return GetPropertyValue<decimal>(nameof(Quantity)); }
            set { SetPropertyValue(nameof(Quantity), value); }
        }
        [Association("CustomerOrders")]
        public Customer Customer {
            get { return GetPropertyValue<Customer>(nameof(Customer)); }
            set { SetPropertyValue(nameof(Customer), value); }
        }
    }
}
